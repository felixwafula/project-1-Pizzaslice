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
    public class LocationsController : Controller
    {
        PizzasliceDbContext _db = new PizzasliceDbContext();

        //Create locations should be a POST: from admin.
        public IActionResult CreateLocation()
        {
            var store = new Location()
            {
                LocationName = "West side",
                LocationAddress = "456 West St. Arlington TX",
                LocationZipCode = 76040
            };

            _db.Locations.Add(store);
            _db.SaveChanges();

            return RedirectToAction("ViewLocations");
        }

        //GET: /Locations/ViewLocations
        public IActionResult ViewLocations()
        {
            var locationsList = _db.Locations.ToList();
            return View(locationsList);
        }

        //PUT: /Locations/UpdateLocation
        public IActionResult Update(int id)
        {
            return View(_db.Locations.Single(c => c.LocationId == id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
