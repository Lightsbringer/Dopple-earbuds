using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoppleApi.Entities;
using DoppleApi.Models;
namespace DoppleApi.Controllers
{


    public class InstructionModelsController : Controller
    {
        private readonly bs39hu6mp56dbv0qContext _context;

        public InstructionModelsController(bs39hu6mp56dbv0qContext context)
        {
            _context = context;
        }

        // GET: InstructionModels
        public async Task<IActionResult> Index()
        {
            var bs39hu6mp56dbv0qContext = _context.InstructionModel.Include(i => i.Station);
            return View(await bs39hu6mp56dbv0qContext.ToListAsync());
        }

        // GET: InstructionModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.InstructionModel == null)
            {
                return NotFound();
            }

            var instructionModel = await _context.InstructionModel
                .Include(i => i.Station)
                .FirstOrDefaultAsync(m => m.InstructionId == id);
            if (instructionModel == null)
            {
                return NotFound();
            }

            return View(instructionModel);
        }

        // GET: InstructionModels/Create
        public IActionResult Create()
        {
            ViewData["StationId"] = new SelectList(_context.Stations, "StationId", "StatusStation");
            return View();
        }

        // POST: InstructionModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstructionId,Description,ImagePath,StationId")] InstructionModel instructionModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instructionModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StationId"] = new SelectList(_context.Stations, "StationId", "StatusStation", instructionModel.StationId);
            return View(instructionModel);
        }

        // GET: InstructionModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.InstructionModel == null)
            {
                return NotFound();
            }

            var instructionModel = await _context.InstructionModel.FindAsync(id);
            if (instructionModel == null)
            {
                return NotFound();
            }
            ViewData["StationId"] = new SelectList(_context.Stations, "StationId", "StatusStation", instructionModel.StationId);
            return View(instructionModel);
        }

        // POST: InstructionModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("InstructionId,Description,ImagePath,StationId")] InstructionModel instructionModel)
        {
            if (id != instructionModel.InstructionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instructionModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstructionModelExists(instructionModel.InstructionId))
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
            ViewData["StationId"] = new SelectList(_context.Stations, "StationId", "StatusStation", instructionModel.StationId);
            return View(instructionModel);
        }

        // GET: InstructionModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.InstructionModel == null)
            {
                return NotFound();
            }

            var instructionModel = await _context.InstructionModel
                .Include(i => i.Station)
                .FirstOrDefaultAsync(m => m.InstructionId == id);
            if (instructionModel == null)
            {
                return NotFound();
            }

            return View(instructionModel);
        }

        // POST: InstructionModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.InstructionModel == null)
            {
                return Problem("Entity set 'bs39hu6mp56dbv0qContext.InstructionModel'  is null.");
            }
            var instructionModel = await _context.InstructionModel.FindAsync(id);
            if (instructionModel != null)
            {
                _context.InstructionModel.Remove(instructionModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstructionModelExists(string id)
        {
          return _context.InstructionModel.Any(e => e.InstructionId == id);
        }
    }
}
