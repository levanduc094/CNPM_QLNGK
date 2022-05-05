using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Services;

namespace Web.Customer.Controllers
{
    public class FoodController : Controller
    {
        IFoodManager _manager;
        IFoodCategoryManager _cmanager;
        IDrinkManager _dmanager;
        IDrinkCategoryManager _dcmanager;
        public FoodController(IFoodManager manager, IFoodCategoryManager cmanager, IDrinkManager dmanager, IDrinkCategoryManager dcmanager)
        {
            _manager = manager;
            _cmanager = cmanager;
            _dmanager = dmanager;
            _dcmanager = dcmanager;



        }

        public async Task<IActionResult> Index()
        {

            var rsf = await _manager.GetTablesAsync();
            var rsc = await _cmanager.GetTablesAsync();
            var rsd = await _dmanager.GetTablesAsync();
            var rsdc = await _dcmanager.GetTablesAsync();
            ViewBag.food = rsf;
            ViewBag.cfood = rsc;
            ViewBag.drink = rsd;
            ViewBag.cdrink = rsdc;

            return View();


        }
    }
}
