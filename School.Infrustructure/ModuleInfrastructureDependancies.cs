using Microsoft.Extensions.DependencyInjection;
using School.Infrustructure.Abstract;
using School.Infrustructure.InfrustructureBases;
using School.Infrustructure.Repositories;

namespace School.Infrustructure
{
    public static class ModuleInfrastructureDependancies
    {
        public static IServiceCollection AddInfrastructureDependancies
            (this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>),
                typeof(GenericRepositoryAsync<>));
            return services;
        }
    }
}
