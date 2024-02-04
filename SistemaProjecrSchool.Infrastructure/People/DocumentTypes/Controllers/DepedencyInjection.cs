using SistemaProjectSchool.Application.People.DocumentTypes.Features.Actives;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Delete;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Restore;
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
            services.AddScoped<IDeleteDocumentTypeController,DeleteDocumentTypeWrapperController>();
            services.AddScoped<IRestoreDocumentTypeController, RestoreDocumentTypeWrapperController>();
            services.AddScoped<IActivesDocumentTypeController, ActivesDocumentTypeWrapperController>();

            return services;
        }
    }
}
