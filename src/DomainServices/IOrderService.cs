using Domain.Entities;

namespace DomainServices
{
    public interface IOrderService
    {
        Order CreateOrder();

        decimal CalculatePrice(string orderNumber);

        bool AddDiscount(string discountCode);

        bool AcceptOrder(string orderNumber);
    }
}