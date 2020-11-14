using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly AuthorizationContext _authcontext;
         private readonly SignInManager<IdentityUser> _signInManager;
         private readonly UserManager<IdentityUser> _userManager;

        //, UserManager<OXUser> userManager, SignInManager<OXUser> signInManager
        public OXUsersController(OXUserContext context, AuthorizationContext authorizationContext, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _authcontext = authorizationContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: OXUsers
      
        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction(nameof(Login));
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

        public IActionResult Error()
        {
            return View();
        }

        [HttpGet]
        [Route("Register/{token?}")]
        public  IActionResult Register(string token)
        {
            Console.WriteLine("Token: " + token);
            IQueryable<Authorization> authUser = _authcontext.Authorization.Where(vt => vt.Token == token); 
            
            if (authUser.Count() == 0)
            {
                return RedirectToAction(nameof(Error));
            }

            OXUser oXUser = new OXUser();

            oXUser.EmailAddress = authUser.First().Email;
            oXUser.PhoneNumber = authUser.First().PhoneNumber;
            oXUser.RoleLevel = authUser.First().Role;
            oXUser.Department = authUser.First().Department;
           
            

            return View(oXUser);
        }

        [HttpPost]
        public async Task<IActionResult> Registfer(OXUser user)
        {
            Console.WriteLine("Registering User");
            return RedirectToPage("Index", "Home");
        }



            // GET: ValidateToken
            public IActionResult ValidateToken2(string token)
        {
            Console.WriteLine("Token: " + token);
            IQueryable<Authorization> oXUsers = _authcontext.Authorization;
            oXUsers.Where(vt => vt.Token == token);
            if (oXUsers.First() == null)
            {
                return RedirectToAction(nameof(Error));
            }
            else
            {
                //var oooo = new OXUser { Username = user.Username, EmailAddress = user.EmailAddress };
               // var result = await _userManager.CreateAsync(oooo, oXUser.PasswordHash);
                Console.WriteLine("Registered User");
            }
            return View();
        }


      
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel _login)
        {
            IQueryable<OXUser> oXUser = _context.OXUser.Where(uName => uName.Username == _login.Username);
            if (oXUser.First().PasswordHash == _login.Password)
            {
                
                Console.WriteLine(": login failed successfully ");

                var result = await _signInManager.PasswordSignInAsync(_login.Username, _login.Password, false, lockoutOnFailure: false);
                Console.WriteLine(result.ToString());
                Console.WriteLine(_signInManager.IsSignedIn(User));
            }
            else
            {
                Console.WriteLine("Login failed");
            }
            return LocalRedirect("~/Home/Index");
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
        public async Task<IActionResult> Create([Bind("Id,Username,EmailAddress, Department,PasswordHash,RoleLevel,Permissions")] OXUser oXUser)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Registering user success! Department : " + oXUser.Department);

                var oooo = new IdentityUser { UserName = oXUser.Username, Email = oXUser.EmailAddress, EmailConfirmed=true };
                var result = await _userManager.CreateAsync(oooo, oXUser.PasswordHash);
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
