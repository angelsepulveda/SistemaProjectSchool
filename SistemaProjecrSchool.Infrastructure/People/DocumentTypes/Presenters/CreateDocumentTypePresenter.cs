using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Presenters
{
    internal sealed class CreateDocumentTypePresenter : ICreateDocumentTypePresenter
    {
        public Guid DocumentTypeId { get; private set; }

        public ValueTask Handle(DocumentType documentType)
        {
            DocumentTypeId = documentType.Id.Value;

            return ValueTask.CompletedTask;
        }
    }
}
