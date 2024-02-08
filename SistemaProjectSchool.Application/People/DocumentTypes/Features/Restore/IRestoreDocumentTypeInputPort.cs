namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Restore
{
    public interface IRestoreDocumentTypeInputPort
    {
        ValueTask Handle(Guid payload);
    }
}
