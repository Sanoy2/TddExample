using System.Collections.Generic;
using System.Linq;

using Domain.Enums;

namespace Domain
{
    public class Restaurant
    {
        private List<Dish> servedDishes = new List<Dish>();
        private List<OrderType> availableOrders = new List<OrderType>();

        public Restaurant(string name)
        {

        }

        public string Name { get; }
        public bool DeliveryAvailable { get; }
        public IEnumerable<OrderType> AvailableOrders { get => this.availableOrders.ToList(); }
        public IEnumerable<Dish> ServedDishes { get => this.servedDishes.ToList(); }
        public decimal DeliveryCost { get; }

        public Order PlaceOrder(Client client) { return new Order(client, this); } // ?

        public Dish AddDish(string name, decimal price)
        {
            Dish dish = new Dish(name, price, this);
            this.servedDishes.Add(dish);
            return dish;
        }
    }
}