using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Services
{
    public interface IDrinkManager
    {
        Task<IEnumerable<Drink>> GetTablesAsync();
        Task<(bool ok, Drink entity)> AddAsync(Drink drink);
    }
}
