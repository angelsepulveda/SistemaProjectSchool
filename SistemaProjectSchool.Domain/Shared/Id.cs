namespace SistemaProjectSchool.Domain.Shared
{
    public class Id
    {
        public Guid Value { get; private set; }

        protected Id(Guid value)
        {
            Value = value;
        }

        public static Guid Generate()
        {
            return Guid.NewGuid();
        }

    }
}
