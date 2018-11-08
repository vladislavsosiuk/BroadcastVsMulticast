using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UnicastClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient client = new UdpClient(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 20000));
            IPEndPoint endPoint = null;
            Console.WriteLine("Unicast client started");
            while(true)
            {
                var bytes = client.Receive(ref endPoint);
                var message = Encoding.Default.GetString(bytes);
                Console.WriteLine("{0} {1}", endPoint.Address.ToString(), message);
            }
        }
    }
}
