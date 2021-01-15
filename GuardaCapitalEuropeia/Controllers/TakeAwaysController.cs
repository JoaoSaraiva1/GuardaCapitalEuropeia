using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GuardaCapitalEuropeia.Data;
using GuardaCapitalEuropeia.Models;

namespace GuardaCapitalEuropeia.Controllers
{
    public class TakeAwaysController : Controller
    {
        private readonly RestaurantesContext _context;

        public TakeAwaysController(RestaurantesContext context)
        {
            _context = context;
        }

        // GET: TakeAways
        public async Task<IActionResult> Index()
        {
            return View(await _context.TakeAway.ToListAsync());
        }

        // GET: TakeAways/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeAway = await _context.TakeAway
                .FirstOrDefaultAsync(m => m.TakeAwayID == id);
            if (takeAway == null)
            {
                return NotFound();
            }

            return View(takeAway);
        }

        // GET: TakeAways/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TakeAways/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TakeAwayID,Request,Description")] TakeAway takeAway)
        {
            if (ModelState.IsValid)
            {
                _context.Add(takeAway);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(takeAway);
        }

        // GET: TakeAways/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeAway = await _context.TakeAway.FindAsync(id);
            if (takeAway == null)
            {
                return NotFound();
            }
            return View(takeAway);
        }

        // POST: TakeAways/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TakeAwayID,Request,Description")] TakeAway takeAway)
        {
            if (id != takeAway.TakeAwayID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(takeAway);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TakeAwayExists(takeAway.TakeAwayID))
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
            return View(takeAway);
        }

        // GET: TakeAways/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var takeAway = await _context.TakeAway
                .FirstOrDefaultAsync(m => m.TakeAwayID == id);
            if (takeAway == null)
            {
                return NotFound();
            }

            return View(takeAway);
        }

        // POST: TakeAways/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var takeAway = await _context.TakeAway.FindAsync(id);
            _context.TakeAway.Remove(takeAway);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TakeAwayExists(int id)
        {
            return _context.TakeAway.Any(e => e.TakeAwayID == id);
        }
    }
}
