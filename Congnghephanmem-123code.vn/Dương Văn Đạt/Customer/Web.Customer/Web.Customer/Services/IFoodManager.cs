using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Services
{
    public interface IFoodManager
    {
        Task<IEnumerable<Food>> GetTablesAsync();
        Task<(bool ok, Food entity)> AddAsync(Food food);
    }
}
