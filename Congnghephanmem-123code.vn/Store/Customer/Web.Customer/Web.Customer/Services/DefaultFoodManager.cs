using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using Web.Customer.Stores;

namespace Web.Customer.Services
{
    public class DefaultFoodManager : IFoodManager
    {
        IFoodStore _store;
        public DefaultFoodManager(IFoodStore store)
        {
            _store = store;
        }
        public async Task<(bool ok, Food entity)> AddAsync(Food food)
        {
            try
            {
                var entity = await _store.AddAsync(food);
                return (true, entity);

            }
            catch (Exception e)
            {
                return (false, null);

            }
        }

        public async Task<IEnumerable<Food>> GetTablesAsync()
        {

            var query = _store.Query();
            //query = query.Where(o => o.name.Contains("ban 1",StringComparison.OrdinalIgnoreCase));

            var rs = query.ToArray();
            return rs;
        }
    }
}
