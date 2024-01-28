using SistemaProjectSchool.WebApi.Modules.People;

namespace SistemaProjectSchool.WebApiI.Modules
{
    internal static class Endpoints
    {
        public static WebApplication UseModuleEndpoints(this WebApplication app)
        {
            app.UsePeopleEndpoints();

            return app;
        }
    }
}
