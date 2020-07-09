using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Amtrack___Satellite_tracking_software
{
    // Contains functions that updates the information discplayed on screen
    class Executions
    {
        // Prints the updatable TLE names
        public static void TLEUpdatePrint(ListBox TLE_Update)
        {
            foreach (string tle in Values.tlenames)
            {
                TLE_Update.Items.Add(tle);
            }
        }

        // Prints downloaded TLE in listbox
        public static void TLEAvailPrint(ListBox TLE_Files)
        {
            TLE_Files.Items.Clear();
            // Updates listbox items with TLE-files in given path
            Values.TLEDownloaded = Directory.GetFiles(Values.TLE_Path, "*.txt");
            foreach (string tle in Values.TLEDownloaded)
            {
                TLE_Files.Items.Add(Path.GetFileName(tle));
            }
        }


        // Prints satellites in clicked TLE
        public static void Sat_print(int name, ListBox Sats)
        {
            Sats.Items.Clear();

            // Creates string array with every line in TLE file
            string TLE_path = Values.TLE_Path + "\\" + Path.GetFileName(Values.TLEDownloaded[name]);
            
            // Prints every third line which will be the sat name
            for (int i = 0; i <= File.ReadLines(TLE_path).Count() - 1; i++)
            {
                if ((i % 3) == 0)
                {
                    Sats.Items.Add(File.ReadLines(TLE_path).Skip(i).Take(1).FirstOrDefault());
                }
            }
        }


        // Updates the satellite information fields when a new satellite is clicked
        public static void Sat_Update(Label Sat_Name, Label Launch_Year, Label Cat_Num)
        {
            Sat_Name.Text = Values.TLESat[0].ToString().Trim();
            Sat_Name.BackColor = Color.LightGreen;

            Launch_Year.Text = TLE_handling.Get_Year();
            Launch_Year.BackColor = Color.LightGreen;

            Cat_Num.Text = Values.TLESat[1].Substring(2, 5);
            Cat_Num.BackColor = Color.LightGreen;
        }


    }
}
