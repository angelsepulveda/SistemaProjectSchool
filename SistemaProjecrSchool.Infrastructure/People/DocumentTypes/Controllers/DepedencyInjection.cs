using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Update;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Controllers
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddDocumentTypesControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreateDocumentTypeController, CreateDocumentTypeWrapperController>();
            services.AddScoped<IUpdateDocumentTypeController, UpdateDocumentTypeWrapperController>();
            services.AddScoped<IGetAllDocumentTypeController, GetAllDocumentTypeWrapperController>();

            return services;
        }
    }
}
