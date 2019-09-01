using Microsoft.EntityFrameworkCore;
using Pizzaslice.Domain.Models;

namespace Pizzaslice.Data
{
    public class PizzasliceDbContext : DbContext
    {
        public PizzasliceDbContext(DbContextOptions<PizzasliceDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Sauce> Sauces { get; set; }
        public DbSet<Cheese> Cheeses { get; set; }
        public DbSet<Meat> Meats { get; set; }
        public DbSet<Veggie> Veggies { get; set; }
              

    }
}