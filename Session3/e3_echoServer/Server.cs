using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace e3_echoServer
{
    public class Server
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waking the hamsters....");

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();

            Console.WriteLine("Hamsters running...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();

                Console.WriteLine("Client connected");
                NetworkStream stream = client.GetStream();

                while (true)
                {
                    //Read
                    byte[] dataFromClient = new byte[1024];
                    int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                    string s = Encoding.UTF8.GetString(dataFromClient, 0, bytesRead);
                    Console.WriteLine(s);

                    if (s.Equals("exit"))
                    {
                        // close connection
                        client.Close();
                    }

                    //respond
                    byte[] dataToClient = Encoding.UTF8.GetBytes($"Returning {s}");
                    stream.Write(dataFromClient, 0, dataFromClient.Length);
                }
            }
        }
    }
}