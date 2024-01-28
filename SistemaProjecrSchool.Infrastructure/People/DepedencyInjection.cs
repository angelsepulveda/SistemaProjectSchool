using SistemaProjecrSchool.Infrastructure.People.DocumentTypes;

namespace SistemaProjecrSchool.Infrastructure.People
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddPeopleInfrastructureModule(this IServiceCollection services) 
        {
            services.AddDocumentTypesInfrastructureModule();

            return services;       
        }
    }
}
