namespace Domain.Entities
{
    public class Pizza
    {
        public int Id { get; private set; }
        public string Name { get; }
        public decimal Price { get; }

        public Pizza(decimal price, string name)
        {
            this.Price = price;
        }

        public void SetId(int id)
        {
            this.Id = id;
        }
    }
}