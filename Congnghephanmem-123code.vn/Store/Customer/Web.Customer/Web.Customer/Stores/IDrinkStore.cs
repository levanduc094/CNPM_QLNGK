using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public interface IDrinkStore
    {
        IQueryable<Drink> Query();
        Task<Drink> AddAsync(Drink drink);
    }
}
