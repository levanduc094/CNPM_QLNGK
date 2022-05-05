using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using Web.Customer.Stores;

namespace Web.Customer.Services
{
    public class DefaultTableManager : ITableManager
    {
        ITableStore _store;
        public DefaultTableManager(ITableStore store)
        {
            _store = store;
        }
        public async Task<(bool ok, Table entity)> AddAsync(Table table)
        {
            try
            {
                var entity = await _store.AddAsync(table);
                return (true, entity);

            }
            catch ( Exception e)
            {
                return (false, null);

            }
        }

        public async Task<IEnumerable<Table>> GetTablesAsync()
        {

            var query = _store.Query();
            //query = query.Where(o => o.name.Contains("ban 1",StringComparison.OrdinalIgnoreCase));

            var rs = query.ToArray();
            return rs;
        }
    }
}
