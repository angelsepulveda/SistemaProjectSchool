using SistemaProjectSchool.Domain.People.DocumentTypes;

namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Update
{
    public interface IUpdateDocumentTypeOutputPort
    {
        ValueTask Handle(DocumentType output);
    }
}
