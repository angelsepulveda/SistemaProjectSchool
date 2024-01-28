using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;

namespace SistemaProjectSchool.WebApi.Modules.People.DocumentTypes
{
    internal static class DocumentTypesEndPoints
    {
        public static WebApplication UseDocumentTypesEndpoints(this WebApplication app)
        {
            app.MapPost("/DocumentTypes",
                async (ICreateDocumentTypeController controller, CreateDocumentTypePayload payload) =>
            {
                Guid documentTypeId = await controller.Handle(payload);

                return Results.Ok(documentTypeId);

            }).AddEndpointFilter<ValidatorFilter<CreateDocumentTypePayload>>()
              .Produces(StatusCodes.Status200OK)
              .Produces<CodeErrorException>(StatusCodes.Status400BadRequest)
              .Produces<CodeErrorException>(StatusCodes.Status500InternalServerError);

            return app;
        }
    }
}
