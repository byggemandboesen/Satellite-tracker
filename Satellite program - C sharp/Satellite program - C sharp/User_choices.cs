using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satellite_program___C_sharp
{
    class User_choices
    {
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
