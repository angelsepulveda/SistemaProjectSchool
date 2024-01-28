namespace SistemaProjectSchool.Domain.Shared
{
    public interface IUnitOfWork
    {
        Task<int> Complete();
    }
}
