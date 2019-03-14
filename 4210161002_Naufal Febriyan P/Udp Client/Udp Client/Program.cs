using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace Udp_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient();

            client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"),8080));

            Console.Write(">");
            string inputs = Console.ReadLine();
            if (inputs!=null)
            {
                byte[] bytesent = Encoding.ASCII.GetBytes(inputs);

                client.Send(bytesent, bytesent.Length);
                Console.WriteLine("Succesfully message sent");

                client.Close();
                Console.ReadLine();
            }
        }
    }
}
