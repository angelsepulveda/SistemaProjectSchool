namespace SistemaProjectSchool.Application.Shared
{
    public interface IBaseOutputPort<T>
    {
        ValueTask Handle(T output);
    }
}
