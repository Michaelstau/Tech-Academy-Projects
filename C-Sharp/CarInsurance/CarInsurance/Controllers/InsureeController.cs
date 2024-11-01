using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private readonly InsureeContext _context;

        public InsureeController(InsureeContext context)
        {
            _context = context;
        }

        // GET: Insuree
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insuree.ToListAsync());
        }

        // GET: Insuree/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }
        // GET: Insuree/Admin
        public async Task<IActionResult> Admin()
        {
            return View(await _context.Insuree.ToListAsync());
        }
        // GET: Insuree/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTicket,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Id = Guid.NewGuid();
                insuree.Quote = 0;
                var now = DateOnly.FromDateTime(DateTime.Now);
                if (insuree.DateOfBirth.AddYears(18) >= now)
                {
                    insuree.Quote += 100;
                }
                else if (insuree.DateOfBirth.AddYears(26) <= now)
                {
                    insuree.Quote += 50;
                }
                else
                {
                    insuree.Quote += 25;
                }
                if (insuree.CarYear.Year < 2000)
                {
                    insuree.Quote += 25;
                }
                else if (insuree.CarYear.Year > 2015)
                {
                    insuree.Quote += 25;
                }
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    insuree.Quote += 25;
                }
                if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
                {
                    insuree.Quote += 25;
                }
                insuree.Quote += insuree.SpeedingTicket * 10;
                if (insuree.DUI)
                {
                    insuree.Quote = Convert.ToInt32(insuree.Quote * 1.25);
                }
                if (insuree.CoverageType.ToLower() == "full")
                {
                    insuree.Quote = Convert.ToInt32(insuree.Quote * 1.5);
                }
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTicket,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
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
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree != null)
            {
                _context.Insuree.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(Guid id)
        {
            return _context.Insuree.Any(e => e.Id == id);
        }
    }
}
