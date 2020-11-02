using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrganizationX.Data;
using OrganizationX.Models;

namespace OrganizationX.Controllers
{
    public class OXUsersController : Controller
    {
        private readonly OXUserContext _context;

        public OXUsersController(OXUserContext context)
        {
            _context = context;
        }

        // GET: OXUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.OXUser.ToListAsync());
        }

        // GET: OXUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oXUser = await _context.OXUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oXUser == null)
            {
                return NotFound();
            }

            return View(oXUser);
        }

        // GET: OXUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OXUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,EmailAddress,PasswordHash,RoleLevel,Permissions")] OXUser oXUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oXUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oXUser);
        }

        // GET: OXUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oXUser = await _context.OXUser.FindAsync(id);
            if (oXUser == null)
            {
                return NotFound();
            }
            return View(oXUser);
        }

        // POST: OXUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,EmailAddress,PasswordHash,RoleLevel,Permissions")] OXUser oXUser)
        {
            if (id != oXUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oXUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OXUserExists(oXUser.Id))
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
            return View(oXUser);
        }

        // GET: OXUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oXUser = await _context.OXUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oXUser == null)
            {
                return NotFound();
            }

            return View(oXUser);
        }

        // POST: OXUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oXUser = await _context.OXUser.FindAsync(id);
            _context.OXUser.Remove(oXUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OXUserExists(int id)
        {
            return _context.OXUser.Any(e => e.Id == id);
        }
    }
}
