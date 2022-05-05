using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class FoodStore : IFoodStore
    {
        static List<Food> data = new List<Food>();
        public Task<Food> AddAsync(Food food)
        {
            data.Add(food);
            return Task.FromResult(food);
        }

        public IQueryable<Food> Query()
        {
            return data.AsQueryable();
        }
    }
}
