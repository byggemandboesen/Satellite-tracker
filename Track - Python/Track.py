import ephem
from ephem import degree
from mpl_toolkits.basemap import Basemap
import matplotlib.pyplot as plt
import numpy as np
from datetime import datetime, timedelta
import math
import geocoder

import socket

# -------------------------------------------------------------------------------------------------------------------- #

# Calculates satellite footprint radius
def get_radius():
    earth_rad = 6371
    sat_altitude = tle_sat.elevation/1000
    sat_radius = math.acos(earth_rad / (earth_rad + sat_altitude)) * (180 / math.pi)
    return sat_radius


# Gets satellite path in the next 90min
# Returns each location as lat/lon coords
def sat_groundpath(tle_sat):
    sat_lon_pred = []
    sat_lat_pred = []
    for i in range(0, 900):
        tle_sat.compute(datetime.utcnow() + timedelta(minutes=i*0.1))
        sat_lat_pred.append(tle_sat.sublat / degree)
        sat_lon_pred.append(tle_sat.sublong / degree)
    return sat_lon_pred, sat_lat_pred


# Draws coastlines and lat/lon lines
def coast_grid(my_map):
    my_map.drawcoastlines(linewidth=0.5, color='gray')
    my_map.drawparallels(np.arange(-90, 90, 30), linewidth=0.5, dashes=[3, 3], labels=[1, 0, 0, 0])
    my_map.drawmeridians(np.arange(my_map.lonmin, my_map.lonmax + 30, 60),
                         linewidth=0.5, dashes=[3, 3], labels=[0, 0, 0, 1])


# Fills water with "aqua", land with green and lakes with blue
# Also adds the night shadow
def colors(my_map):
    my_map.drawmapboundary(fill_color='aqua')
    my_map.fillcontinents(color='greenyellow', lake_color='deepskyblue')
    my_map.nightshade(datetime.utcnow(), alpha=0.5)


# Plots your own location
def home(my_map):
    loc_user = geocoder.ip('me')
    lon_user = loc_user.lng
    lat_user = loc_user.lat
    x_user, y_user = my_map(lon_user, lat_user)
    my_map.plot(x_user, y_user, 'ro', markersize=3)
    plt.text(x_user, y_user, 'Home')


# Creates an Observer class for Ephem computations  with TLE
def observer():
    user = ephem.Observer()
    loc_user = geocoder.ip('me')
    user.lon = str(loc_user.lng)
    user.lat = str(loc_user.lat)
    user.elevation = 0
    user.date = datetime.utcnow()
    return user


# Finds next pass of chosen satellite
def next_pass(user):
    next_pass_info = user.next_pass(tle_sat)
    pass_time = next_pass_info[0]
    pass_elev = round(next_pass_info[3] / degree, 2)
    plt.suptitle('Next %s pass: %s UTC at %s degree max elevation'
                 % (tle_sat.name, pass_time, pass_elev), x=0.5, y=0.05)
    return next_pass_info


# Creates polar plot
def polar_plot(pass_az, pass_elev):
    fig = plt.figure()
    ax = fig.add_axes([0.1, 0.1, 0.8, 0.8], polar=True)
    ax.set_theta_zero_location('N')
    plt.title('Sky-view of next %s pass' % tle_sat.name)
    ax.ThetaDir = 'anticlockwise'
    ax.set_rlim(bottom=90, top=0)
    yLabel = ['0', '', '', '30', '', '', '60', '', '', '90']
    ax.set_yticklabels(yLabel)
    return ax


# Returns az for max elevation in next pass (in rad)
def az_max_elev():
    user = observer()
    user.date = next_pass_info[2]
    tle_sat.compute(user)
    az = math.radians(tle_sat.az / degree)
    return az


# Plots next satellite pass at AOS, max elevation and LOS
def sky_plot(pass_az, pass_elev):
    for az, alt in zip(pass_az, pass_elev):
        ax.plot(az, alt, 'bo', marker='o')


# -------------------------------------------------------------------------------------------------------------------- #


# Sets IP to Localhost
IPV4 = '127.0.0.1'
PORT = 5050

while True:
    # Connects to TCP-socket
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.bind((IPV4, PORT))
    s.listen(1)
    conn, addr = s.accept()
    with conn:
        print('Client connected from, ', addr)
        Line1 = (conn.recv(1024)).decode()
        Line2 = (conn.recv(1024)).decode()
        Line3 = (conn.recv(1024)).decode()

    try:
        #  Creates TLE set from the three lines sent thorugh TCP-socket
        tle_sat = ephem.readtle(Line1, Line2, Line3)
        tle_sat.compute()
    except ValueError as err:
        print(f'Invalid TLE, error: \"{err}\".\nPlease check custom TLE and rerun \"Track.py\".')
        break

    # Creates map and appends it a title
    my_map = Basemap(projection='cyl', resolution='c', area_thresh=1000.0, lat_0=0, lon_0=0)
    figure = my_map
    title = 'Currently tracking: ' + tle_sat.name + ', 90min prediction'
    plt.title(title, fontsize=15)

    # Draws coastlines and lat/lon lines
    coast_grid(my_map)

    # Fills water with "aqua", land with green and lakes with blue
    # Also adds the night shadow
    colors(my_map)

    # Plots your own location
    home(my_map)

    # Plots satellite on the map
    lon = tle_sat.sublong / degree
    lat = tle_sat.sublat / degree
    x, y = my_map(lon, lat)
    my_map.plot(x, y, 'bo', markersize=4)
    plt.text(x, y, tle_sat.name)

    # Plots satellite footprint
    sat_radius = get_radius()
    my_map.tissot(x, y, sat_radius, 100, color='black', alpha=0.4, linestyle='dashed')

    # Plots the satellite groundpath in next 90min
    sat_lon_pred, sat_lat_pred = sat_groundpath(tle_sat)
    my_map.plot(sat_lon_pred, sat_lat_pred, 'wo', markersize=1)

    # Creates Observer and recomputes TLE
    user = observer()
    tle_sat.compute(user)

    # Try catch checks if satellite is never above horizon or the oppsite
    try:
        # Finds next satellite pass for the Observer
        next_pass_info = next_pass(user)

        # Creates list of alt/az values of next pass (used for polar plot)
        pass_elev = (0, round(next_pass_info[3] / degree, 2), 0)
        pass_az = (math.radians(next_pass_info[1] / degree), az_max_elev(), math.radians(next_pass_info[5] / degree))

        # Creates polar plot
        ax = polar_plot(pass_az, pass_elev)

        # Plots satellite at AOS, max elevation and LOS
        sky_plot(pass_az, pass_elev)

        # Connects the dots with a line
        # plt.polar(pass_az, pass_elev)
    except ValueError:
        print('Program can\'t create polar plot...')
        print('Either the satellite is always visible, or it never will be:')
        print('Check if satellite is geostationary')

    plt.show()
