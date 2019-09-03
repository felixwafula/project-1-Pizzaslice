using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pizzaslice.Client.Models;
using Pizzaslice.Data;
using Pizzaslice.Domain.Models;

namespace Pizzaslice.Client.Controllers
{
    public class OrdersController : Controller
    {
        private PizzasliceDbContext _db = new PizzasliceDbContext();

        public IActionResult CreateOrder()
        {

            return View();
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
