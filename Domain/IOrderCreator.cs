namespace Domain
{
    public interface IOrderCreator
    {
        Order CreateOrder(Client client, Restaurant restaurant);
    }
}