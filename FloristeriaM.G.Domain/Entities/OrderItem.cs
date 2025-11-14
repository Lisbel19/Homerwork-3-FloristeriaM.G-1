namespace FloristeriaMG.Domain.Entities
{
    public class OrderItem : Core.BaseEntity
    {
        //(FK)
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        
        public Order? Order { get; set; }
        public Product? Product { get; set; } 
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}