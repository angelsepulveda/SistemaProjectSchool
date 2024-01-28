using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;

namespace SistemaProjectSchool.Application.People.DocumentTypes.Features
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDocumentTypesUseCase(this IServiceCollection services)
        {
            services.AddScoped<ICreateDocumentTypeInputPort, CreateDocumentTypeUseCase>();

            return services;
        }
    }
}
