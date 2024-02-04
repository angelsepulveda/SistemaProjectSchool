using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Update;

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

            app.MapPut("/DocumentTypes",
              async (IUpdateDocumentTypeController controller, UpdateDocumentTypePayload payload) =>
              {
                  Guid documentTypeId = await controller.Handle(payload);

                  return Results.Ok(documentTypeId);

              }).AddEndpointFilter<ValidatorFilter<UpdateDocumentTypePayload>>()
            .Produces(StatusCodes.Status200OK)
            .Produces<CodeErrorException>(StatusCodes.Status400BadRequest)
            .Produces<CodeErrorException>(StatusCodes.Status500InternalServerError);

            app.MapGet("/DocumentTypes",
              async (IGetAllDocumentTypeController controller) =>
              {
                  IReadOnlyList<GetAllDocumentTypeResponse> documentTypes = await controller.Handle();

                  return Results.Ok(documentTypes);

              })
            .Produces(StatusCodes.Status200OK)
            .Produces<CodeErrorException>(StatusCodes.Status500InternalServerError);

            return app;
        }
    }
}
