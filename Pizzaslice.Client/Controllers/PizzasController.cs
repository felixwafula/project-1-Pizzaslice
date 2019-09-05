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
        public IActionResult CreatePizza()
        {
            return View();
        }
        //POST /Pizzas/CreatePizza
        [HttpPost]
        public IActionResult CreatePizza(Pizza pizza)
        {   
            if(ModelState.IsValid)
            {
                _db.Pizzas.Add(pizza);
                _db.SaveChanges();
            }
            return RedirectToAction("ViewPizza");
        }

        //Viewing a pizza.        
        //GET /Pizzas/ViewPizza
        public IActionResult ViewPizza()
        {   
            var pizza = _db.Pizzas.ToList();
            return View(pizza);
        }

        public ViewResult Read()
        {
            return View(_db.Pizzas.ToList());
        }
        //PUT: /Pizzas/ChangePizza
        // public IActionResult ChangePizza(int id)
        // {
        //     var res = _db.Pizzas.Single(p => p.PizzaId == id);

        //     res = crust.CrustName;
        //     res.CrustPrice = crust.CrustPrice;
        //     _db.Attach(crust);
        //     _db.SaveChanges();

        // }

        //Delete /Pizzas/DeletePizza
        public IActionResult DeletePizza(int? id) 
        {
                    
            Pizza pizza = _db.Pizzas.Find(id);
            
            return View(pizza);  

        }

        [HttpPost, ActionName("Delete")]  
        public ActionResult DeletePizza(int id)  
        {  
            Pizza pizza = _db.Pizzas.Find(id);  
            _db.Pizzas.Remove(pizza);  
            _db.SaveChanges();  
            return RedirectToAction("ViewPizza");  
        }  


        // [HttpPut]
        // public IActionResult Update(Pizza pizza)
        // {
        //     var res = _db.Pizzas.Single(p => p.PizzaId == pizza.PizzaId);

        //     res.Name = crust.CrustName;
        //     res.CrustPrice = crust.CrustPrice;
        //     _db.Attach(crust);
        //     _db.SaveChanges();

        //     //this does the same thing as above. but it does it in one move.
        //     var res1 = _db.Entry<Crust>(res);
        //     res1.State = EntityState.Modified;
        //     _db.SaveChanges();

        //     return RedirectToAction("read");
        // }

        // public IActionResult Delete(Pizza pizza)
        // {
        //     _db.Pizzas.Remove(_db.Pizzas.Single(p => p.PizzaId == pizza.PizzaId));
        //     return RedirectToAction("read");

        // }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
