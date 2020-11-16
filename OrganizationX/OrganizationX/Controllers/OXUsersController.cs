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
       


      
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel _login)
        {
                if (_login.Username == null || _login.Password == null)
            {
                _login.Err = "Login failed!";
                return View("Login", _login);
            }
                var result = await _signInManager.PasswordSignInAsync(_login.Username, _login.Password, false, lockoutOnFailure: false);
                Console.WriteLine(result.ToString());
                if (!result.Succeeded)
            {
                _login.Err = "Login failed!";
                return View("Login", _login);
            }
                Console.WriteLine(_signInManager.IsSignedIn(User));
            
          
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
                try
                {
                    //Fetch authorized user account
                    var user = _authcontext.Authorization.AsQueryable().Where(m => m.Email == oXUser.EmailAddress).First();
                    //Check token expiration
                    ErrorModel ERR_EXP = new ErrorModel
                    {
                        ErrorMessage = "The token for this account has expired",
                        ErrorCode = 401,
                        ReturnUrl = "OXUsers/Login",
                        ReturnUrlName = "Contact Administrator"
                    };
                    if (user.TokenStatus == TokenStatus.Expired)
                    {
                        return View("Error", ERR_EXP);
                    }
                    if (user.TokenExpireDate < DateTime.Now)
                    {
                        return View("Error", ERR_EXP);
                    }
                    //Check token status
                    ErrorModel ERR_CONSUMED = new ErrorModel
                    {
                        ErrorMessage = "The token for this account has already been used",
                        ErrorCode = 401,
                        ReturnUrl = "OXUsers/Login",
                        ReturnUrlName = "Contact Administrator"
                    };
                    if (user.TokenStatus == TokenStatus.Consumed)
                    {
                        return View("Error", ERR_CONSUMED);
                    }

                    if (user.TokenStatus == TokenStatus.Pending)
                    {
                        //Create User Identity
                        var oooo = new IdentityUser { UserName = oXUser.Username, Email = oXUser.EmailAddress, EmailConfirmed = true };
                        var result = await _userManager.CreateAsync(oooo, oXUser.PasswordHash);
                        //Insert OXUser data
                        _context.Add(oXUser);
                        await _context.SaveChangesAsync();
                        //Update Token Status
                        user.TokenStatus = TokenStatus.Consumed;
                        _authcontext.Update(user);
                        await _authcontext.SaveChangesAsync();
                        Console.WriteLine("Registering user success! Department : " + oXUser.Department);
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch
                {
                    //On Error
                    return View(oXUser);
                }

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
