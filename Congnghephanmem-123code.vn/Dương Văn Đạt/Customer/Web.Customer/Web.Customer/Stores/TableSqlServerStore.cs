using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class TableSqlServerStore : ITableStore
    {
        private WebDbContext _dbContext;
        public TableSqlServerStore (WebDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<Table> AddAsync(Table table)
        {
            var entry = _dbContext.Add(table);
            await _dbContext.SaveChangesAsync();
            var entity = entry.Entity;
            return entity;
        }

        public IQueryable<Table> Query()
        {
            return _dbContext.Set<Table>();
        }
    }
}
