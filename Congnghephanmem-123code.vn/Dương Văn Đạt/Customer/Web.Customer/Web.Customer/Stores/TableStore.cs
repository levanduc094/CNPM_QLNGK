using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public class TableStore : ITableStore
    {
        static List<Table> data=new List<Table>();
        public Task<Table> AddAsync(Table table)
        {
            data.Add(table);
            return Task.FromResult(table);
        }

        public IQueryable<Table> Query()
        {
            return data.AsQueryable();
        }
    }
}
