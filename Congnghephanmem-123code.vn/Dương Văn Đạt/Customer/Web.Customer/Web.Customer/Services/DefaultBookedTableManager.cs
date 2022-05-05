using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using Web.Customer.Stores;

namespace Web.Customer.Services
{
    public class DefaultBookedTableManager : IBookedTableManager
    {
        IBookedTableStore _store;
        public DefaultBookedTableManager(IBookedTableStore store)
        {
            _store = store;
        }
        public async Task<(bool ok, BookedTable entity)> AddAsync(BookedTable bookedTable)
        {
            try
            {
                var entity = await _store.AddAsync(bookedTable);
                return (true, entity);

            }
            catch (Exception e)
            {
                return (false, null);

            }
        }

        public async Task<IEnumerable<BookedTable>> GetTablesAsync( )
        {

            var query = _store.Query();
            //query = query.Where(o => o.name.Contains("ban 1",StringComparison.OrdinalIgnoreCase));
            //query = query.Where(o => o.idTable.Equals(id));

            var rs = query.ToArray();
            return rs;
        }
    }
}
