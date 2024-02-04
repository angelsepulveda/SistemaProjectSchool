namespace SistemaProjectSchool.Application.Shared
{
    public interface IBaseController<TPayload,TResponse>
    {
        ValueTask<TResponse> Handle(TPayload payload);
    }
}
