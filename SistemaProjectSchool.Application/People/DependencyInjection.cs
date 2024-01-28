using SistemaProjectSchool.Application.People.DocumentTypes.Features;

namespace SistemaProjectSchool.Application.People
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPeopleApplicationModule(this IServiceCollection services)
        {
            services.AddDocumentTypesUseCase();

            return services;
        }
    }
}
