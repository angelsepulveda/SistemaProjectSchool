namespace SistemaProjectSchool.WebApi.Shared
{
    internal static class ServicesConfiguration
    {
        public static WebApplication ConfigurareWebApplicationServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            builder.Services.AddWebApplictionServices(builder.Configuration);

            //agregamos cors
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(config =>
                {
                    config.AllowAnyMethod();
                    config.AllowAnyHeader();
                    config.AllowAnyOrigin();
                });
            });

            return builder.Build();
        }
    }
}
