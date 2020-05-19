import ephem
from ephem import degree
import matplotlib.pyplot as plt
from datetime import datetime
import geocoder
import math

import socket

# -------------------------------------------------------------------------------------------------------------------- #


# Creates an Observer class for Ephem computations  with TLE
def observer():
    user = ephem.Observer()
    loc_user = geocoder.ip('me')
    user.lon = str(loc_user.lng)
    user.lat = str(loc_user.lat)
    user.elevation = 0
    user.date = datetime.utcnow()
    return user


# Computes TLE with observer
def compute(TLE, user):
    tle = ephem.readtle(TLE[0], TLE[1], TLE[2])
    try:
        tle.compute(user)
    except ValueError:
        print('TLE is outdated... Try to update TLE')
    if tle.alt / degree > 0:
        print('%s is currently %s degrees above the horizon' % (tle.name, (round(tle.alt / degree, 2))))
        alt_temp = tle.alt / degree
        az_temp = math.radians(tle.az / degree)
        return alt_temp, az_temp


# Creates axes and polar plot
def polar_plot():
    fig = plt.figure()
    ax = fig.add_axes([0.1, 0.1, 0.8, 0.8], polar=True)
    ax.set_theta_zero_location('N')
    plt.title('Sky-view of current visible satellites')
    ax.ThetaDir = 'anticlockwise'
    ax.set_rlim(bottom=90, top=0)
    yLabel = ['0', '', '', '30', '', '', '60', '', '', '90']
    ax.set_yticklabels(yLabel)
    return ax


# Plots the satellites on a polar plot
def plot(alt, az):
    ax = polar_plot()
    for az, alt in zip(az, alt):
        ax.plot(az, alt, 'bo', marker='o')


# -------------------------------------------------------------------------------------------------------------------- #


IPV4 = '127.0.0.1'
PORT = 6060

while True:
    # Connects to TCP-socket
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.bind((IPV4, PORT))
    s.listen(1)
    conn, addr = s.accept()
    print('Connected to: ', addr)
    with conn:
        path = (conn.recv(1024).decode())
        file = open(path, 'r')
        lines = file.readlines()

        user = observer()
        TLE = []

        alt = []
        az = []

        for i in range(0, len(lines)):
            if i % 3 == 0 and i != 0:
                # Checks if "compute(TLE, user)" returns None
                if compute(TLE, user) is not None:
                    alt_temp, az_temp = compute(TLE, user)
                    alt.append(alt_temp)
                    az.append(az_temp)

                TLE.clear()
                TLE.append(lines[i])
            else:
                TLE.append(lines[i])

        plot(alt, az)

        plt.show()
