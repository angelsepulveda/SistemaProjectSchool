namespace SistemaProjectSchool.WebApi.Modules.People
{
    internal static class PeopleEndPoints
    {
        public static WebApplication UsePeopleEndpoints(this WebApplication app)
        {
            app.UseDocumentTypesEndpoints();

            return app;
        }
    }
}
