using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities
{
    public class Order
    {
        private List<Discount> discounts;
        private List<Pizza> pizzas;
        public IEnumerable<Discount> Discounts => this.discounts;
        public IEnumerable<Pizza> Pizzas => this.pizzas;
        public string OrderNumber { get; private set; }

        public bool Placed { get => OrderNumber == string.Empty; }

        public Order(string orderNumber)
        {
            this.OrderNumber = orderNumber;
        }

        public bool AddDiscount(Discount discount)
        {
            this.discounts.Add(discount);
            return true;
        }

        public Pizza AddPizza(Pizza pizza)
        {
            this.pizzas.Add(pizza);
            pizza.SetId(1);
            return pizza;
        }

        public void RemovePizza(Pizza pizza)
        {
            this.pizzas.Remove(pizza);
        }
    }
}