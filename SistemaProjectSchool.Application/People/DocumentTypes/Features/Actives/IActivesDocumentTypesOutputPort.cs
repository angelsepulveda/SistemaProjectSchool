using SistemaProjectSchool.Domain.People.DocumentTypes;

namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Actives
{
    public interface IActivesDocumentTypesOutputPort
    {
        ValueTask Handle(List<DocumentType> output);
    }
}
