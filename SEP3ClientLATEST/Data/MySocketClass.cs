using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace SEP3ClientLATEST.Data
{
    public class MySocketClass
    {
        private TcpClient client;

        public MySocketClass(string ip, int port)
        {
            sendDataToServer("127.0.0.1", 5000);
        }

        public void sendDataToServer(string ip, int port)
        {
            Console.WriteLine("Trying To connect to the server");
            try
            {
                client = new TcpClient(ip, port);
                Console.WriteLine("Connected!");
                NetworkStream stream = client.GetStream();
                Debug.WriteLine("Now what? We are connected ");
            }
            catch (Exception e)
            {
                Debug.WriteLine("WRONG");
                //client.Close();
            }
        }
    }
}