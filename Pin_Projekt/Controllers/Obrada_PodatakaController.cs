using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pin_Projekt.Models;

namespace Pin_Projekt.Controllers
{
    public class Obrada_PodatakaController : Controller
    {
        private readonly Context _context;

        public Obrada_PodatakaController(Context context)
        {
            _context = context;
        }

        // GET: Obrada_Podataka
        public async Task<IActionResult> Index()
        {
            return View(await _context.Obrada_Podataka.ToListAsync());
        }

        // GET: Obrada_Podataka/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obrada_Podataka = await _context.Obrada_Podataka
                .FirstOrDefaultAsync(m => m.ID == id);
            if (obrada_Podataka == null)
            {
                return NotFound();
            }

            return View(obrada_Podataka);
        }

        // GET: Obrada_Podataka/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Obrada_Podataka/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Ime_Proizvoda,Tržište,Date,Etiketa,Čep,Izgled_Proizvoda")] Obrada_Podataka obrada_Podataka)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obrada_Podataka);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(obrada_Podataka);
        }

        // GET: Obrada_Podataka/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obrada_Podataka = await _context.Obrada_Podataka.FindAsync(id);
            if (obrada_Podataka == null)
            {
                return NotFound();
            }
            return View(obrada_Podataka);
        }

        // POST: Obrada_Podataka/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Ime_Proizvoda,Tržište,Date,Etiketa,Čep,Izgled_Proizvoda")] Obrada_Podataka obrada_Podataka)
        {
            if (id != obrada_Podataka.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(obrada_Podataka);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Obrada_PodatakaExists(obrada_Podataka.ID))
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
            return View(obrada_Podataka);
        }

        // GET: Obrada_Podataka/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obrada_Podataka = await _context.Obrada_Podataka
                .FirstOrDefaultAsync(m => m.ID == id);
            if (obrada_Podataka == null)
            {
                return NotFound();
            }

            return View(obrada_Podataka);
        }

        // POST: Obrada_Podataka/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var obrada_Podataka = await _context.Obrada_Podataka.FindAsync(id);
            _context.Obrada_Podataka.Remove(obrada_Podataka);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Obrada_PodatakaExists(int id)
        {
            return _context.Obrada_Podataka.Any(e => e.ID == id);
        }
    }
}
