using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public interface IDrinkCategoryStore
    {
        IQueryable<DrinkCategory> Query();
        Task<DrinkCategory> AddAsync(DrinkCategory drinkCategory);
    }
}
