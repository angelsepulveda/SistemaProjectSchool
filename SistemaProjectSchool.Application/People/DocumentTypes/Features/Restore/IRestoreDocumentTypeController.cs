namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Restore
{
    public interface IRestoreDocumentTypeController
    {
        ValueTask Handle(Guid documentTypeId);
    }
}
