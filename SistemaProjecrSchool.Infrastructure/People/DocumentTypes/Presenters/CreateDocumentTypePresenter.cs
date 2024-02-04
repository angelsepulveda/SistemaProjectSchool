using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Presenters
{
    internal sealed class CreateDocumentTypePresenter : ICreateDocumentTypePresenter
    {
        public Guid Response { get; private set; }

        public ValueTask Handle(DocumentType documentType)
        {
            Response = documentType.Id.Value;

            return ValueTask.CompletedTask;
        }
    }
}
