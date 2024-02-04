namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Actives
{
    public interface IActivesDocumentTypePresenter : 
        IBasePresenter<IReadOnlyList<ActivesDocumentType>>, IActivesDocumentTypesOutputPort
    {
    }
}
