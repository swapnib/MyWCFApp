using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.ServiceClient svr = new ServiceReference.ServiceClient();
           Console.WriteLine(svr.AddInt(1, 2));            
            Console.WriteLine(svr.AddFloat(1.5F,2.6F));

        }
    }
}
