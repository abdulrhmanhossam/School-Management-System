using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using School.Core.Behaviors;
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
                => cfg.RegisterServicesFromAssemblies(Assembly
                .GetExecutingAssembly()));

            // Validator Config
            services.AddValidatorsFromAssembly(Assembly
                .GetExecutingAssembly());

            services.AddTransient(
                typeof(IPipelineBehavior<,>),
                typeof(ValidationBehavior<,>));

            return services;
        }
    }
}
