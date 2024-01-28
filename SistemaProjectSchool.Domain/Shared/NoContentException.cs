namespace SistemaProjectSchool.Domain.Shared
{
    public class NoContentException : DomainException
    {
        public NoContentException(string message) : base(message) { }
    }
}
