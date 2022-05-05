using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;

namespace Web.Customer.Stores
{
    public interface IFoodCategoryStore
    {
        IQueryable<FoodCategory> Query();
        Task<FoodCategory> AddAsync(FoodCategory foodCategory);
    }
}
