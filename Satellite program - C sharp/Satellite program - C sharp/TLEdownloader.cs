using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Satellite_program___C_sharp
{
    //Class that saves all the links to different TLE files and stores the directory for TLE that user has given
    class TLE_links
    {
        public static String amateur = @"https://www.celestrak.com/NORAD/elements/amateur.txt";
        public static String cubesat = @"https://www.celestrak.com/NORAD/elements/cubesat.txt";
        public static String dmc = @"https://www.celestrak.com/NORAD/elements/dmc.txt";
        public static String education = @"https://www.celestrak.com/NORAD/elements/education.txt";
        public static String engineering = @"https://www.celestrak.com/NORAD/elements/engineering.txt";
        public static String geo = @"https://www.celestrak.com/NORAD/elements/geo.txt";
        public static String geodetic = @"https://www.celestrak.com/NORAD/elements/geodetic.txt";
        public static String globalstar = @"https://www.celestrak.com/NORAD/elements/globalstar.txt";
        public static String glo_ops = @"https://www.celestrak.com/NORAD/elements/glo-ops.txt";
        public static String goes = @"https://www.celestrak.com/NORAD/elements/goes.txt";
        public static String gorizont = @"https://www.celestrak.com/NORAD/elements/gorizont.txt";
        public static String gps_ops = @"https://www.celestrak.com/NORAD/elements/gps-ops.txt";
        public static String intelsat = @"https://www.celestrak.com/NORAD/elements/intelsat.txt";
        public static String iridium = @"https://www.celestrak.com/NORAD/elements/iridium.txt";
        public static String military = @"https://www.celestrak.com/NORAD/elements/military.txt";
        public static String molniya = @"https://www.celestrak.com/NORAD/elements/molniya.txt";
        public static String musson = @"https://www.celestrak.com/NORAD/elements/musson.txt";
        public static String nnss = @"https://www.celestrak.com/NORAD/elements/nnss.txt";
        public static String noaa = @"https://www.celestrak.com/NORAD/elements/noaa.txt";
        public static String orbcomm = @"https://www.celestrak.com/NORAD/elements/orbcomm.txt";
        public static String other = @"https://www.celestrak.com/NORAD/elements/other.txt";
        public static String other_common = @"https://www.celestrak.com/NORAD/elements/other-common.txt";
        public static String radar = @"https://www.celestrak.com/NORAD/elements/radar.txt";
        public static String raduga = @"https://www.celestrak.com/NORAD/elements/.txt";
        public static String resource = @"https://www.celestrak.com/NORAD/elements/resource.txt";
        public static String sarsat = @"https://www.celestrak.com/NORAD/elements/sarsat.txt";
        public static String science = @"https://www.celestrak.com/NORAD/elements/science.txt";
        public static String stations = @"https://www.celestrak.com/NORAD/elements/stations.txt";
        public static String tdrss = @"https://www.celestrak.com/NORAD/elements/tdrss.txt";
        public static String tle_new = @"https://www.celestrak.com/NORAD/elements/tle-new.txt";
        public static String visual = @"https://www.celestrak.com/NORAD/elements/visual.txt";
        public static String weather = @"https://www.celestrak.com/NORAD/elements/weather.txt";
        public static String x_comm = @"https://www.celestrak.com/NORAD/elements/x-comm.txt";
        public static string[] tlenames = new string[] { "amateur", "cubesat", "dmc", "education", "engineering", "geo", "geodetic",
                "globalstar", "glo_ops", "goes", "gorizont", "gps_ops", "intelsat", "iridium", "military", "molniya",
                "musson", "nnss", "noaa", "orbcomm", "other", "other_common", "radar", "raduga", "resource", "sarsat",
                "science", "stations", "tdrss", "tle_new", "visual", "weather", "x_comm"};
        public static String TLE_path { get; set; }
    }

    class TLEdownloader
    {

        public static void TLE_main()
        {
            if (TLE_links.TLE_path == null)
            {
                Get_path();
                TLE_main();
            }
            else
            {
                int Tle_choice = Tle_print();
                Downloader(Tle_choice);
            }

            Console.Clear();
        }


        //Gets and sets the file location for TLE folder. Also checks if dir exists
        public static void Get_path()
        {
            Console.WriteLine("Please input the path to your desired TLE folder(This will be the folder the TLE-data is stored):");
            string tle_dir = Console.ReadLine();
            if (Directory.Exists(tle_dir))
            {
                TLE_links.TLE_path = tle_dir;
            }
            else
            {
                Console.WriteLine("Oooops, it looks like the path isn't available... Please try again.");
                Console.Clear();
                Get_path();
            }
        }


        //Prints all TLE options into console
        public static int Tle_print()
        {
            Console.WriteLine("Input which TLE you wish to update/download:");

            for (int i = 0; i < TLE_links.tlenames.Length; i++)
            {
                if (i < 10)
                {
                    Console.WriteLine("{0} : {1}", i, TLE_links.tlenames[i]);
                }
                else
                {
                    Console.WriteLine("{0}: {1}", i, TLE_links.tlenames[i]);
                }
            }
            Console.WriteLine("{0}: Update all", TLE_links.tlenames.Length);

            int tle_choice = 0;
            Console.Write("Number: ");
            try
            {
                tle_choice = Convert.ToInt32(Console.ReadLine());
                if (tle_choice > TLE_links.tlenames.Length || tle_choice < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input... Try again:");
                    TLE_main();
                }
            }
            catch
            {
                Console.WriteLine("Invalid input... try again:");
                Tle_print();
            }
            Console.Clear();
            return tle_choice;
        }


        //Downloads the chosen TLE file or downloads all if all is chosen
        public static void Downloader(int Tle_choice)
        {
            Console.WriteLine("TLE downloading... If all is selected this may take a couple seconds..");

            WebClient Client = new WebClient();

            //Switchcase that downloads chosen TLE
            switch (Tle_choice)
            {
                case 0:
                    Client.DownloadFile(TLE_links.amateur, (TLE_links.TLE_path) + "\\amateur.txt");
                    break;
                case 1:
                    Client.DownloadFile(TLE_links.cubesat, (TLE_links.TLE_path) + "\\cubesat.txt");
                    break;
                case 2:
                    Client.DownloadFile(TLE_links.dmc, (TLE_links.TLE_path) + "\\dmc.txt");
                    break;
                case 3:
                    Client.DownloadFile(TLE_links.education, (TLE_links.TLE_path) + "\\education.txt");
                    break;
                case 4:
                    Client.DownloadFile(TLE_links.engineering, (TLE_links.TLE_path) + "\\engineering.txt");
                    break;
                case 5:
                    Client.DownloadFile(TLE_links.geo, (TLE_links.TLE_path) + "\\geo.txt");
                    break;
                case 6:
                    Client.DownloadFile(TLE_links.geodetic, (TLE_links.TLE_path) + "\\geodetic.txt");
                    break;
                case 7:
                    Client.DownloadFile(TLE_links.globalstar, (TLE_links.TLE_path) + "\\globalstar.txt");
                    break;
                case 8:
                    Client.DownloadFile(TLE_links.glo_ops, (TLE_links.TLE_path) + "\\glo_ops.txt");
                    break;
                case 9:
                    Client.DownloadFile(TLE_links.goes, (TLE_links.TLE_path) + "\\goes.txt");
                    break;
                case 10:
                    Client.DownloadFile(TLE_links.gorizont, (TLE_links.TLE_path) + "\\gorizont.txt");
                    break;
                case 11:
                    Client.DownloadFile(TLE_links.gps_ops, (TLE_links.TLE_path) + "\\gps_ops.txt");
                    break;
                case 12:
                    Client.DownloadFile(TLE_links.intelsat, (TLE_links.TLE_path) + "\\intelsat.txt");
                    break;
                case 13:
                    Client.DownloadFile(TLE_links.iridium, (TLE_links.TLE_path) + "\\iridium.txt");
                    break;
                case 14:
                    Client.DownloadFile(TLE_links.military, (TLE_links.TLE_path) + "\\military.txt");
                    break;
                case 15:
                    Client.DownloadFile(TLE_links.molniya, (TLE_links.TLE_path) + "\\molniya.txt");
                    break;
                case 16:
                    Client.DownloadFile(TLE_links.musson, (TLE_links.TLE_path) + "\\musson.txt");
                    break;
                case 17:
                    Client.DownloadFile(TLE_links.nnss, (TLE_links.TLE_path) + "\\nnss.txt");
                    break;
                case 18:
                    Client.DownloadFile(TLE_links.noaa, (TLE_links.TLE_path) + "\\noaa.txt");
                    break;
                case 19:
                    Client.DownloadFile(TLE_links.orbcomm, (TLE_links.TLE_path) + "\\orbcomm.txt");
                    break;
                case 20:
                    Client.DownloadFile(TLE_links.other, (TLE_links.TLE_path) + "\\other.txt");
                    break;
                case 21:
                    Client.DownloadFile(TLE_links.other_common, (TLE_links.TLE_path) + "\\other_common.txt");
                    break;
                case 22:
                    Client.DownloadFile(TLE_links.radar, (TLE_links.TLE_path) + "\\radar.txt");
                    break;
                case 23:
                    Client.DownloadFile(TLE_links.raduga, (TLE_links.TLE_path) + "\\raduga.txt");
                    break;
                case 24:
                    Client.DownloadFile(TLE_links.resource, (TLE_links.TLE_path) + "\\resource.txt");
                    break;
                case 25:
                    Client.DownloadFile(TLE_links.sarsat, (TLE_links.TLE_path) + "\\sarsat.txt");
                    break;
                case 26:
                    Client.DownloadFile(TLE_links.science, (TLE_links.TLE_path) + "\\science.txt");
                    break;
                case 27:
                    Client.DownloadFile(TLE_links.stations, (TLE_links.TLE_path) + "\\stations.txt");
                    break;
                case 28:
                    Client.DownloadFile(TLE_links.tdrss, (TLE_links.TLE_path) + "\\tdrss.txt");
                    break;
                case 29:
                    Client.DownloadFile(TLE_links.tle_new, (TLE_links.TLE_path) + "\\tle_new.txt");
                    break;
                case 30:
                    Client.DownloadFile(TLE_links.visual, (TLE_links.TLE_path) + "\\visual.txt");
                    break;
                case 31:
                    Client.DownloadFile(TLE_links.weather, (TLE_links.TLE_path) + "\\weather.txt");
                    break;
                case 32:
                    Client.DownloadFile(TLE_links.x_comm, (TLE_links.TLE_path) + "\\x_comm.txt");
                    break;
                case 33:
                    Client.DownloadFile(TLE_links.amateur, (TLE_links.TLE_path) + "\\amateur.txt");
                    Client.DownloadFile(TLE_links.cubesat, (TLE_links.TLE_path) + "\\cubesat.txt");
                    Client.DownloadFile(TLE_links.dmc, (TLE_links.TLE_path) + "\\dmc.txt");
                    Client.DownloadFile(TLE_links.education, (TLE_links.TLE_path) + "\\education.txt");
                    Client.DownloadFile(TLE_links.engineering, (TLE_links.TLE_path) + "\\engineering.txt");
                    Client.DownloadFile(TLE_links.geo, (TLE_links.TLE_path) + "\\geo.txt");
                    Client.DownloadFile(TLE_links.geodetic, (TLE_links.TLE_path) + "\\geodetic.txt");
                    Client.DownloadFile(TLE_links.globalstar, (TLE_links.TLE_path) + "\\globalstar.txt");
                    Client.DownloadFile(TLE_links.glo_ops, (TLE_links.TLE_path) + "\\glo_ops.txt");
                    Client.DownloadFile(TLE_links.goes, (TLE_links.TLE_path) + "\\goes.txt");
                    Client.DownloadFile(TLE_links.gorizont, (TLE_links.TLE_path) + "\\gorizont.txt");
                    Client.DownloadFile(TLE_links.gps_ops, (TLE_links.TLE_path) + "\\gps_ops.txt");
                    Client.DownloadFile(TLE_links.intelsat, (TLE_links.TLE_path) + "\\intelsat.txt");
                    Client.DownloadFile(TLE_links.iridium, (TLE_links.TLE_path) + "\\iridium.txt");
                    Client.DownloadFile(TLE_links.military, (TLE_links.TLE_path) + "\\military.txt");
                    Client.DownloadFile(TLE_links.molniya, (TLE_links.TLE_path) + "\\molniya.txt");
                    Client.DownloadFile(TLE_links.musson, (TLE_links.TLE_path) + "\\musson.txt");
                    Client.DownloadFile(TLE_links.nnss, (TLE_links.TLE_path) + "\\nnss.txt");
                    Client.DownloadFile(TLE_links.noaa, (TLE_links.TLE_path) + "\\noaa.txt");
                    Client.DownloadFile(TLE_links.orbcomm, (TLE_links.TLE_path) + "\\orbcomm.txt");
                    Client.DownloadFile(TLE_links.other, (TLE_links.TLE_path) + "\\other.txt");
                    Client.DownloadFile(TLE_links.other_common, (TLE_links.TLE_path) + "\\other_common.txt");
                    Client.DownloadFile(TLE_links.radar, (TLE_links.TLE_path) + "\\radar.txt");
                    Client.DownloadFile(TLE_links.raduga, (TLE_links.TLE_path) + "\\raduga.txt");
                    Client.DownloadFile(TLE_links.resource, (TLE_links.TLE_path) + "\\resource.txt");
                    Client.DownloadFile(TLE_links.sarsat, (TLE_links.TLE_path) + "\\sarsat.txt");
                    Client.DownloadFile(TLE_links.science, (TLE_links.TLE_path) + "\\science.txt");
                    Client.DownloadFile(TLE_links.stations, (TLE_links.TLE_path) + "\\stations.txt");
                    Client.DownloadFile(TLE_links.tdrss, (TLE_links.TLE_path) + "\\tdrss.txt");
                    Client.DownloadFile(TLE_links.tle_new, (TLE_links.TLE_path) + "\\tle_new.txt");
                    Client.DownloadFile(TLE_links.visual, (TLE_links.TLE_path) + "\\visual.txt");
                    Client.DownloadFile(TLE_links.weather, (TLE_links.TLE_path) + "\\weather.txt");
                    Client.DownloadFile(TLE_links.x_comm, (TLE_links.TLE_path) + "\\x_comm.txt");
                    break;
                default:
                    Console.WriteLine("Invalid input...");
                    break;
            }
        }
    }
}
