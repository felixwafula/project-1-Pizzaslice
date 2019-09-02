using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pizzaslice.Domain.Models
{
    public class Order : IEnumerable<Pizza>
    {
        //properties        
        public int OrderId { get; set; }
        public List<Pizza> MyOrderList { get; set; }
        public double totalPrice { get; set; }

        public IEnumerator<Pizza> GetEnumerator()
        {
            return MyOrderList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return MyOrderList.GetEnumerator();
        }
    }
}