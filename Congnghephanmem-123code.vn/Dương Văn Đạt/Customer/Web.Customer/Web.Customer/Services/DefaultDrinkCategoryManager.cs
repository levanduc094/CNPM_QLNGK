using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using Web.Customer.Stores;

namespace Web.Customer.Services
{
    public class DefaultDrinkCategoryManager : IDrinkCategoryManager
    {
        IDrinkCategoryStore _store;
        public DefaultDrinkCategoryManager(IDrinkCategoryStore store)
        {
            _store = store;
        }
        public async Task<(bool ok, DrinkCategory entity)> AddAsync(DrinkCategory drinkCategory)
        {
            try
            {
                var entity = await _store.AddAsync(drinkCategory);
                return (true, entity);

            }
            catch (Exception e)
            {
                return (false, null);

            }
        }

        public async Task<IEnumerable<DrinkCategory>> GetTablesAsync()
        {

            var query = _store.Query();
            //query = query.Where(o => o.name.Contains("ban 1",StringComparison.OrdinalIgnoreCase));

            var rs = query.ToArray();
            return rs;
        }
    }
}
