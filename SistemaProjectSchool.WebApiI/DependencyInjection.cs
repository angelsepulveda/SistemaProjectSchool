using SistemaProjecrSchool.Infrastructure;
using SistemaProjectSchool.Application;

namespace SistemaProjectSchool.WebApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebApplictionServices(
             this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationModule();
            services.AddInfrastructureModule(configuration);

            return services;
        }
    }
}
