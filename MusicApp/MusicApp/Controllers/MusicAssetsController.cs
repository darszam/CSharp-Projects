using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicApp.Models;

namespace MusicApp.Controllers
{
    public class MusicAssetsController : Controller
    {
        private readonly MusicAppContext _context;

        public MusicAssetsController(MusicAppContext context)
        {
            _context = context;
        }

        // GET: MusicAssets
        public async Task<IActionResult> Index()
        {
            return View(await _context.MusicAsset.ToListAsync());
        }

        // GET: MusicAssets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicAsset = await _context.MusicAsset
                .SingleOrDefaultAsync(m => m.ID == id);
            if (musicAsset == null)
            {
                return NotFound();
            }

            return View(musicAsset);
        }

        // GET: MusicAssets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MusicAssets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Author,Tuning,Genre,Rating,DurationTime,Minutes,Seconds")] MusicAsset musicAsset)
        {
            if (ModelState.IsValid)
            {
                _context.Add(musicAsset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(musicAsset);
        }

        // GET: MusicAssets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicAsset = await _context.MusicAsset.SingleOrDefaultAsync(m => m.ID == id);
            if (musicAsset == null)
            {
                return NotFound();
            }
            return View(musicAsset);
        }

        // POST: MusicAssets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Author,Tuning,Genre,Rating,DurationTime,Minutes,Seconds")] MusicAsset musicAsset)
        {
            if (id != musicAsset.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musicAsset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicAssetExists(musicAsset.ID))
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
            return View(musicAsset);
        }

        // GET: MusicAssets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicAsset = await _context.MusicAsset
                .SingleOrDefaultAsync(m => m.ID == id);
            if (musicAsset == null)
            {
                return NotFound();
            }

            return View(musicAsset);
        }

        // POST: MusicAssets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var musicAsset = await _context.MusicAsset.SingleOrDefaultAsync(m => m.ID == id);
            _context.MusicAsset.Remove(musicAsset);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicAssetExists(int id)
        {
            return _context.MusicAsset.Any(e => e.ID == id);
        }
    }
}
