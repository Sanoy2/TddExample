using System;
using System.Collections.Generic;

using Domain.Enums;

namespace Domain
{
    public class Order
    {
        public Guid OrderId { get; }
        public Client Client { get; }
        public Restaurant Restaurant { get; set; }
        public OrderType OrderType { get; }
        public OrderStatus OrderStatus { get; private set; }
        IEnumerable<Dish> Dishes { get; }
        public decimal Sum { get => this.ComputeSum(); }
        public bool AddDiscount(Discount discount) { return false; }
        public void AddDish(Dish dish) { return; }
        public void Cancel() { this.OrderStatus = OrderStatus.Canceled; }
        public void Accept() { this.OrderStatus = OrderStatus.Placed; }
        public bool ChangeOrderType(OrderType orderType) { return false; }

        public Order(Client client, Restaurant restaurant)
        {

        }

        private decimal ComputeSum() { return 0.0M; }
    }
}