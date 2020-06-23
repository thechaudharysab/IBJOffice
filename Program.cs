using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace IBJOffice
{
    public class Program
    {
        public static void Main(string[] args)
        {
        //This setting below isused by part 2 of the tutorial
            var config = new ConfigurationBuilder().AddCommandLine(args).Build();
            var host = new WebHostBuilder().UseKestrel().UseContentRoot(Directory.GetCurrentDirectory()).UseConfiguration(config).UseIISIntegration().UseStartup<Startup>().Build();

            host.Run();

            //This line below is use in part one of the tutotial
            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
