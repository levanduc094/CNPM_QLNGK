using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using Web.Customer.Stores;

namespace Web.Customer.Services
{
    public class DefaultDrinkManager : IDrinkManager
    {
        IDrinkStore _store;
        public DefaultDrinkManager(IDrinkStore store)
        {
            _store = store;
        }
        public async Task<(bool ok, Drink entity)> AddAsync(Drink drink)
        {
            try
            {
                var entity = await _store.AddAsync(drink);
                return (true, entity);

            }
            catch (Exception e)
            {
                return (false, null);

            }
        }

        public async Task<IEnumerable<Drink>> GetTablesAsync()
        {

            var query = _store.Query();
            //query = query.Where(o => o.name.Contains("ban 1",StringComparison.OrdinalIgnoreCase));

            var rs = query.ToArray();
            return rs;
        }
    }
}
