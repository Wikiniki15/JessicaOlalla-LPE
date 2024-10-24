using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JessicaOlalla_LPE.Models;

namespace JessicaOlalla_LPE.Controllers
{
    public class EquipoesController : Controller
    {
        private readonly EquipoContext _context;

        public EquipoesController(EquipoContext context)
        {
            _context = context;
        }

        // GET: Equipoes
        public async Task<IActionResult> Index()
        {
            var EquipoContext = _context.Equipo.Include(j => j.estadio);
            return View(await EquipoContext.ToListAsync());
        }

        // GET: Equipoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipo
                .Include(e => e.estadio)
                .FirstOrDefaultAsync(m => m.Id_Equipo == id);

            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }

        // GET: Equipoes/Create
        public IActionResult Create()
        {
            ViewData["EstadioId"] = new SelectList(_context.Estadio, "Id_Estadio", "Nombre_Estadio");
            return View();
        }

        // POST: Equipoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Equipo,Nombre_Equipo,Ciudad_Equipo,Titulos,Acepta_Extranjeros, EstadioId")] Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EstadioId"] = new SelectList(_context.Estadio, "Id_Estadio", "Nombre_Estadio");
            return View(equipo);
        }

        // GET: Equipoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipo
                .Include(e => e.estadio)
                .FirstOrDefaultAsync(m => m.Id_Equipo == id);

            if (equipo == null)
            {
                return NotFound();
            }
            ViewData["EstadioId"] = new SelectList(_context.Estadio, "Id_Estadio", "Nombre_Estadio");
            return View(equipo);
        }

        // POST: Equipoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Equipo,Nombre_Equipo,Ciudad_Equipo,Titulos,Acepta_Extranjeros, EstadioId")] Equipo equipo)
        {
            if (id != equipo.Id_Equipo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipoExists(equipo.Id_Equipo))
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
            ViewData["EstadioId"] = new SelectList(_context.Estadio, "Id_Estadio", "Nombre_Estadio");
            return View(equipo);
        }

        // GET: Equipoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipo
                .Include(e => e.estadio)
                .FirstOrDefaultAsync(m => m.Id_Equipo == id);

            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }

        // POST: Equipoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipo = await _context.Equipo.FindAsync(id);
            if (equipo != null)
            {
                _context.Equipo.Remove(equipo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipoExists(int id)
        {
            return _context.Equipo.Any(e => e.Id_Equipo == id);
        }
    }
}
