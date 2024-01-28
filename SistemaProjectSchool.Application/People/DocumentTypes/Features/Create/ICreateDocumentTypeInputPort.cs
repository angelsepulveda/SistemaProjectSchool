namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Create
{
    public interface ICreateDocumentTypeInputPort
    {
        ValueTask Handle(CreateDocumentTypePayload payload);
    }
}
