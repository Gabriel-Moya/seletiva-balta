namespace ProcessoSeletivo.Models.Base
{
    public abstract class Base
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
