using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BroadcastServer
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient();
            var endPoint = new IPEndPoint(IPAddress.Broadcast, 20000);
            Console.WriteLine("Broadcast server started");
            while(true)
            {
                string message = Console.ReadLine();
                var bytes = Encoding.Default.GetBytes(message);
                client.Send(bytes, bytes.Length, endPoint);
            }
        }
    }
}
