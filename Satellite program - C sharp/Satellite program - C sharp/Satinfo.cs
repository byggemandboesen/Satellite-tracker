using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensprojekt_kode
{
    class Satinfo
    {
        public static void Satyear_main()
        {
            Console.Clear();
            Console.WriteLine("Choose your desired TLE:");

            Console.WriteLine("Type the number to the corresponding TLE your satellite is located in:\n");

            if (Path_check() == false)
            {
                TLEdownloader.Get_path();
                Satyear_main();
            }
            else
            {
                string[] TLEs = TLE_print();

                int num = User_choices.User_val();

                Name_print(num, TLEs);
            }

            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
        }


        // Checks if file location to TLE-folder is empty, if empty, user will be asked to fill in file path
        public static bool Path_check()
        {
            bool path;
            if (TLE_links.TLE_path == null)
            {
                path = false;
            }
            else
            {
                path = true;
            }
            return path;
        }


        // Prints all the downloaded TLE files and returns their file-loc as array
        public static string[] TLE_print()
        {
            string[] TLEs = Directory.GetFiles(TLE_links.TLE_path);
            if (TLEs == null)
            {
                Console.WriteLine("It looks like you need to download TLE before it's available here..");
                TLEdownloader.TLE_main();
            }
            else
            {
                for (int i = 0; i < TLE_links.tlenames.Length; i++)
                {
                    //If-statement checks if number (i) is single- or double digited to correct for weird indent
                    if (i < 10)
                    {
                        Console.WriteLine("{0} : {1}", i, TLE_links.tlenames[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0}: {1}", i, TLE_links.tlenames[i]);
                    }
                }
            }
            return TLEs;
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

