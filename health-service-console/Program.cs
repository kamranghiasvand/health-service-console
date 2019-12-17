using Nancy.Hosting.Self;
using SDK;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_service_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var hostConfigs = new HostConfiguration
                {
                    UrlReservations = new UrlReservations() { CreateAutomatically = true }
                };
                var port=ConfigurationManager.AppSettings.Get("port");
                var hostUrl= ConfigurationManager.AppSettings.Get("host");
                var url = string.Format("http://{0}:{1}", hostUrl, port);
                using (var host = new NancyHost(hostConfigs, new Uri(url)))
                {

                    host.Start();
                    Console.WriteLine("Running on "+url);
                    Console.WriteLine("To stop server press any key....");

                    Console.ReadKey();
                    host.Stop();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
    }
}
