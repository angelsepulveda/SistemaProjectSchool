using SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Presenters
{
    internal sealed class GetAllDocumentTypePresenter : IGetAllDocumentTypePresenter
    {
        public IReadOnlyList<GetAllDocumentTypeResponse> Response { get; private set; } = null!;

        public ValueTask Handle(List<DocumentType> output)
        {
            Response = output.Select(p => new GetAllDocumentTypeResponse(
                     Id: p.Id.Value,
                     Name: p.Name,
                     Description: p.Description,
                     IsDelete: p.IsDelete
                )).ToList().AsReadOnly();

            return ValueTask.CompletedTask;
        }
    }
}
