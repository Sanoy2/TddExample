using System.Collections.Generic;

using Domain.Entities;

namespace Domain.Repositories
{
    public interface IDiscountRepository
    {
        IEnumerable<Discount> Get();

        Discount Save(Discount order);
    }
}