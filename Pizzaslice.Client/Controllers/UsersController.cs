using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pizzaslice.Client.Models;
using Pizzaslice.Data;
using Pizzaslice.Domain.Models;

namespace Pizzaslice.Client.Controllers
{
    public class UsersController : Controller
    {
        PizzasliceDbContext _db = new PizzasliceDbContext();
        
        //GET: Users/CreateUser
         [HttpGet]
         public IActionResult CreateUser()
         {       
           return View();
        }

        //POST: Users/CreateUser passing parameters from form.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUser(User user)
        {                  
             if (ModelState.IsValid)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                return RedirectToAction("Read");
            }
            return RedirectToAction("CreateUser");

        }
        public ViewResult Read()
        {
            return View(_db.Users.ToList());
        }
        //GET: Users/ViewUser
        [HttpGet("{id}")]
        public IActionResult ViewUser(int id)
        {
            var user = _db.Users.Single(u => u.UserId == id);
            return View(user);
        }
        //GET: Users/Login
        [HttpGet]
        public IActionResult Login()
        {   
            var user = new User();                     
            return View(user);
        }
        [HttpPost]
        public IActionResult Login(User user)
        {                                 
            return View();
        }
        [HttpPut]
        public IActionResult ChangeUser(int id)
        {                                 
            return View();
        }

        [HttpDelete]
        public IActionResult RemoveUser()
        {                                 
            return View();
        }
        [HttpDelete]
        public IActionResult RemoveUser(int id)
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
