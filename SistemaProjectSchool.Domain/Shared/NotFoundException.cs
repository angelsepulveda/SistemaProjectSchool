namespace SistemaProjectSchool.Domain.Shared
{
    public class NotFoundException : DomainException
    {
        public NotFoundException(string message = "No se encontro el recurso a buscar") : base(message)
        {
        }
    }
}
