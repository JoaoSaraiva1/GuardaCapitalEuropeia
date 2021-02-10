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
    public class Reserva_MesaController : Controller
    {
        private readonly RestaurantesContext _context;

        public Reserva_MesaController(RestaurantesContext context)
        {
            _context = context;
        }

        // GET: Reserva_Mesa
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reserva_Mesa.ToListAsync());
        }

        // GET: Reserva_Mesa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva_Mesa = await _context.Reserva_Mesa
                .FirstOrDefaultAsync(m => m.Reserva_MesaId == id);
            if (reserva_Mesa == null)
            {
                return NotFound();
            }

            return View(reserva_Mesa);
        }

        // GET: Reserva_Mesa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reserva_Mesa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Reserva_MesaId,Numero,Data_Reserva,Hora_Reserva,Pessoas")] Reserva_Mesa reserva_Mesa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reserva_Mesa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reserva_Mesa);
        }

        // GET: Reserva_Mesa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva_Mesa = await _context.Reserva_Mesa.FindAsync(id);
            if (reserva_Mesa == null)
            {
                return NotFound();
            }
            return View(reserva_Mesa);
        }

        // POST: Reserva_Mesa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Reserva_MesaId,Numero,Data_Reserva,Hora_Reserva,Pessoas")] Reserva_Mesa reserva_Mesa)
        {
            if (id != reserva_Mesa.Reserva_MesaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reserva_Mesa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Reserva_MesaExists(reserva_Mesa.Reserva_MesaId))
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
            return View(reserva_Mesa);
        }

        // GET: Reserva_Mesa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva_Mesa = await _context.Reserva_Mesa
                .FirstOrDefaultAsync(m => m.Reserva_MesaId == id);
            if (reserva_Mesa == null)
            {
                return NotFound();
            }

            return View(reserva_Mesa);
        }

        // POST: Reserva_Mesa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reserva_Mesa = await _context.Reserva_Mesa.FindAsync(id);
            _context.Reserva_Mesa.Remove(reserva_Mesa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Reserva_MesaExists(int id)
        {
            return _context.Reserva_Mesa.Any(e => e.Reserva_MesaId == id);
        }
    }
}
