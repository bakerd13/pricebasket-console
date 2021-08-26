using Daren.Baker.Bjss.Assignment.Infrastructure.Providers;
using Daren.Baker.Bjss.Assignment.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Daren.Baker.Bjss.Assignment.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IJsonFileProvider<>), typeof(JsonFileProvider<>));
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
