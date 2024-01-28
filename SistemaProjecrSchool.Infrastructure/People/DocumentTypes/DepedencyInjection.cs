using SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Controllers;
using SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Database;
using SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Presenters;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddDocumentTypesInfrastructureModule(this IServiceCollection services)
        {
            services.AddDocumentTypeDatabase();
            services.AddDocumentTypesControllers();
            services.AddDocumentTypesPresenter();

            return services;
        }
    }
}
