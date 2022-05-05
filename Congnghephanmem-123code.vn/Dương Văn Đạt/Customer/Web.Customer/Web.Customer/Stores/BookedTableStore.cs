using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class BookedTableStore : IBookedTableStore
    {
        static List<BookedTable> data = new List<BookedTable>();
        public Task<BookedTable> AddAsync(BookedTable bookedTable)
        {
            data.Add(bookedTable);
            return Task.FromResult(bookedTable);
        }

        public IQueryable<BookedTable> Query()
        {
            return data.AsQueryable();
        }
    }
}
