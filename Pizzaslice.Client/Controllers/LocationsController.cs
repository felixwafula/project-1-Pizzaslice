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
    public class LocationsController : Controller
    {
        public IActionResult CreateLocation()
        {   
            var store = new Location()
            {
                LocationId = 1,
                LocationName = "East side",
                LocationAddress = "123 East St. Dallas TX",
                LocationZipCode = 75249
            };
            return View(store);
        }

        public IActionResult SelectLocation()
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
