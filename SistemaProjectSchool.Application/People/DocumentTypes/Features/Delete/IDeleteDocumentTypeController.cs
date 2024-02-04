namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Delete
{
    public interface IDeleteDocumentTypeController
    {
        ValueTask Handle(Guid documentTypeId);
    }
}
