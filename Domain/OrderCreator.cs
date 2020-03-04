namespace Domain
{
    public class OrderCreator : IOrderCreator
    {
        public Order CreateOrder(Client client, Restaurant restaurant)
        {
            Order order = restaurant.PlaceOrder(client);

            return order;
        }
    }
}