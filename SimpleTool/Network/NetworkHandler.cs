using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleTool.Network
{
    public static class NetworkHandler
    {
        public static bool serverStarted = false;
        public static string serverStatus = "";
        private static Listener server = new Listener();

        public static void StartListening(int port) {
            if (CheckPortOpen(port))
            {
                TcpListener serverSocket = new TcpListener(port);
                TcpClient clientSocket = default(TcpClient);
                int counter = 0;

                serverSocket.Start();
                Debug.WriteLine($"Server started - port {port}");
                serverStarted = true;
                UpdateStatus($"Started! | Listening on port {port}");

                counter = 0;
                while (true)
                {
                    counter += 1;
                    clientSocket = serverSocket.AcceptTcpClient();

                    Debug.WriteLine($"Client connected - {Convert.ToString(counter)} total clients...");

                    Listener client = new Listener();

                    client.startClient(clientSocket, Convert.ToString(counter));


                    Thread.Sleep(500); // Hard sleep on connection handler
                }

                clientSocket.Close();
                serverSocket.Stop();
                Console.WriteLine(" >> " + "exit");
                Console.ReadLine();
            }
            else
            {
                serverStarted = false;
            }
        }

        private static bool CheckPortOpen(int port)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.Connect("127.0.0.1", port);
                    return false;
                }
                catch (Exception)
                {
                    return true;
                }
            }
        }
        public static void UpdateStatus(string status)
        {
            serverStatus = status;
        }


    }
}
