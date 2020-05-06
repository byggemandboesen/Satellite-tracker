using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satellite_program___C_sharp
{
    class Satinfo
    {
        public static void Satyear_main()
        {
            Console.Clear();

            // Checks if a directory is given
            if (TLE_links.TLE_path == null)
            {
                TLEdownloader.Get_path();
                Satyear_main();
            }
            Console.Clear();

            // Checks if TLE is downloaded into directory given
            if (Global.TLE_dir() == true)
            {
                Console.WriteLine("TLE files are necessary to use this feature.");
                TLEdownloader.TLE_main();
            }

            Console.WriteLine("Type the number to the corresponding TLE your satellite is located in:\n");
            string[] TLEs = Global.TLE_print();
            int num = Global.User_val();
            Name_print(num, TLEs);

            /*
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
            */
        }


        //Prints names and launch year for all satellites in chosen TLE
        public static void Name_print(int num, string[] TLEs)
        {
            // Try-catch checks if given value corresponds to TLE
            try
            {
                string file = Convert.ToString(TLEs[num]);
                int lines = File.ReadLines(file).Count();

                for (int i = 0; i <= lines - 1; i++)
                {
                    if ((i % 3) == 0)
                    {
                        //If-statement checks if number (i) is single- or double digited to correct for weird indent
                        if (i / 3 < 10)
                        {
                            Console.WriteLine("{0} : {1}, launched in : {2}", ((i / 3)), File.ReadLines(file).Skip(i).Take(1).FirstOrDefault(), Get_year(file, i));
                        }
                        else
                        {
                            Console.WriteLine("{0}: {1}, launched in : {2}", ((i / 3)), File.ReadLines(file).Skip(i).Take(1).FirstOrDefault(), Get_year(file, i));
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Looks like you gave an invalid number before...");
                System.Threading.Thread.Sleep(2500);
                Satyear_main();
            }
        }


        //Gets launch year from TLE and returns it for each satellite in chosen TLE
        public static string Get_year(string file, int i)
        {
            string year = "N/A";
            string tle_line = File.ReadLines(file).Skip(i + 1).Take(1).FirstOrDefault();
            int year_sub = Convert.ToInt32(tle_line.Substring(9, 2));

            //Checks is satellite is launched in 1900 or 2000
            if (year_sub <= 20)
            {
                if (year_sub < 10)
                {
                    year = Convert.ToString("200" + year_sub);
                }
                else
                {
                    year = Convert.ToString("20" + year_sub);
                }
            }
            else if (year_sub > 20)
            {
                year = Convert.ToString("19" + year_sub);
            }
            return year;
        }
    }
}

