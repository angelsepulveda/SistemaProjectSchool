namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Delete
{
    public interface IDeleteDocumentTypeInputPort
    {
        ValueTask Handle(Guid payload);
    }
}
