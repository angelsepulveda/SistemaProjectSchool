namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Database
{
    internal sealed class DocumentTypeCommandEFCoreRepository : IDocumentTypeCommandRepository
    {
        private readonly ApplicationDbContext _context;
        public DocumentTypeCommandEFCoreRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public void Save(DocumentType documentType) => _context.DocumentTypes.Add(documentType);

        public void Update(DocumentType documentType) => _context.DocumentTypes.Update(documentType);
    }
}
