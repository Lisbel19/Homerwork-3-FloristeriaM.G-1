using System;
using System.Collections.Generic;

namespace FloristeriaMG.Infrastructure.Models
{
    public class OrderModel
    {
        public int ClientId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItemModel> Items { get; set; }
    }

    public class OrderItemModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
