using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Database
{
    public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.ToTable("document_types");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasConversion(x => x.Value, x => new DocumentTypeId(x));

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("description")
                .HasMaxLength(256)
                .IsRequired(false);

            builder.Property(x => x.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired(false);

            builder.Property(x => x.UpdatedAt)
                .HasColumnName("updated_at")
                .IsRequired(false);

            builder.Property(x => x.CreatedBy)
                .HasColumnName("crfeated_by")
                .IsRequired(false);

            builder.Property(x => x.DeletedAt)
                .HasColumnName("deleted_at")
                .IsRequired(false);

            builder.Property(x => x.DeletedBy)
                .HasColumnName("deleted_by")
                .IsRequired(false);
        }
    }
}
