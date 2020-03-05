using System.Collections.Generic;

using Domain.Entities;

namespace DomainServices
{
    public interface IDiscountService
    {
        Discount CreateDiscount(decimal price);

        IEnumerable<Discount> GetAvailableDiscounts();
    }
}