using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BroadcastClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient(20000);
            Console.WriteLine("Broadcast client started");
            IPEndPoint endPoint = null;
            while (true)
            {
                var bytes = client.Receive(ref endPoint);
                var message = Encoding.Default.GetString(bytes);
                Console.WriteLine("{0} {1}", endPoint.Address.ToString(), message);
            }
        }
    }
}
