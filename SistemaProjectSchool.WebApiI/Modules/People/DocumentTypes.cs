using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;

namespace SistemaProjectSchool.WebApi.Modules.People
{
    internal static class DocumentTypes
    {
        public static WebApplication UseDocumentTypesEndpoints(this WebApplication app)
        {
            app.MapPost("/DocumentTypes", 
                async (ICreateDocumentTypeController controller, CreateDocumentTypePayload payload) =>
            {
                Guid documentTypeId = await controller.Handle(payload);

                return Results.Ok(documentTypeId);

            });

            return app;
        }
    }
}
