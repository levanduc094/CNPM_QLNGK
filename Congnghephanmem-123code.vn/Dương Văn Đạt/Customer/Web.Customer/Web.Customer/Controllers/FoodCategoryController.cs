using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Services;

namespace Web.Customer.Controllers
{
    public class FoodCategoryController : Controller
    {
        IFoodCategoryManager _manager;
        
        public FoodCategoryController(IFoodCategoryManager manager)
        {
            _manager = manager;
           

        }

        public async Task<IActionResult> Index()
        {

            
            var rsc = await _manager.GetTablesAsync();
           
            ViewBag.cfood = rsc;
            return View();


        }
    }
}