using Domain.Enums;

namespace Domain
{
    public class Discount
    {
        public DiscountType Type { get; }
        public decimal Amount { get; }
    }
}