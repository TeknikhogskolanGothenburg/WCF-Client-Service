using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            EchoService.EchoServiceClient proxy = new EchoService.EchoServiceClient();
            var msg = proxy.GetData(666);
            Console.WriteLine(msg);
        }
    }
}
