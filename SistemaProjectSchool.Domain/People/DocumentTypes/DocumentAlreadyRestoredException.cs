namespace SistemaProjectSchool.Domain.People.DocumentTypes
{
    public class DocumentAlreadyRestoredException : DomainException
    { 
        public DocumentAlreadyRestoredException(): base("El tipo de documento ya se encuentra restaurado") { }
    }
}
