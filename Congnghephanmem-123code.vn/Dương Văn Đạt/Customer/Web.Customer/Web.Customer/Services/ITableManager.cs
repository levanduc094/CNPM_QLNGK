using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Services
{
    public interface ITableManager
    {
        Task<IEnumerable<Table>> GetTablesAsync();
        Task<(bool ok, Table entity)> AddAsync(Table table);
    }
}
