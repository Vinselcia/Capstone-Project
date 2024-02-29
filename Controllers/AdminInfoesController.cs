using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlogWebApplication.Data;
using BlogWebApplication.Models.Domain;

namespace BlogWebApplication.Controllers
{
    public class AdminInfoesController : Controller
    {
        private readonly BlogWebApplicationContext _context;

        public AdminInfoesController(BlogWebApplicationContext context)
        {
            _context = context;
        }

        // GET: AdminInfoes
        public async Task<IActionResult> Index()
        {
              return _context.AdminInfo != null ? 
                          View(await _context.AdminInfo.ToListAsync()) :
                          Problem("Entity set 'BlogWebApplicationContext.AdminInfo'  is null.");
        }

        // GET: AdminInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdminInfo == null)
            {
                return NotFound();
            }

            var adminInfo = await _context.AdminInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminInfo == null)
            {
                return NotFound();
            }

            return View(adminInfo);
        }

        // GET: AdminInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdminInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmailId,Password")] AdminInfo adminInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adminInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adminInfo);
        }

        // GET: AdminInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdminInfo == null)
            {
                return NotFound();
            }

            var adminInfo = await _context.AdminInfo.FindAsync(id);
            if (adminInfo == null)
            {
                return NotFound();
            }
            return View(adminInfo);
        }

        // POST: AdminInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EmailId,Password")] AdminInfo adminInfo)
        {
            if (id != adminInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminInfoExists(adminInfo.Id))
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
            return View(adminInfo);
        }

        // GET: AdminInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdminInfo == null)
            {
                return NotFound();
            }

            var adminInfo = await _context.AdminInfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminInfo == null)
            {
                return NotFound();
            }

            return View(adminInfo);
        }

        // POST: AdminInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdminInfo == null)
            {
                return Problem("Entity set 'BlogWebApplicationContext.AdminInfo'  is null.");
            }
            var adminInfo = await _context.AdminInfo.FindAsync(id);
            if (adminInfo != null)
            {
                _context.AdminInfo.Remove(adminInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminInfoExists(int id)
        {
          return (_context.AdminInfo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
