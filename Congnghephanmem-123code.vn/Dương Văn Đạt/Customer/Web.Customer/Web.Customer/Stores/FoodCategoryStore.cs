using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class FoodCategoryStore : IFoodCategoryStore
    {
        static List<FoodCategory> data = new List<FoodCategory>();
        public Task<FoodCategory> AddAsync(FoodCategory foodCategory)
        {
            data.Add(foodCategory);
            return Task.FromResult(foodCategory);
        }

        public IQueryable<FoodCategory> Query()
        {
            return data.AsQueryable();
        }
    }
}
