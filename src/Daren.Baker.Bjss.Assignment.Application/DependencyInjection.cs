using Daren.Baker.Bjss.Assignment.Application.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Daren.Baker.Bjss.Assignment.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IValidator<string[]>, ParameterValidator>();

            return services;
        }
    }
}
