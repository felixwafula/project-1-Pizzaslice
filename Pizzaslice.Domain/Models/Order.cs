using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pizzaslice.Domain.Models
{
    public class Order
    {
        //properties        
        public int OrderId { get; set; }
        public List<Pizza> MyOrderList { get; set; }
        public int LocationId { get; set; }
        public int UserId { get; set; }
        public double totalPrice { get; set; }       

        
    }
}