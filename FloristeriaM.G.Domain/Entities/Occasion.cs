using System.Collections.Generic;

namespace FloristeriaMG.Domain.Entities
{
    public class Ocasion : Core.BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}