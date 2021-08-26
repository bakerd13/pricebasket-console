using Microsoft.Extensions.DependencyInjection;
using System;

namespace PriceBasket
{
    class Program
    {

        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            DependencyInjection.RegisterServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var main = serviceProvider.GetService<IMain>();

            main.Startup(args);

            Console.WriteLine("Press any key to continue.");
            _ = Console.ReadKey();
        }

        
    }
}
