using SistemaProjectSchool.Application.People.DocumentTypes.Features.Actives;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Update;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Presenters
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddDocumentTypesPresenter(this IServiceCollection services)
        {
            services.AddScoped<CreateDocumentTypePresenter>();
            services.AddScoped<ICreateDocumentTypePresenter>(sp => sp.GetRequiredService<CreateDocumentTypePresenter>());
            services.AddScoped<ICreateDocumentTypeOutputPort>(sp => sp.GetRequiredService<CreateDocumentTypePresenter>());

            services.AddScoped<UpdateDocumentTypePresenter>();
            services.AddScoped<IUpdateDocumentTypePresenter>(sp => sp.GetRequiredService<UpdateDocumentTypePresenter>());
            services.AddScoped<IUpdateDocumentTypeOutputPort>(sp => sp.GetRequiredService<UpdateDocumentTypePresenter>());

            services.AddScoped<GetAllDocumentTypePresenter>();
            services.AddScoped<IGetAllDocumentTypePresenter>(sp => sp.GetRequiredService<GetAllDocumentTypePresenter>());
            services.AddScoped<IGetAllDocumentTypeOutputPort>(sp => sp.GetRequiredService<GetAllDocumentTypePresenter>());

            services.AddScoped<ActivesDocumentTypePresenter>();
            services.AddScoped<IActivesDocumentTypePresenter>(sp => sp.GetRequiredService<ActivesDocumentTypePresenter>());
            services.AddScoped<IActivesDocumentTypesOutputPort>(sp => sp.GetRequiredService<ActivesDocumentTypePresenter>());

            return services;
        }
    }
}
