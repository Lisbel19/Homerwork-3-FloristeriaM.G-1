namespace FloristeriaMG.Domain.Core
{
    public abstract class Person : BaseEntity
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
