using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class FoodCategorySqlServerStore : IFoodCategoryStore
    {
        private WebDbContext _dbContext;
        public FoodCategorySqlServerStore(WebDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<FoodCategory> AddAsync(FoodCategory foodCategory)
        {
            var entry = _dbContext.Add(foodCategory);
            await _dbContext.SaveChangesAsync();
            var entity = entry.Entity;
            return entity;
        }

        public IQueryable<FoodCategory> Query()
        {
            return _dbContext.Set<FoodCategory>();
        }


    }
}
