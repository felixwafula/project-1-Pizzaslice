using System.ComponentModel.DataAnnotations;

namespace Pizzaslice.Domain.Models
{
    public class Pizza
    {
        //properties.
        public int PizzaId { get; set; }
        [Required]
        public string MyCrust { get; set; }
        [Required]
        public string MySize { get; set; }
        public string MySauce { get; set; }
        public string MyCheese { get; set; }
        public string MyMeat { get; set; }
        public string MyVeggie { get; set; }

    }
}