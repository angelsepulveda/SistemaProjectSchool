namespace SistemaProjectSchool.Application.Shared
{
    public interface IBasePresenter<TResponse>
    {
        TResponse Response { get; }
    }
}
