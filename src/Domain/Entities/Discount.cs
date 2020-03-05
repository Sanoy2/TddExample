namespace Domain.Entities
{
    public class Discount
    {
        public string Code { get; }
        public decimal Amount { get; }
        public bool Used { get; private set; }

        public Discount(string code, decimal amount)
        {
            this.Code = code;
            this.Amount = amount;

            this.Used = false;
        }

        public decimal ComputePriceAfterDiscount(decimal originalPrice)
        {
            return originalPrice;
        }

        public void UseDiscount()
        {
            this.Used = true;
        }
    }
}