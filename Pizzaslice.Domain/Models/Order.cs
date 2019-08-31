using System.Collections.Generic;

namespace Pizzaslice.Domain.Models
{
    public class Order
    {
        //properties
        public List<Pizza> MyOrderList { get; set; }
        public double totalPrice { get; set; }
    }
}