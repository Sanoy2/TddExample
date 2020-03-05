namespace Domain.Entities
{
    public class Discount
    {
        public decimal Amount { get; }

        public Discount(decimal amount)
        {
            this.Amount = amount;
        }
    }
}