using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Services
{
    public interface IFoodCategoryManager
    {
        Task<IEnumerable<FoodCategory>> GetTablesAsync();
        Task<(bool ok, FoodCategory entity)> AddAsync(FoodCategory foodCategory);
    }
}
