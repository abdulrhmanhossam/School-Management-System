using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace School.Core
{
    public static class ModuleCoreDependancies
    {
        public static IServiceCollection AddCoreDependancies(this IServiceCollection services)
        {
            //AutoMapper Config
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // MediatR Config
            services.AddMediatR(cfg
                => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
