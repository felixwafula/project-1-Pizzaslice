using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizzaslice.Client.Models;
using Pizzaslice.Domain.Models;
using Pizzaslice.Data;

namespace Pizzaslice.Client.Controllers
{
    public class PizzasController : Controller
    {
        PizzasliceDbContext _db = new PizzasliceDbContext();

        //Creating a Pizza.
        [HttpGet]
        public IActionResult Read()
        {
            return View();
        }
        //POST /Pizzas/CreatePizza
//         public IActionResult CreatePizza()
// //should come from user input on ui. and post to DB in order.
//         {   Crust crust = new Crust { CrustName = "Deep Pan", CrustPrice = 1.20 };
//             Cheese cheese = new Cheese { CheeseName = "Mozarellla", CheesePrice = 1.00 };
//             Sauce sauce = new Sauce { SauceName = "Marinara", SaucePrice = 0.50 };
//             Meat meat = new Meat { MeatName = "sausage", MeatPrice = 2.00 };
//             Size size = new Size { SizeName = "Large", SizePrice = 1.00 };
//             Veggie veggie = new Veggie { VeggieName = "Tomato", VeggiePrice = 0.30 };

//              var pizza = new Pizza() 
//                 {
//                     MyCrust = crust, 
//                     MySize = size, 
//                     MySauce = sauce, 
//                     MyCheese = cheese, 
//                     MyMeat = meat, 
//                     MyVeggie = veggie 
//                 };

//                 _db.Pizzas.Add(pizza);
//                 _db.SaveChanges();

//                 return View(pizza);

            // List<Pizza> orderList = new List<Pizza>()
            // {
            //     new Pizza() 
            //     {
            //         MyCrust = crust, 
            //         MySize = size, 
            //         MySauce = sauce, 
            //         MyCheese = cheese, 
            //         MyMeat = meat, 
            //         MyVeggie = veggie 
            //     },
            //     new Pizza()
            //     {
            //         MyCrust = crust, 
            //         MySize = size, 
            //         MySauce = sauce, 
            //         MyCheese = cheese, 
            //         MyMeat = meat, 
            //         MyVeggie = veggie 
            //     },
            //     new Pizza()
            //     {
            //         MyCrust = crust, 
            //         MySize = size, 
            //         MySauce = sauce, 
            //         MyCheese = cheese, 
            //         MyMeat = meat, 
            //         MyVeggie = veggie 
            //     },
            // };
            // return View(orderList);
        //}
        //GET /Pizzas/ViewPizza
        public IActionResult ViewPizza()
        {   
            var pizza = _db.Pizzas.ToList();
            return View(pizza);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
