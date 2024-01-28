using SistemaProjectSchool.Domain.Shared;

namespace SistemaProjectSchool.Domain.People.DocumentTypes
{
    public class DocumentAlreadyDeletedException : DomainException
    {
        public DocumentAlreadyDeletedException() : base("El tipo de documento ya se encuentra eliminado")
        {
        }
    }
}
