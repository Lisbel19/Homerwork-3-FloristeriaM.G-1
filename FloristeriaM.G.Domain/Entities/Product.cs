using System;
using System.Collections.Generic;

namespace FloristeriaMG.Domain.Entities
{
    public class Product : Core.BaseEntity 
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime ExpirationDate { get; set; } 
        
        //(FK)
        public int OcasionId { get; set; }
        
        public Ocasion? Ocasion { get; set; } 
    }
}