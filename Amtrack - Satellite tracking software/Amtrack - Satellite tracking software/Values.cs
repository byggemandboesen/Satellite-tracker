using System;
using System.IO;

namespace Amtrack___Satellite_tracking_software
{
    class Values
    {
        // Path to TLE-folder
        public static String TLE_Path = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "TLE");

        // TLE names
        public static string[] tlenames = new string[] { "amateur.txt", "cubesat.txt", "dmc.txt", "education.txt",
            "engineering.txt", "geo.txt", "geodetic.txt", "globalstar.txt", "glo_ops.txt", "goes.txt", "gorizont.txt",
            "gps_ops.txt", "intelsat.txt", "iridium.txt", "military.txt", "molniya.txt", "musson.txt", "nnss.txt",
            "noaa.txt", "orbcomm.txt", "other.txt", "other_common.txt", "radar.txt", "raduga.txt", "resource.txt",
            "sarsat.txt", "science.txt", "stations.txt", "tdrss.txt", "tle_new.txt", "visual.txt", "weather.txt", "x_comm.txt"};

        // Prefix for downloading TLE
        public static String DownloadPrefix = "https://www.celestrak.com/NORAD/elements/";


        // String array of TLEs in given path
        public static string[] TLEDownloaded { get; set; }

        // Current clicked TLE
        public static string ClickedTLE { get; set; }

        // String array of clicked satellite's TLE
        public static string[] TLESat { get; set; }

    }
}
