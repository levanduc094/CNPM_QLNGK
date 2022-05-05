using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class DrinkCategorySqlServerStore : IDrinkCategoryStore
    {
        private WebDbContext _dbContext;
        public DrinkCategorySqlServerStore(WebDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<DrinkCategory> AddAsync(DrinkCategory drinkCategory)
        {
            var entry = _dbContext.Add(drinkCategory);
            await _dbContext.SaveChangesAsync();
            var entity = entry.Entity;
            return entity;
        }

        public IQueryable<DrinkCategory> Query()
        {
            return _dbContext.Set<DrinkCategory>();
        }


    }
}
