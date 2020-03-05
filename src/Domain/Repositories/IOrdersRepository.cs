using System.Collections.Generic;

using Domain.Entities;

namespace Domain.Repositories
{
    public interface IOrdersRepository
    {
        IEnumerable<Order> Get();

        Order Save(Order order);
    }
}