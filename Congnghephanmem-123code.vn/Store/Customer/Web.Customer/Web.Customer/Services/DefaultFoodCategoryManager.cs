using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using Web.Customer.Stores;

namespace Web.Customer.Services
{
    public class DefaultFoodCategoryManager : IFoodCategoryManager
    {
        IFoodCategoryStore _store;
        public DefaultFoodCategoryManager(IFoodCategoryStore store)
        {
            _store = store;
        }
        public async Task<(bool ok, FoodCategory entity)> AddAsync(FoodCategory foodCategory)
        {
            try
            {
                var entity = await _store.AddAsync(foodCategory);
                return (true, entity);

            }
            catch (Exception e)
            {
                return (false, null);

            }
        }

        public async Task<IEnumerable<FoodCategory>> GetTablesAsync()
        {

            var query = _store.Query();
            //query = query.Where(o => o.name.Contains("ban 1",StringComparison.OrdinalIgnoreCase));

            var rs = query.ToArray();
            return rs;
        }
    }
}
