using Domain.Entities;

namespace DomainServices
{
    public interface IDiscountCalculator
    {
        decimal ComputePriceWithDiscount(Order order);
    }
}