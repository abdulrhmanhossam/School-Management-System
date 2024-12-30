using Microsoft.Extensions.DependencyInjection;
using School.Infrustructure.Abstract;
using School.Infrustructure.Repositories;
using School.Service.Abstracts;
using School.Service.Implementations;

namespace School.Service
{
    public static class ModuleServiceDependancies
    {
        public static IServiceCollection AddServiceDependancies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}
