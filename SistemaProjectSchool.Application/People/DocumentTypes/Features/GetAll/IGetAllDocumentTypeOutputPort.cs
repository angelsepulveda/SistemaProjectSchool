using SistemaProjectSchool.Domain.People.DocumentTypes;

namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll
{
    public interface IGetAllDocumentTypeOutputPort 
        : IBaseOutputPort<List<DocumentType>>
    {

    }
}
