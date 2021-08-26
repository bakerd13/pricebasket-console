using Daren.Baker.Bjss.Assignment.Application;
using Daren.Baker.Bjss.Assignment.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace PriceBasket
{
    internal static class DependencyInjection
    {
        internal static void RegisterServices(IServiceCollection services)
        {
            services.AddApplicationServices();
            services.AddInfrastructureServices();
        }
    }
}
