namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Create
{
    public interface ICreateDocumentTypeController
    {
        ValueTask<Guid> Handle(CreateDocumentTypePayload payload);
    }
}
