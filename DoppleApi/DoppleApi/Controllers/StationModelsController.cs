using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoppleApi.Entities;

namespace DoppleApi.Controllers
{
    public class StationModelsController : Controller
    {
        private readonly bs39hu6mp56dbv0qContext _context;

        public StationModelsController(bs39hu6mp56dbv0qContext context)
        {
            _context = context;
        }

        // GET: StationModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.StationModel.ToListAsync());
        }

        // GET: StationModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StationModel == null)
            {
                return NotFound();
            }

            var stationModel = await _context.StationModel
                .FirstOrDefaultAsync(m => m.StationId == id);
            if (stationModel == null)
            {
                return NotFound();
            }

            return View(stationModel);
        }

        // GET: StationModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StationModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost ("Create") ]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StationId,StatusStation")] StationModel stationModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stationModel);
        }

        // GET: StationModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StationModel == null)
            {
                return NotFound();
            }

            var stationModel = await _context.StationModel.FindAsync(id);
            if (stationModel == null)
            {
                return NotFound();
            }
            return View(stationModel);
        }

        // POST: StationModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StationId,StatusStation")] StationModel stationModel)
        {
            if (id != stationModel.StationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stationModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StationModelExists(stationModel.StationId))
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
            return View(stationModel);
        }

        // GET: StationModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StationModel == null)
            {
                return NotFound();
            }

            var stationModel = await _context.StationModel
                .FirstOrDefaultAsync(m => m.StationId == id);
            if (stationModel == null)
            {
                return NotFound();
            }

            return View(stationModel);
        }

        // POST: StationModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StationModel == null)
            {
                return Problem("Entity set 'bs39hu6mp56dbv0qContext.StationModel'  is null.");
            }
            var stationModel = await _context.StationModel.FindAsync(id);
            if (stationModel != null)
            {
                _context.StationModel.Remove(stationModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StationModelExists(int id)
        {
          return _context.StationModel.Any(e => e.StationId == id);
        }
    }
}
