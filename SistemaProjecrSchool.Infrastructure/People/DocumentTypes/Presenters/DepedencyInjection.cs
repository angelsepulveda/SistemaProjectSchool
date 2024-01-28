using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Presenters
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddDocumentTypesPresenter(this IServiceCollection services)
        {
            services.AddScoped<CreateDocumentTypePresenter>();
            services.AddScoped<ICreateDocumentTypePresenter>(sp => sp.GetRequiredService<CreateDocumentTypePresenter>());
            services.AddScoped<ICreateDocumentTypeOutputPort>(sp => sp.GetRequiredService<CreateDocumentTypePresenter>());

            return services;
        }
    }
}
