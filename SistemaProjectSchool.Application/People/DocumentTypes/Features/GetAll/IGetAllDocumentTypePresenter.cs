namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll
{
    public interface IGetAllDocumentTypePresenter 
        : IBasePresenter<IReadOnlyList<GetAllDocumentTypeResponse>>,
        IGetAllDocumentTypeOutputPort
    {
    }
}
