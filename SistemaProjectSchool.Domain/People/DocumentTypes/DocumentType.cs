namespace SistemaProjectSchool.Domain.People.DocumentTypes
{
    public sealed class DocumentType : BaseEntity
    {
        public DocumentTypeId Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public bool IsDelete { get; private set; }

        private DocumentType(DocumentTypeId id, string name, string? description)
        {
            Id = id;
            Name = name;
            Description = description;
            IsDelete = false;
        }

        public static DocumentType Create(string name, string? description)
        {
            return new
                DocumentType(
                        new DocumentTypeId(Shared.Id.Generate()), 
                        name,
                        description);
        }

        public void Update(string name, string? description)
        {
            if(Name != name) Name = name;

            if(Description != description) Description = description;
        }

        public void Delete()
        {
            if (IsDelete) throw new DocumentAlreadyDeletedException();

            IsDelete = true;
        }

        public void Restore()
        {
            if(!IsDelete) throw new DocumentAlreadyRestoredException();

            IsDelete = false;
        }
    }
}
