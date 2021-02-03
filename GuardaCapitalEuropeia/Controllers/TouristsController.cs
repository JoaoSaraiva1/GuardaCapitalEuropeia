using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GuardaCapitalEuropeia.Data;
using GuardaCapitalEuropeia.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace GuardaCapitalEuropeia.Controllers
{
    public class TouristsController : Controller
    {
        private readonly RestaurantesContext _context;
        private readonly UserManager<IdentityUser> _userManager;
       

        public TouristsController(RestaurantesContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Tourists
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tourist.ToListAsync());
        }

        // GET: Tourists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tourist = await _context.Tourist
                .FirstOrDefaultAsync(m => m.TouristId == id);
            if (tourist == null)
            {
                return NotFound();
            }

            return View(tourist);
        }

        // GET: Tourists/Create
        public IActionResult Register()
        {
            return View();
        }

        // POST: Tourists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel touristInfo)
        {
            if (ModelState.IsValid)
            {
                return View(touristInfo);
            }
            string username = touristInfo.Email;
            IdentityUser user = await _userManager.FindByNameAsync(username);

            if (user != null)
            {
                ModelState.AddModelError("Email", "There is already a tourist with that email");
                return View(touristInfo);
            }
            user = new IdentityUser(username);
            await _userManager.CreateAsync(user, touristInfo.Password);
            await _userManager.AddToRoleAsync(user, "Tourist");

            Tourist tourist = new Tourist
            {
                Nome = touristInfo.Nome,
                Email = touristInfo.Email
            };
            _ = _context.Add(tourist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), "Home");
        }

        [Authorize(Roles = "Toutist")]
        public async Task<IActionResult> EditPersonalData()
        {
            string email = User.Identity.Name;
            var tourist = await _context.Tourist.SingleOrDefaultAsync(t => t.Email == email);
            if (tourist == null)
            {
                return NotFound();
            }

            EditLoggedInTouristViewModel touristInfo = new EditLoggedInTouristViewModel
            {
                Nome = tourist.Nome,
                Email = tourist.Email
            };
            return View(touristInfo);

          
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> EditPersonalData(EditLoggedInTouristViewModel tourist)
        {
            if (!ModelState.IsValid)
            {
                return View(tourist);
            }

            string email = User.Identity.Name;

            var touristLoggedin = await _context.Tourist.SingleOrDefaultAsync(c => c.Email == email);
            if (touristLoggedin == null)
            {
                return NotFound();
            }

            touristLoggedin.Nome = tourist.Nome;

            try
            {
                _context.Update(touristLoggedin);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //todo: show error message

                throw;
            }
            return RedirectToAction(nameof(Index), "Home");
        }

        // GET: Tourists/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tourist = await _context.Tourist.FindAsync(id);
            if (tourist == null)
            {
                return NotFound();
            }
            return View(tourist);
        }

        // POST: Tourists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TouristId,Nome,Email")] Tourist tourist)
        {
            if (id != tourist.TouristId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tourist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TouristExists(tourist.TouristId))
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
            return View(tourist);
        }

        // GET: Tourists/Delete/5
        /*
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tourist = await _context.Tourist
                .FirstOrDefaultAsync(m => m.TouristId == id);
            if (tourist == null)
            {
                return NotFound();
            }

            return View(tourist);
        }

        // POST: Tourists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tourist = await _context.Tourist.FindAsync(id);
            _context.Tourist.Remove(tourist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/

        private bool TouristExists(int id)
        {
            return _context.Tourist.Any(e => e.TouristId == id);
        }
    }
}
