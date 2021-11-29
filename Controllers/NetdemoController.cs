using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Netmo.Data;
using Netmo.Models;

namespace Netmo.Controllers
{
    public class NetdemoController : Controller
    {
        private readonly ApplicationDBContext _context;

        public NetdemoController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Netdemo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Netdemo.ToListAsync());
        }

        // GET: Netdemo/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var netdemo = await _context.Netdemo
                .FirstOrDefaultAsync(m => m.NetdemoID == id);
            if (netdemo == null)
            {
                return NotFound();
            }

            return View(netdemo);
        }

        // GET: Netdemo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Netdemo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NetdemoID,NetdemoName")] Netdemo netdemo)
        {
            try{
                if (ModelState.IsValid)
                {
                    _context.Add(netdemo);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch{
                ModelState.AddModelError("","khoa mo");
            }
            
            return View(netdemo);
        }

        // GET: Netdemo/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var netdemo = await _context.Netdemo.FindAsync(id);
            if (netdemo == null)
            {
                return NotFound();
            }
            return View(netdemo);
        }

        // POST: Netdemo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NetdemoID,NetdemoName")] Netdemo netdemo)
        {
            if (id != netdemo.NetdemoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(netdemo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NetdemoExists(netdemo.NetdemoID))
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
            return View(netdemo);
        }

        // GET: Netdemo/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var netdemo = await _context.Netdemo
                .FirstOrDefaultAsync(m => m.NetdemoID == id);
            if (netdemo == null)
            {
                return NotFound();
            }

            return View(netdemo);
        }

        // POST: Netdemo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var netdemo = await _context.Netdemo.FindAsync(id);
            _context.Netdemo.Remove(netdemo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NetdemoExists(string id)
        {
            return _context.Netdemo.Any(e => e.NetdemoID == id);
        }
    }
}
