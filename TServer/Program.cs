using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TServer.src;

namespace TServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Server server = new Server(); ;
            if (string.IsNullOrEmpty(str))
            {
               var task = server.CreatedServer();
            }else
            {
               var task   = server.CreatedServer(str);
            }
            Console.ReadLine();
        }
    }
}
