using SistemaProjectSchool.Application.People.DocumentTypes.Features.Actives;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Delete;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Restore;
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
            services.AddScoped<IDeleteDocumentTypeInputPort, DeleteDocumentTypeUseCase>();
            services.AddScoped<IRestoreDocumentTypeInputPort, RestoreDocumentTypeUseCase>();
            services.AddScoped<IActivesDocumentTypeInputPort, ActivesDocumentTypeUseCase>();

            return services;
        }
    }
}
