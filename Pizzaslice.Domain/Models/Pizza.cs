namespace Pizzaslice.Domain.Models
{
    public class Pizza
    {
        //properties.
        public int PizzaId { get; set; }
        public Crust MyCrust { get; set; }
        public Size MySize { get; set; }
        public Sauce MySauce { get; set; }
        public Cheese MyCheese { get; set; }
        public Meat MyMeat { get; set; }
        public Veggie MyVeggie { get; set; }

    }
}