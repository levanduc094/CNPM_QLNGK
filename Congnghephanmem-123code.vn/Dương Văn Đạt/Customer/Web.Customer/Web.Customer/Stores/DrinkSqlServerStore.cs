using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class DrinkSqlServerStore : IDrinkStore
    {
        private WebDbContext _dbContext;
        public DrinkSqlServerStore(WebDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<Drink> AddAsync(Drink drink)
        {
            var entry = _dbContext.Add(drink);
            await _dbContext.SaveChangesAsync();
            var entity = entry.Entity;
            return entity;
        }


        public IQueryable<Drink> Query()
        {
            return _dbContext.Set<Drink>();
        }


    }
}
