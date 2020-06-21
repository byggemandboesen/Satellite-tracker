using System;
using System.Linq;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Amtrack___Satellite_tracking_software
{
    class TLE_handling
    {
        // Downloads selected TLE
        public static void TLEUpdate(string link, int name)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile(link, Values.TLE_Path + "\\" + Values.tlenames[name]);
            MessageBox.Show("TLE: " + Values.tlenames[name] + " was successfully downloaded!");
        }


        // Gets three TLE lines of clicked satellite and returns them as three item string array
        public static string[] Get_TLE(int pressed)
        {
            string[] TLE = new string[3];
            int line = pressed * 3;

            // Adds each TLE line to string array
            for (int i = 0; i < 3; i++)
            {
                TLE[i] = File.ReadLines(Values.ClickedTLE).Skip(line + i).Take(1).FirstOrDefault();
            }

            return TLE;
        }


        // Gets satellite launch year from TLE
        public static string Get_Year()
        {
            int year_sub = Convert.ToInt32(Values.TLESat[1].Substring(9, 2));

            //Checks is satellite is launched in 1900 or 2000
            if (year_sub <= 20)
            {
                if (year_sub < 10)
                {
                    return Convert.ToString("200" + year_sub);
                }
                else
                {
                    return Convert.ToString("20" + year_sub);
                }
            }
            else if (year_sub > 20)
            {
                return Convert.ToString("19" + year_sub);
            }
            return "Error";
        }
    }
}
