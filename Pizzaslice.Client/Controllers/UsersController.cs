using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pizzaslice.Client.Models;
using Pizzaslice.Domain.Models;

namespace Pizzaslice.Client.Controllers
{
    public class UsersController : Controller
    {
        //GET: Users/RegisterUser
        public IActionResult RegisterUser()
        {
            var user = new User()
            {
                UserId = 1,
                FirstName = "Felix",
                LastName = "Wafula",
                UserName = "wafulafelix",
                UserPassword = "12345",
                UserEmail = "wafulafelix@yahoo.com",
                UserZipCode = 76040
            };


            return View(user);
        }
        //GET: Users/Login
        public IActionResult Login()
        {
            var user = new User()
            {
                UserName = "wafulafelix",
                UserPassword = "12345"
            };
            return View(user);
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
