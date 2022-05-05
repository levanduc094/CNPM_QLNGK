using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class BookedTableSqlServerStore : IBookedTableStore
    {
        private WebDbContext _dbContext;
        public BookedTableSqlServerStore(WebDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<BookedTable> AddAsync(BookedTable bookedTable)
        {
            var entry = _dbContext.Add(bookedTable);
            await _dbContext.SaveChangesAsync();
            var entity = entry.Entity;
            return entity;
        }

        public IQueryable<BookedTable> Query()
        {
            return _dbContext.Set<BookedTable>();
        }


    }
}
