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
    public class AuthorizationsController : Controller
    {
        private readonly EmployeeContext _context;

        public AuthorizationsController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: Authorizations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Administration.ToListAsync());
        }

        // GET: Authorizations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorization = await _context.Administration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (authorization == null)
            {
                return NotFound();
            }

            return View(authorization);
        }

        // GET: Authorizations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Authorizations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmailAddress,RolePolicy,PhoneNumber,Email,Token,TokenExpirationDate,CreationTime,CreatedBy")] Authorization authorization)
        {
            if (ModelState.IsValid)
            {
                _context.Add(authorization);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(authorization);
        }

        // GET: Authorizations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorization = await _context.Administration.FindAsync(id);
            if (authorization == null)
            {
                return NotFound();
            }
            return View(authorization);
        }

        // POST: Authorizations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EmailAddress,RolePolicy,PhoneNumber,Email,Token,TokenExpirationDate,CreationTime,CreatedBy")] Authorization authorization)
        {
            if (id != authorization.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(authorization);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthorizationExists(authorization.Id))
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
            return View(authorization);
        }

        // GET: Authorizations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorization = await _context.Administration
                .FirstOrDefaultAsync(m => m.Id == id);
            if (authorization == null)
            {
                return NotFound();
            }

            return View(authorization);
        }

        // POST: Authorizations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authorization = await _context.Administration.FindAsync(id);
            _context.Administration.Remove(authorization);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuthorizationExists(int id)
        {
            return _context.Administration.Any(e => e.Id == id);
        }
    }
}
