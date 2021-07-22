using Domain;
using Infrastructure.Model;
using Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    public class CostummerRepository : ICostummerRepository
    {
        private readonly StoreDbContext _storeDbContext;

        public CostummerRepository(StoreDbContext storeDbContext) => _storeDbContext = storeDbContext;

        #region Get
        public IEnumerable<Costummer> Get() => _storeDbContext.Costummers.AsNoTracking();

        public Costummer Get(int id) => _storeDbContext.Costummers.AsNoTracking().FirstOrDefault(c => c.Id == id);
        #endregion

        #region Post
        public void Post(Costummer costummer) => _storeDbContext.Costummers.Add(costummer);
        #endregion

        #region Put
        public void Put(Costummer costummer) => _storeDbContext.Costummers.Update(costummer);
        #endregion

        #region Delete
        public void Delete(Costummer costummer) => _storeDbContext.Costummers.Remove(costummer);
        #endregion
    }
}
