namespace SistemaProjectSchool.Domain.People.DocumentTypes
{
    public interface IDocumentTypeCommandRepository
    {
        void Save(DocumentType documentType);
        void Update(DocumentType documentType);
    }
}
