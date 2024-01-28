using SistemaProjectSchool.Application.People;

namespace SistemaProjectSchool.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services.AddPeopleApplicationModule();

            return services;
        }
    }
}
