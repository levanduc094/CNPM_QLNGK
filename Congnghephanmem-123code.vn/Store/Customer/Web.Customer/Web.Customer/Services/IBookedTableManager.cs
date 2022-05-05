using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Services
{
    public interface IBookedTableManager
    {
        Task<IEnumerable<BookedTable>> GetTablesAsync();
        Task<(bool ok, BookedTable entity)> AddAsync(BookedTable bookedTable);
    }
}