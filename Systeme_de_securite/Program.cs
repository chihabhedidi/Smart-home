using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Threading.Tasks;
using Systeme_de_securite.function;
using Systeme_de_securite.database;
using System.Data.Entity;
namespace Systeme_de_securite

{
    internal class Program
    {
        public static async void LoadFunction()
        {
            try
            {

                await shared.db.users.LoadAsync();
                await shared.db.requests.LoadAsync();
                await shared.db.historiques.LoadAsync();


                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        static void Main(string[] args)
        {

            LoadFunction();
            
            TcpChannel ch = new TcpChannel(8080);
            ChannelServices.RegisterChannel(ch);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Systeme_de_securite.securite_implementation), "securite",
                                                             WellKnownObjectMode.Singleton);
            //SingleCall
            Console.Write("Le serveur est pret.....");
            Console.Read();
        }
    }

}
