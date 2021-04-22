﻿using Microsoft.Extensions.DependencyInjection;
using UptoV2Demo;
using Utilities.Generator;

using static System.Console;

namespace Try.UptoV2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create service collection
            var services = ConfigureServices();

            // Generate a provider
            var serviceProvider = services.BuildServiceProvider();

            // Kick off our actual code
            serviceProvider.GetService<TryNamesArrayApplication>().Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<INameGenerator, NameGenerator>();
            services.AddTransient<IPrintHelper, PrintHelper>();
            services.AddTransient<INamesArray, NamesArray>();

            // IMPORTANT! Register our application entry point
            services.AddTransient<TryNamesArrayApplication>();

            return services;
        }
    }
}