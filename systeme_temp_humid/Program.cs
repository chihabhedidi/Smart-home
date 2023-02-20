using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
namespace systeme_temp_humid
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel ch = new TcpChannel(8081);
            ChannelServices.RegisterChannel(ch);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(systeme_temp_humid.systeme_temp_humid_imp), "temp_humid",
                                                             WellKnownObjectMode.Singleton);
            //SingleCall
            Console.Write("Le serveur est pret.....");

            Console.Read();
        }
    }
}
