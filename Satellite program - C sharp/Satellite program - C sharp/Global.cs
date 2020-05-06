using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Satellite_program___C_sharp
{
    class Global
    {
        // Prints all the downloaded TLE files and returns their file-loc as array
        public static string[] TLE_print()
        {
            string[] TLEs = Directory.GetFiles(TLE_links.TLE_path, "*.txt");

            for (int i = 0; i < TLEs.Length; i++)
            {
                //If-statement checks if number (i) is single- or double digited to correct for weird indent
                if (i < 10)
                {
                    Console.WriteLine("{0} : {1}", i, TLE_name(TLEs, i));
                }
                else
                {
                    Console.WriteLine("{0}: {1}", i, TLE_name(TLEs, i));
                }
            }
            return TLEs;
        }


        //Substrings the TLE file name so the entire dir is not included when printed out
        public static string TLE_name(string[] TLEs, int i)
        {
            string TLE_name;
            int dir_length = TLE_links.TLE_path.Length + 1;
            int TLE_name_length = TLEs[i].Length - dir_length;

            TLE_name = TLEs[i].Substring(dir_length, TLE_name_length);

            return TLE_name;
        }


        //Checks if TLE folder is empty:
        public static bool TLE_dir()
        {
            bool empty;
            string[] TLEs = Directory.GetFiles(TLE_links.TLE_path, "*.txt");

            if (TLEs.Length == 0)
            {
                empty = true;
            }
            else
            {
                empty = false;
            }
            return empty;
        }
        
        
        // Checks if user gives a valid input when chosing TLE-num or sat-num
        public static int User_val()
        {
            int num_sat = 0;
            try
            {
                Console.Write("Number: ");
                num_sat = Convert.ToInt32(Console.ReadLine());
                return num_sat;
            }
            catch
            {
                Console.WriteLine("Invalid input... Please try again");
                User_val();
            }
            return num_sat;
        }
    }
}
