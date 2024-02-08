namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Update
{
    public interface IUpdateDocumentTypeInputPort
    {
        ValueTask Handle(UpdateDocumentTypePayload payload);
    }
}
