using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.Customer.Data;

namespace Web.Customer.Models
{
    public class BookedTableEditViewModelsController : Controller
    {
        private readonly WebDbContext _context;

        public BookedTableEditViewModelsController(WebDbContext context)
        {
            _context = context;
        }

        // GET: BookedTableEditViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.BookedTableEditViewModel.ToListAsync());
        }

        // GET: BookedTableEditViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookedTableEditViewModel = await _context.BookedTableEditViewModel
                .FirstOrDefaultAsync(m => m.idTable == id);
            if (bookedTableEditViewModel == null)
            {
                return NotFound();
            }

            return View(bookedTableEditViewModel);
        }

        // GET: BookedTableEditViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookedTableEditViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idTable,CustomerName,CustomerPhone,CustomerAddress,BookDate,BookTimeStart,BookTimeEnd")] BookedTableEditViewModel bookedTableEditViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookedTableEditViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookedTableEditViewModel);
        }

        // GET: BookedTableEditViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookedTableEditViewModel = await _context.BookedTableEditViewModel.FindAsync(id);
            if (bookedTableEditViewModel == null)
            {
                return NotFound();
            }
            return View(bookedTableEditViewModel);
        }

        // POST: BookedTableEditViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idTable,CustomerName,CustomerPhone,CustomerAddress,BookDate,BookTimeStart,BookTimeEnd")] BookedTableEditViewModel bookedTableEditViewModel)
        {
            if (id != bookedTableEditViewModel.idTable)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookedTableEditViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookedTableEditViewModelExists(bookedTableEditViewModel.idTable))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bookedTableEditViewModel);
        }

        // GET: BookedTableEditViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookedTableEditViewModel = await _context.BookedTableEditViewModel
                .FirstOrDefaultAsync(m => m.idTable == id);
            if (bookedTableEditViewModel == null)
            {
                return NotFound();
            }

            return View(bookedTableEditViewModel);
        }

        // POST: BookedTableEditViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookedTableEditViewModel = await _context.BookedTableEditViewModel.FindAsync(id);
            _context.BookedTableEditViewModel.Remove(bookedTableEditViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookedTableEditViewModelExists(int id)
        {
            return _context.BookedTableEditViewModel.Any(e => e.idTable == id);
        }
    }
}
