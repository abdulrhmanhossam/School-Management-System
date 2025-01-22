using Microsoft.Extensions.DependencyInjection;
using School.Infrustructure.Abstract;
using School.Infrustructure.Repositories;

namespace School.Infrustructure
{
    public static class ModuleInfrastructureDependancies
    {
        public static IServiceCollection AddInfrastructureDependancies
            (this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
