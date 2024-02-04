namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Actives
{
    public interface IActivesDocumentTypeController
    {
        ValueTask<IReadOnlyList<ActivesDocumentType>> Handle();
    }
}
