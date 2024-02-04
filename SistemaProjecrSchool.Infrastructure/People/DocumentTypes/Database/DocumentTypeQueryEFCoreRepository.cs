namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Database
{
    internal sealed class DocumentTypeQueryEFCoreRepository : IDocumentTypeQueryRepository
    {
        private readonly ApplicationDbContext _context;
        public DocumentTypeQueryEFCoreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask<List<DocumentType>> GetAll() 
                        => await _context.DocumentTypes.ToListAsync();

        public async ValueTask<DocumentType?> GetById(DocumentTypeId id) 
                     => await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Id == id);

        public async ValueTask<DocumentType?> GetByName(string name) 
                  => await _context.DocumentTypes.FirstOrDefaultAsync(x => x.Name == name);

        public async ValueTask<List<DocumentType>> Actives() => 
             await _context.DocumentTypes.Where(x => x.IsDelete == false).ToListAsync();
    }
}
