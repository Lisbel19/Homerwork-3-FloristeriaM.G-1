using System.Collections.Generic;

namespace FloristeriaMG.Domain.Entities
{
    public class Client : Core.BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public ICollection<Order> Orders { get; set; } = new List<Order>(); 
    }
}