using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Services
{
    public interface IDrinkCategoryManager
    {
        Task<IEnumerable<DrinkCategory>> GetTablesAsync();
        Task<(bool ok, DrinkCategory entity)> AddAsync(DrinkCategory drinkCategory);
    }
}
