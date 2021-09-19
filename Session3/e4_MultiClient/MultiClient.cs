using System;
using System.Net.Sockets;
using System.Text;

namespace e4_MultiClient
{
    class MultiClient
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waking client");

            TcpClient client = new TcpClient("127.0.0.1", 5000);

            NetworkStream stream = client.GetStream();

            string toServer = "";

            while (!toServer.Equals("exit"))
            {
                toServer = Console.ReadLine();
                byte[] dataToServer = Encoding.UTF8.GetBytes(toServer);
                stream.Write(dataToServer, 0, dataToServer.Length);

                
                byte[] dataFromServer = new byte[1024];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.UTF8.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine(response);
            }

            stream.Close();
            client.Close();
        }
    }
}