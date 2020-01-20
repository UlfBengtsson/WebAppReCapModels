using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppReCapModels.Models;

namespace WebAppReCapModels.Controllers
{
    public class DontDBController : Controller
    {
        private readonly ExDbContext _context;

        public DontDBController(ExDbContext context)
        {
            _context = context;
        }

        // GET: DontDB
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cakes.ToListAsync());
        }

        // GET: DontDB/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cake = await _context.Cakes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cake == null)
            {
                return NotFound();
            }

            return View(cake);
        }

        // GET: DontDB/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DontDB/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Servings,GlutenFree,LactoseFree,NutsFree")] Cake cake)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cake);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cake);
        }

        // GET: DontDB/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cake = await _context.Cakes.FindAsync(id);
            if (cake == null)
            {
                return NotFound();
            }
            return View(cake);
        }

        // POST: DontDB/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Servings,GlutenFree,LactoseFree,NutsFree")] Cake cake)
        {
            if (id != cake.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cake);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CakeExists(cake.Id))
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
            return View(cake);
        }

        // GET: DontDB/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cake = await _context.Cakes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cake == null)
            {
                return NotFound();
            }

            return View(cake);
        }

        // POST: DontDB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cake = await _context.Cakes.FindAsync(id);
            _context.Cakes.Remove(cake);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CakeExists(int id)
        {
            return _context.Cakes.Any(e => e.Id == id);
        }
    }
}
