using SistemaProjectSchool.WebApiI.Modules;

namespace SistemaProjectSchool.WebApi.Shared
{
    public static class MiddlewaresConfiguration
    {
        public static WebApplication ConfigureWebApiMiddlewares(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //redirecciona peticiones HTTP hacia peticiones HTTPS
            app.UseHttpsRedirection();

            //registrar los endpoints de la aplicación
            app.UseModuleEndpoints();

            //agregar middlewares cors
            app.UseCors();

            return app;
        }
    }
}
