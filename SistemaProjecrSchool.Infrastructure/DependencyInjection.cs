using Microsoft.Extensions.Configuration;
using SistemaProjecrSchool.Infrastructure.People;

namespace SistemaProjecrSchool.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureModule(this IServiceCollection services, IConfiguration configuration)
        {
            string? connectionSqlServerString = configuration.GetConnectionString("PeopleDBSCHOOL");

            services.AddDbContext<ApplicationDbContext>(options => 
                     options.UseSqlServer(connectionSqlServerString));

            services.AddScoped<IUnitOfWork>(sp =>
             sp.GetRequiredService<ApplicationDbContext>());

            services.AddPeopleInfrastructureModule();

            return services;
        }
    }
}
