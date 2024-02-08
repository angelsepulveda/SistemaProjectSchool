namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Actives
{
    public interface IActivesDocumentTypePresenter : IActivesDocumentTypesOutputPort
    {
        IReadOnlyList<ActivesDocumentType> Response {  get; }
    }
}
