using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class DrinkStore : IDrinkStore
    {
        static List<Drink> data = new List<Drink>();
        public Task<Drink> AddAsync(Drink drink)
        {
            data.Add(drink);
            return Task.FromResult(drink);
        }

        public IQueryable<Drink> Query()
        {
            return data.AsQueryable();
        }
    }
}
