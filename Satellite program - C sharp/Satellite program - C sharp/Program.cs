using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Eksamensprojekt_kode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the satellite-tracker");
            System.Threading.Thread.Sleep(2000);
            Keyword_printer();
        }


        //Prints all menu-options in the console
        public static void Keyword_printer()
        {
            Console.Clear();
            Console.WriteLine("Use the following keywords to use the program:\n");
            Console.WriteLine("\"TLE\"       : Updates/downloads TLE-data for your selected satellite-category.");
            Console.WriteLine("\"TRACK\"     : Displays a satellite of your choice.");
            Console.WriteLine("\"SATINFO\"   : Get launch-year for satellites");
            Console.WriteLine("\"SOURCE\"    : Opens the TLE-source in your browser.");
            Console.WriteLine("\"EXIT\"      : Exits the program.\n");
            Menuswitch();
        }


        // Gets user input
        public static string Menu()
        {
            string menuinput = "";
            try
            {
                menuinput = Console.ReadLine();
                menuinput = menuinput.ToLower();
                return menuinput;
            }
            catch
            {
                Console.WriteLine("Ooops, looks like you wrote an invalid input... Press enter to continue");
                Console.ReadLine();
                Console.Clear();
                Keyword_printer();
            }
            return menuinput;
        }


        //Switches menu
        public static void Menuswitch()
        {
            Console.WriteLine("Input the selected keyword");
            string menuinput = Menu();
            if (menuinput == "tle")
            {
                TLEdownloader.TLE_main();
                Console.Clear();
                Keyword_printer();
            }
            else if (menuinput == "track")
            {
                Track.Satpasses();
            }
            else if (menuinput == "satinfo")
            {
                Satinfo.Satyear_main();
                Console.Clear();
                Keyword_printer();
            }
            else if (menuinput == "source")
            {
                //Tries to open website
                //Prints error message if an exception is thrown
                try
                {
                    string source = @"https://www.celestrak.com/NORAD/elements/";
                    Process.Start(source);
                    Console.Clear();
                    Keyword_printer();
                }
                catch
                {
                    Console.WriteLine("Unable to start browser... Please check you have a browser installed.");
                    Menuswitch();
                }
            }
            else if (menuinput == "exit")
            {
                Console.WriteLine("Thank you for using this program!\n" +
                    "Program shutting down in:");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write("{0}, ", i);
                    System.Threading.Thread.Sleep(1000);
                }
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Ooops, looks like you wrote an invalid input... Press enter to continue");
                Console.ReadLine();
                Console.Clear();
                Keyword_printer();
            }
        }
    }
}
