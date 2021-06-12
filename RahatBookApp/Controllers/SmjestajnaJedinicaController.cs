using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RahatBookAplikacija.Models;
using RahatBookApp.Data;

namespace RahatBookApp.Controllers
{
    [Authorize]
    public class SmjestajnaJedinicaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SmjestajnaJedinicaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SmjestajnaJedinica
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.SmjestajnaJedinica.ToListAsync());
        }

        // GET: SmjestajnaJedinica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smjestajnaJedinica = await _context.SmjestajnaJedinica
                .FirstOrDefaultAsync(m => m.id == id);
            if (smjestajnaJedinica == null)
            {
                return NotFound();
            }

            return View(smjestajnaJedinica);
        }

        // GET: SmjestajnaJedinica/Create
        [Authorize(Roles ="Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: SmjestajnaJedinica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,naziv,brojZvjezdica,idLokacije,idKarakteristike,idUsluge,status")] SmjestajnaJedinica smjestajnaJedinica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(smjestajnaJedinica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(smjestajnaJedinica);
        }

        // GET: SmjestajnaJedinica/Edit/5
        [Authorize(Roles ="Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smjestajnaJedinica = await _context.SmjestajnaJedinica.FindAsync(id);
            if (smjestajnaJedinica == null)
            {
                return NotFound();
            }
            return View(smjestajnaJedinica);
        }

        // POST: SmjestajnaJedinica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,naziv,brojZvjezdica,idLokacije,idKarakteristike,idUsluge,status")] SmjestajnaJedinica smjestajnaJedinica)
        {
            if (id != smjestajnaJedinica.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(smjestajnaJedinica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SmjestajnaJedinicaExists(smjestajnaJedinica.id))
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
            return View(smjestajnaJedinica);
        }

        // GET: SmjestajnaJedinica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var smjestajnaJedinica = await _context.SmjestajnaJedinica
                .FirstOrDefaultAsync(m => m.id == id);
            if (smjestajnaJedinica == null)
            {
                return NotFound();
            }

            return View(smjestajnaJedinica);
        }

        // POST: SmjestajnaJedinica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var smjestajnaJedinica = await _context.SmjestajnaJedinica.FindAsync(id);
            _context.SmjestajnaJedinica.Remove(smjestajnaJedinica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SmjestajnaJedinicaExists(int id)
        {
            return _context.SmjestajnaJedinica.Any(e => e.id == id);
        }
    }
}
