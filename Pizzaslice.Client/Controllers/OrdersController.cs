using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizzaslice.Client.Models;
using Pizzaslice.Domain.Models;

namespace Pizzaslice.Client.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult ShowOrder()
        {
            Crust crust = new Crust { CrustId = 1, CrustName = "Deep Pan", CrustPrice = 1.20 };
            Cheese cheese = new Cheese { CheeseId = 1, CheeseName = "Mozarellla", CheesePrice = 1.00 };
            Sauce sauce = new Sauce { SauceId = 2, SauceName = "Marinara", SaucePrice = 0.50 };
            Meat meat = new Meat { MeatId = 4, MeatName = "sausage", MeatPrice = 2.00 };
            Size size = new Size { SizeId = 1, SizeName = "Large", SizePrice = 1.00 };
            Veggie veggie = new Veggie { VeggieId = 6, VeggieName = "Tomato", VeggiePrice = 0.30 };

            var pizza = new Pizza
            {
                PizzaId = 1,
                MyCrust = crust,
                MySize = size,
                MySauce = sauce,
                MyCheese = cheese,
                MyMeat = meat, 
                MyVeggie = veggie
            };
            //new orderlist (a lsit of two identical pizzas) object.
            var order = new List<Pizza>();
            order.Add(pizza);

            return View(order);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
