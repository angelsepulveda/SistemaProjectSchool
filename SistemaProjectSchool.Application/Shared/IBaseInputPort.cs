namespace SistemaProjectSchool.Application.Shared
{
    public interface IBaseInputPort<TPayload>
    {
        ValueTask Handle(TPayload payload);
    }
}
