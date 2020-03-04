using System;

namespace Domain
{
    public class Dish
    {
        public Guid DishId { get; }
        public Restaurant Restaurant { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Dish(string name, decimal price, Restaurant restaurant)
        {
            this.Name = name;
            this.Price = price;
            this.Restaurant = restaurant;
        }
    }
}