using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Controllers
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddDocumentTypesControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreateDocumentTypeController, CreateDocumentTypeWrapperController>();

            return services;
        }
    }
}
