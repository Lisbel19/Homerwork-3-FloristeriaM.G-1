using System;
using System.Collections.Generic;

namespace FloristeriaMG.Domain.Entities
{
    public class Order : Core.BaseEntity
    {
        //(FK) 
        public int ClientId { get; set; }
        public Client? Client { get; set; } 
        
        public DateTime OrderDate { get; set; } = DateTime.Now; 
        public decimal TotalAmount { get; set; }
        
        public string Status { get; set; } = "Pendiente"; 
        
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}