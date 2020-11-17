using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OrganizationX.Data;
using OrganizationX.Helpers;
using OrganizationX.Models;

namespace OrganizationX.Controllers
{
    public class AuthorizationsController : Controller
    {
        private readonly AuthorizationContext _context;
        private readonly OXUserContext _oXUser;

        public AuthorizationsController(AuthorizationContext context, OXUserContext oXUser)
        {
            _context = context;
            _oXUser = oXUser;
        }

        // GET: Authorizations
        public async Task<IActionResult> Index()
        {
            List<Authorization> authorizations = _context.Authorization.AsQueryable().Where(m => m.CreatedBy == User.Identity.Name).ToList();

            return View(authorizations);
        }

        // GET: Authorizations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authorization = await _context.Authorization
                .FirstOrDefaultAsync(m => m.Id == id);
            if (authorization == null)
            {
                return NotFound();
            }

            return View(authorization);
        }

        [HttpGet]
        public IActionResult Error(ErrorModel err)
        {
            return View(err);
        }

        // GET: Authorizations/Create
        public IActionResult Create()
        {

            ErrorModel err = new ErrorModel
            {
                ErrorCode = 401,
                ErrorMessage = "You do not have access to this resource!",
                ReturnUrl = "~/Home/Index",
                ReturnUrlName = "Home"
            };
            if (!User.Identity.IsAuthenticated)
            {
                ErrorModel errLog = new ErrorModel
                {
                    ErrorCode = 401,
                    ErrorMessage = "You are not currently logged in!",
                    ReturnUrl = "",
                    ReturnUrlName = "Login"
                };
                return View("Error", errLog);
            }
            try
            {
                var user = _oXUser.OXUser
                .First(m => m.Username == User.Identity.Name);
                Console.WriteLine(user.EmailAddress);
                var auth = _context.Authorization
                    .First(m => m.Email == user.EmailAddress);
                Console.WriteLine(auth.Email);
                if (auth.Email == null)
                {
                     return View("Error", err);
                }
                if (auth.Role != RoleLevel.Level0 && auth.Role != RoleLevel.Level1)
                {
                     return View("Error", err);
                }
            }
            catch
            {

            }

            return View();
        }

        // POST: Authorizations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,PhoneNumber,CreatedBy,Role,Token,TokenExpireDate,CreatedDate,TokenStatus, Department")] Authorization authorization)
        {


            authorization.Token = authorization.Email; 
            
            
            if (ModelState.IsValid)
            {
                _context.Add(authorization);
                await _context.SaveChangesAsync();
                bool emailer = new Emailer().SendEmail(authorization.Email, authorization.Token);
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

            var authorization = await _context.Authorization.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,PhoneNumber,Role,Token,TokenExpireDate,CreatedDate,TokenStatus")] Authorization authorization)
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

            var authorization = await _context.Authorization
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
            var authorization = await _context.Authorization.FindAsync(id);
            _context.Authorization.Remove(authorization);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuthorizationExists(int id)
        {
            return _context.Authorization.Any(e => e.Id == id);
        }
    }
}
