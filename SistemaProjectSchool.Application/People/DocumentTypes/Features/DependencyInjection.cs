using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Update;

namespace SistemaProjectSchool.Application.People.DocumentTypes.Features
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDocumentTypesUseCase(this IServiceCollection services)
        {
            services.AddScoped<ICreateDocumentTypeInputPort, CreateDocumentTypeUseCase>();
            services.AddScoped<IUpdateDocumentTypeInputPort, UpdateDocumentTypeUseCase>();
            services.AddScoped<IGetAllDocumentTypeInputPort, GetAllDocumentTypeUseCase>();

            return services;
        }
    }
}
