namespace SistemaProjectSchool.Domain.Shared
{
    public class BadRequestException : DomainException
    {
        public BadRequestException(string message = "Ocurrio un error") : base(message)
        {
        }
    }
}
