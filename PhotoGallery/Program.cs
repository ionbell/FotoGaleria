using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using PhotoGallery.Infrastructure;
using Microsoft.EntityFrameworkCore;
using PhotoGallery.Infrastructure.Repositories;
using PhotoGallery.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace PhotoGallery
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            


        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.UseKestrel() // de chsakell
                //.UseContentRoot(Directory.GetCurrentDirectory()) // de chsakell
                //.UseIISIntegration() // de chsakell
                .UseStartup<Startup>()
                .Build();


        //var host = new WebHostBuilder()
        //     .UseKestrel()
        //     .UseContentRoot(Directory.GetCurrentDirectory())
        //     .UseIISIntegration()
        //     .UseStartup<Startup>()
        //     .Build();
    }
}
