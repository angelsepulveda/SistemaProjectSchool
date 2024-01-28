namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Database
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDocumentTypeDatabase(this IServiceCollection services)
        {
            services.AddScoped<IDocumentTypeCommandRepository, DocumentTypeCommandEFCoreRepository>();
            services.AddScoped<IDocumentTypeQueryRepository, DocumentTypeQueryEFCoreRepository>();

            return services;
        }
    }
}
