using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MulticastClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient(20000);
            client.JoinMulticastGroup(IPAddress.Parse("224.0.0.0"));
            client.EnableBroadcast = false;
            IPEndPoint endPoint = null;
            Console.WriteLine("Multicast client started");
            while(true)
            {
                var bytes = client.Receive(ref endPoint);
                var message = Encoding.Default.GetString(bytes);
                Console.WriteLine("{0} {1}", endPoint.Address.ToString(), message);
            }
        }
    }
}
