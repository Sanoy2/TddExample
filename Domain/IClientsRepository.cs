using System.Collections.Generic;

namespace Domain
{
    public interface IClientsRepository
    {
        IEnumerable<Client> Get();
    }
}