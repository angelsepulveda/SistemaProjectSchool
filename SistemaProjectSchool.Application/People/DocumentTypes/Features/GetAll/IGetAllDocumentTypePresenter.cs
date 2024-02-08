namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll
{
    public interface IGetAllDocumentTypePresenter :IGetAllDocumentTypeOutputPort
    {
        IReadOnlyList<GetAllDocumentTypeResponse> Response {  get; }
    }
}
