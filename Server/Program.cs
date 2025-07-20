using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpChannel ch = new TcpChannel(2048);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(BankImp),"bank",WellKnownObjectMode.Singleton);
            
            //SingleCall
            Console.Write("Serveur is ready.....");
            Console.Read();
        }
    }
}
