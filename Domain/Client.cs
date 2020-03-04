using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Client
    {
        public Guid ClientId { get; }
        public string Name { get; }
        private List<Order> orders;
        public IEnumerable<Order> Orders => this.orders.ToList();
    }
}