using SistemaProjectSchool.Application.People.DocumentTypes.Features.Actives;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Delete;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Restore;
using SistemaProjectSchool.Application.People.DocumentTypes.Features.Update;

namespace SistemaProjectSchool.WebApi.Modules.People.DocumentTypes
{
    internal static class DocumentTypesEndPoints
    {
        public static WebApplication UseDocumentTypesEndpoints(this WebApplication app)
        {
            app.MapPost("/DocumentTypes/Create",
                async (ICreateDocumentTypeController controller, [FromBody] CreateDocumentTypePayload payload) =>
            {
                Guid documentTypeId = await controller.Handle(payload);

                return Results.Ok(documentTypeId);

            }).AddEndpointFilter<ValidatorFilter<CreateDocumentTypePayload>>()
              .Produces(StatusCodes.Status200OK)
              .Produces<CodeErrorException>(StatusCodes.Status400BadRequest)
              .Produces<CodeErrorException>(StatusCodes.Status500InternalServerError);

            app.MapPut("/DocumentTypes/Update",
              async (IUpdateDocumentTypeController controller, [FromBody] UpdateDocumentTypePayload payload) =>
              {
                  Guid documentTypeId = await controller.Handle(payload);

                  return Results.Ok(documentTypeId);

              }).AddEndpointFilter<ValidatorFilter<UpdateDocumentTypePayload>>()
            .Produces(StatusCodes.Status200OK)
            .Produces<CodeErrorException>(StatusCodes.Status400BadRequest)
            .Produces<CodeErrorException>(StatusCodes.Status500InternalServerError);

            app.MapGet("/DocumentTypes/GetAll",
              async (IGetAllDocumentTypeController controller) =>
              {
                  IReadOnlyList<GetAllDocumentTypeResponse> documentTypes = await controller.Handle();

                  return Results.Ok(documentTypes);

              })
            .Produces(StatusCodes.Status200OK)
            .Produces<CodeErrorException>(StatusCodes.Status500InternalServerError);

            app.MapGet("/DocumentTypes/Select",
             async (IActivesDocumentTypeController controller) =>
             {
                 IReadOnlyList<ActivesDocumentType> documentTypes = await controller.Handle();

                 return Results.Ok(documentTypes);

             })
           .Produces(StatusCodes.Status200OK)
           .Produces<CodeErrorException>(StatusCodes.Status500InternalServerError);

            app.MapDelete("/DocumentTypes/Delete",
             async (IDeleteDocumentTypeController controller, Guid id) =>
             {
                 await controller.Handle(id);

                 return Results.NoContent();

             })
           .Produces<CodeErrorException>(StatusCodes.Status400BadRequest)
           .Produces(StatusCodes.Status200OK)
           .Produces<CodeErrorException>(StatusCodes.Status500InternalServerError);

            app.MapPut("/DocumentTypes/Restore",
             async (IRestoreDocumentTypeController controller, Guid id) =>
             {
                 await controller.Handle(id);

                 return Results.NoContent();

             })
           .Produces<CodeErrorException>(StatusCodes.Status400BadRequest)
           .Produces(StatusCodes.Status200OK)
           .Produces<CodeErrorException>(StatusCodes.Status500InternalServerError);

            return app;
        }
    }
}
