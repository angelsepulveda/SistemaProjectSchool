using SistemaProjectSchool.Application.People.DocumentTypes.Features.Actives;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Presenters
{
    internal sealed class ActivesDocumentTypePresenter : IActivesDocumentTypePresenter
    {
        public IReadOnlyList<ActivesDocumentType> Response { get; private set; } = null!;

        public ValueTask Handle(List<DocumentType> output)
        {
            Response = output.Select(p => 
                     new ActivesDocumentType(Id: p.Id.Value,Name: p.Name))
                 .ToList().AsReadOnly();

            return ValueTask.CompletedTask;
        }
    }
}
