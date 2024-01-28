using SistemaProjectSchool.Domain.People.DocumentTypes;

namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Create
{
    public interface ICreateDocumentTypeOutputPort
    {
        ValueTask Handle(DocumentType documentType);
    }
}
