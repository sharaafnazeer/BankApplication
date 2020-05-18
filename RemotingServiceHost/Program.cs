using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels.Http;

namespace RemotingServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel httpChannel = new HttpChannel(8082);
            ChannelServices.RegisterChannel(httpChannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(DataTier.DataTier), "Data", WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Launched");
            Console.ReadLine();

        }
    }
}
