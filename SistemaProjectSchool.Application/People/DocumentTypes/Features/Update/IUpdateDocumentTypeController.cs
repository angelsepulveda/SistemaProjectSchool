namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Update
{
    public interface IUpdateDocumentTypeController
    {
        ValueTask<Guid> Handle(UpdateDocumentTypePayload payload);
    }
}
