using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Customer.Data;
using Web.Customer.Models;
using Web.Customer.Services;

namespace Web.Customer.Controllers
{
    public class BookedTableController: Controller
    {
        ITableManager _tablemanager;
        IBookedTableManager _manager;
        public BookedTableController(IBookedTableManager manager,ITableManager tableManager)
        {
            _manager = manager;
            _tablemanager = tableManager;
        }
        // GET: BookedTables
        public async Task<IActionResult> Index()
        {
            return View(await _manager.GetTablesAsync());
        }

        [HttpGet]
        public virtual async Task<IActionResult> Create()
        {
            var rs = await _tablemanager.GetTablesAsync();
            ViewBag.table = rs;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idTable,CustomerName,CustomerPhone,CustomerAddress,BookDate,BookTimeStart,BookTimeEnd")] BookedTableEditViewModel bookedTableEditViewModel)
        {

                var entyti=await _manager.AddAsync(bookedTableEditViewModel.ToModel());
                //return RedirectToAction(nameof(Index));
                return Json(entyti);

        }



    }
}
