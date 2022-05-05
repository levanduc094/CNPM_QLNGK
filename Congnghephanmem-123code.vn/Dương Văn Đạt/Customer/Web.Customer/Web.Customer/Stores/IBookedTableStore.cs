using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public interface IBookedTableStore
    {

        IQueryable<BookedTable> Query();
        Task<BookedTable> AddAsync(BookedTable bookedTable);
    }
}
