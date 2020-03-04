using System.Collections.Generic;

namespace Domain
{
    public interface IRestaurantsRepository
    {
        IEnumerable<Restaurant> Get();
    }
}