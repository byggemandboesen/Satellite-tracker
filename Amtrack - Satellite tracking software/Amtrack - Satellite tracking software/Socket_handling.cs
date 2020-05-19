using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Amtrack___Satellite_tracking_software
{
    class Socket_handling
    {
        // Creates TCP-socket
        public static Socket Get_socket(int PORT)
        {
            IPAddress IPV4 = IPAddress.Parse("127.0.0.1");
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(new IPEndPoint(IPV4, PORT));
            return socket;
        }

        // Sends data through given TCP socket
        public static void Send_data(Socket socket, string[] data)
        {
            
            for (int i = 0; i < data.Length; i++)
            {
                socket.Send(Encoding.UTF8.GetBytes(data[i]));
                System.Threading.Thread.Sleep(10);
            }

        }

    }
}
