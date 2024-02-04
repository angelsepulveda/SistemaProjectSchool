namespace SistemaProjectSchool.Domain.People.DocumentTypes
{
    public interface IDocumentTypeQueryRepository
    {
        ValueTask<List<DocumentType>> GetAll();
        ValueTask<DocumentType?> GetById(DocumentTypeId id);
        ValueTask<DocumentType?> GetByName(string name);
        ValueTask<List<DocumentType>> Actives();
    }
}
