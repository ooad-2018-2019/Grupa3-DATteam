using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DATteam.Models;

namespace DATteam.Controllers
{
    public class RadniciController : Controller
    {
        private readonly DATContext _context;

        public RadniciController(DATContext context)
        {
            _context = context;
        }

        // GET: Radnici
        public async Task<IActionResult> Index()
        {
            return View(await _context.Radnik.ToListAsync());
        }

        // GET: Radnici/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radnik = await _context.Radnik
                .FirstOrDefaultAsync(m => m.id == id);
            if (radnik == null)
            {
                return NotFound();
            }

            return View(radnik);
        }

        // GET: Radnici/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Radnici/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] Radnik radnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(radnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(radnik);
        }

        // GET: Radnici/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radnik = await _context.Radnik.FindAsync(id);
            if (radnik == null)
            {
                return NotFound();
            }
            return View(radnik);
        }

        // POST: Radnici/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] Radnik radnik)
        {
            if (id != radnik.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(radnik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RadnikExists(radnik.id))
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
            return View(radnik);
        }

        // GET: Radnici/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var radnik = await _context.Radnik
                .FirstOrDefaultAsync(m => m.id == id);
            if (radnik == null)
            {
                return NotFound();
            }

            return View(radnik);
        }

        // POST: Radnici/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var radnik = await _context.Radnik.FindAsync(id);
            _context.Radnik.Remove(radnik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RadnikExists(int id)
        {
            return _context.Radnik.Any(e => e.id == id);
        }
    }
}
