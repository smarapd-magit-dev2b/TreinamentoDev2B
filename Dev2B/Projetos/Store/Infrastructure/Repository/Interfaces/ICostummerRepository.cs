using Domain;
using System.Collections.Generic;

namespace Infrastructure.Repository.Interfaces
{
    public interface ICostummerRepository
    {
        IEnumerable<Costummer> Get();
        Costummer Get(int id);
        void Post(Costummer costummer);
        void Put(Costummer costummer);
        void Delete(Costummer costummer);
    }
}
