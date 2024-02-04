using SistemaProjectSchool.Application.People.DocumentTypes.Features.Update;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Presenters
{
    internal sealed class UpdateDocumentTypePresenter : IUpdateDocumentTypePresenter
    {
        public Guid Response { get; private set; }

        public ValueTask Handle(DocumentType output)
        {
            Response = output.Id.Value;

            return ValueTask.CompletedTask;
        }
    }
}
