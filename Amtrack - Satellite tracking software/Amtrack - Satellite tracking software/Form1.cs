using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amtrack___Satellite_tracking_software
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        // User chooses path for TLE-files
        private void GetTLEPath_Click(object sender, EventArgs e)
        {
            Sats.Items.Clear();

            FolderBrowserDialog TLEPath = new FolderBrowserDialog();
            TLEPath.Description = "Please select the folder for your TLE-files:";
            
            if (TLEPath.ShowDialog() == DialogResult.OK)
            {
                Values.TLE_Path = TLEPath.SelectedPath;

                // Prints options to download TLE
                Executions.TLEUpdatePrint(TLE_Update);

                // Prints downloaded TLE
                Executions.TLEAvailPrint(TLE_Files);
                
                GetTLEPath.BackColor = Color.LightGreen;
                Path.Text = Values.TLE_Path;
            }
        }


        // User selects TLE file
        private void TLE_Files_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int TLE_pressed = TLE_Files.IndexFromPoint(e.Location);
            Executions.Sat_print(TLE_pressed, Sats);
            Executions.TLEAvailPrint(TLE_Files);
            Values.ClickedTLE = Values.TLEDownloaded[TLE_pressed];
            label4.Text = System.IO.Path.GetFileName(Values.TLEDownloaded[TLE_pressed]);
        }


        // User selects TLE file to update/download
        private void TLE_Update_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int TLE_pressed = TLE_Update.IndexFromPoint(e.Location);
            
            string download = Values.DownloadPrefix + Values.tlenames[TLE_pressed];

            // Downloads TLE
            TLE_handling.TLEUpdate(download, TLE_pressed);
            
            // Re-updates listbox with available satellites
            Executions.TLEAvailPrint(TLE_Files);
        }


        // User selects a satellite
        private void Sats_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int TLE_pressed = Sats.IndexFromPoint(e.Location);
            Values.TLESat = TLE_handling.Get_TLE(TLE_pressed);
            Executions.Sat_Update(Sat_Name, Launch_Year, Catalog_Number);
        }

        private void Track_Click(object sender, EventArgs e)
        {
            // Checks if satellite has been selected
            if (Values.TLESat == null)
            {
                MessageBox.Show("Please select a satellite first!");
            }
            else
            {
                try
                {
                    Socket socket = Socket_handling.Get_socket(5050);
                    Socket_handling.Send_data(socket, Values.TLESat);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please run \"Track.py\" first");
                }
            }
        }

        private void Active_sats_Click(object sender, EventArgs e)
        {
            // Checks if TLE has been selected
            if (Values.ClickedTLE == null)
            {
                MessageBox.Show("Please select a TLE first!");
            }
            else
            {
                try
                {
                    Socket socket = Socket_handling.Get_socket(6060);
                    string[] data = new string[] { Values.ClickedTLE };
                    Socket_handling.Send_data(socket, data);
                }
                catch
                {
                    MessageBox.Show("Please run \"Visible_sats.py\" first");
                }
            }
        }

        // Sets custom TLE given by user
        private void CustomSatUpdate_Click(object sender, EventArgs e)
        {
            string[] TLE = new string[] { ObjectName.Text, Line1.Text, Line2.Text };
            Values.TLESat = TLE;
            Executions.Sat_Update(Sat_Name, Launch_Year, Catalog_Number);
        }
    }
}
