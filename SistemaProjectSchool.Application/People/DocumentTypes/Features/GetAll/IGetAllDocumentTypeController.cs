namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll
{
    public interface IGetAllDocumentTypeController
    {
        ValueTask<IReadOnlyList<GetAllDocumentTypeResponse>> Handle();
    }
}
