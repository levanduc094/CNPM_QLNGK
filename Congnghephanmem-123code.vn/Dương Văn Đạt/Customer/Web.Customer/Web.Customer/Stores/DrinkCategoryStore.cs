using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class DrinkCategoryStore : IDrinkCategoryStore
    {
        static List<DrinkCategory> data = new List<DrinkCategory>();
        public Task<DrinkCategory> AddAsync(DrinkCategory drinkCategory)
        {
            data.Add(drinkCategory);
            return Task.FromResult(drinkCategory);
        }

        public IQueryable<DrinkCategory> Query()
        {
            return data.AsQueryable();
        }
    }
}
