using System;

namespace Pizzaslice.Domain.Models
{
    public class OrderHistory
    {
        public User USerId { get; set; }
        public Location LocationId { get; set; }
        public Order OrderId { get; set; }
        public DateTime USerOrderDate { get; set; }
    }
}