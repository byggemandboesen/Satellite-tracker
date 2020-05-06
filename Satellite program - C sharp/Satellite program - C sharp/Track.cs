using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace Satellite_program___C_sharp
{
    class Track
    {
        public static void Satpasses()
        {
            // Checks if a directory is given
            if (TLE_links.TLE_path == null)
            {
                TLEdownloader.Get_path();
                Satpasses();
            }
            Console.Clear();

            // Checks if TLE is downloaded into directory given
            if (Global.TLE_dir() == true)
            {
                Console.WriteLine("TLE files are necessary to use this feature.");
                TLEdownloader.TLE_main();
            }
            
            Console.Write("Which TLE is the satellite located in?: ");
            string[] TLE = Global.TLE_print();
            int num_tle = Global.User_val();
            string tle_chosen = "";
            
            // Try-catch checks if chosen TLE is valid
            try
            {
                tle_chosen = TLE[num_tle];
            }
            catch
            {
                Console.WriteLine("Looks like you gave an invalid input...");
                System.Threading.Thread.Sleep(2500);
                Satpasses();
            }

            Console.WriteLine("Please choose the satellite you wish to track:");
            string[] Sats = Print_sats(tle_chosen);
            int num_sat = Global.User_val();
            Check_val(num_sat, Sats);
            string[] TLE_sat = Get_tle(tle_chosen, num_sat);

            //Establishes TCP connection
            Socket socket = Socket();

            // Sends TLE to python program
            Send_tle(socket, TLE_sat);
            System.Threading.Thread.Sleep(2500);
            socket.Disconnect(true);

        }


        // Prints all satellites in chosen TLE
        public static string[] Print_sats(string tle_chosen)
        {
            Console.Clear();
            Console.WriteLine("Please select your desired satellite:");
            string file = Convert.ToString(tle_chosen);
            int lines = File.ReadLines(file).Count();

            string[] Sats = new string[lines / 3];

            // Prints satellite names in the chosen TLE
            for (int i = 0; i <= lines - 1; i++)
            {
                if ((i % 3) == 0)
                {
                    //If-statement checks if number (i) is single- or double digited to correct for weird indent
                    if (i / 3 < 10)
                    {
                        Console.WriteLine("{0} : {1}", ((i / 3)), File.ReadLines(file).Skip(i).Take(1).FirstOrDefault());
                        Sats[i / 3] = File.ReadLines(file).Skip(i).Take(1).FirstOrDefault();
                    }
                    else
                    {
                        Console.WriteLine("{0}: {1}", ((i / 3)), File.ReadLines(file).Skip(i).Take(1).FirstOrDefault());
                        Sats[i / 3] = File.ReadLines(file).Skip(i).Take(1).FirstOrDefault();
                    }
                }
            }
            return Sats;
        }


        // Returns string array with the three TLE lines for the chosen satellite
        public static string[] Get_tle(string tle_chosen, int num_sat)
        {
            string[] TLE_sat = new string[3];
            string file = Convert.ToString(tle_chosen);
            for (int i = 0; i < 3; i++)
            {
                TLE_sat[i] = File.ReadLines(file).Skip((num_sat * 3) + i).Take(1).FirstOrDefault();
            }

            return TLE_sat;
        }


        //Sends TLE array to Python program through TCP-socket(localhost, 5050)
        public static void Send_tle(Socket socket, string[] TLE_sat)
        {

            for (int i = 0; i < TLE_sat.Length; i++)
            {
                Console.WriteLine("Sending: \"{0}\"", TLE_sat[i]);
                socket.Send(Encoding.UTF8.GetBytes(TLE_sat[i]));
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("Done!");

        }


        // Checks if the chosen satellite is valid(not outside bounderies)
        public static void Check_val(int num_sat, string[] Sats)
        {
            if (num_sat > Sats.Length - 1)
            {
                Console.WriteLine("Looks like you gave an invalid satellite number...");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
                Satpasses();
            }
        }


        // Creates socket and connects (as host) the TCP-socket to client in the python program
        public static Socket Socket()
        {
            Console.WriteLine("Connecting to tracking-program...");
            IPAddress IPV4 = IPAddress.Parse("127.0.0.1");
            int PORT = 5050;

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(new IPEndPoint(IPV4, PORT));
            Console.WriteLine("Connected to TCP!");

            return socket;
        }
    }
}
