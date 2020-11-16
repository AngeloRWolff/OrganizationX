using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OrganizationX.Data;
using OrganizationX.Helpers;
using OrganizationX.Models;

namespace OrganizationX.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeContext _context;
        private readonly OXUserContext _user;
        private readonly AuthorizationContext _auth;
        private readonly EmployeeHistoryContext _hist;

        public EmployeesController(EmployeeContext context, OXUserContext user, AuthorizationContext auth, EmployeeHistoryContext hist)
        {
            _user = user;
            _context = context;
            _auth = auth;
            _hist = hist;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employee.ToListAsync());
        }

        // GET: Load
        public IActionResult Load()
        {
            return View();
        }


        // POST: SeedData
        // Analyzes Seed Data Against Employee Model
        [HttpPost]
        public async Task<IActionResult> Load([Bind("Seed")] SeedData seedData)
        {
            SeedMutator mutatedSeed = new SeedMutator
            {
                SeedData = seedData.Seed,
                Options = new SeedOptions
                {
                    HasKeys = true,
                    CsvDelimeter = ','
                }
            };
            SeedDataProperties seedDataProperties = new SeedDataProperties
            {
                EmployeeQueue = mutatedSeed.GetEmployees(),
                Conflicts = null,
                MissingKeys = null,
                TotalRecords = mutatedSeed.Size,
                Keys = mutatedSeed.getKeys()
            };
            
            foreach (Employee employee in seedDataProperties.EmployeeQueue)
            {
                _context.Add(employee);

                EmployeeHistory employeeHistory = new EmployeeHistory
                {
                    Author = "System",
                    ModifiedDate = DateTime.Now,
                    TargetId = (int)employee.EmployeeNumber,
                 };
                _hist.Add(employeeHistory);

            }
            await _context.SaveChangesAsync();
            await _hist.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // POST: Employee Seed
        [HttpPost]
        public IActionResult SubmitSeed([Bind("Employees,Keys,TotalRecords,MissingKeys,Conflicts")] SeedDataProperties sdp)
        {
            Console.WriteLine(sdp.TotalRecords);
            int x = 0;
            foreach (Employee employee in sdp.EmployeeQueue)
            {
                x++;
            }
            Console.WriteLine("HHH" + x);




            return RedirectToAction(nameof(Index));
        }



        // GET: Employees/Details/5
        public async Task<IActionResult> Details(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        [Authorize]
        public IActionResult Create()
        {
            var user = _user.OXUser.AsQueryable().Where(d => d.Username == User.Identity.Name).First();
            var authorization = _auth.Authorization.AsQueryable().Where(d => d.Email == user.EmailAddress).First();
            if (user.RoleLevel != RoleLevel.Level0 && user.RoleLevel != RoleLevel.Level1)
            {
                ErrorModel ERR_RESTRICTED = new ErrorModel
                {
                    ErrorMessage = "You do not have sufficient privelidges for this action.",
                    ErrorCode = 403,
                    ReturnUrl = "Home/Index",
                    ReturnUrlName = "Return",
                };
                return View("Error", ERR_RESTRICTED);
            }
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Employee employee)
        {
           
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(uint id, [Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Employee employee)
        {
            if (id != employee.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeNumber))
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
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpGet]
        public async Task<IActionResult> SearchSelection()
        {
            SearchParameters sp = new SearchParameters();
            Option op = new Option();
            string[] k = new string[1];
            Console.WriteLine(User.Identity.Name);
            var employee = await _user.OXUser
                .FirstOrDefaultAsync(m => m.Username == User.Identity.Name);

            Console.WriteLine(employee.Department);
            //Query to get department 

            k[0] = employee.Department;
            op.ExactString= k;
            sp.Department = op;


            return View(sp);
        }

        [HttpPost]
        public IActionResult SearchSelection(SearchParameters sp)
        {

            //Console.WriteLine(sp.Age.OptionType.ToString());
            // return RedirectToAction(nameof(SearchSelection));

            
            Stopwatch bench = new Stopwatch();
            LinqDynamicQueryOptimizer LDQO = new LinqDynamicQueryOptimizer();
            bench.Start();

            foreach (PropertyInfo ppp in sp.GetType().GetProperties())
            {

                Option p = (Option)ppp.GetValue(sp);
                Console.WriteLine(p.ExactString[0]);
                if (p.OptionType != OptionType.None)
                {
                    switch (p.OptionType)
                    {
                        case OptionType.ExactInt:
                            {
                                LDQO.AddExactInt(ppp.Name, p.ExactInt);
                            }
                            break;
                        case OptionType.ExactString:
                            {
                                LDQO.AddExactString(ppp.Name, p.ExactString);
                            }
                            break;
                        case OptionType.Range:
                            {
                                LDQO.AddRange(ppp.Name, p.Range);
                            }
                            break;
                        case OptionType.Relation:
                            {
                                LDQO.AddRelation(ppp.Name, p.Relation);
                            }
                            break;
                    }
                }
            }
            Console.WriteLine(LDQO.GetQuery());
            List<EmployeeTrace> employeeTrace = new List<EmployeeTrace>();
            IQueryable<Employee> employeeContext = _context.Employee.Where(LDQO.GetQuery());

            foreach (Employee e in employeeContext)
            {
                EmployeeHistory ehist = _hist.EmployeeHistory.First(m=>m.TargetId == (int)e.EmployeeNumber);
                employeeTrace.Add(new EmployeeTrace
                {
                    employee = e,
                    history = ehist
                });
            }
            return View("SearchResults", employeeTrace);
            //return View("SearchResults", employeeContext.ToList());
            // return RedirectToAction(nameof(SearchSelection));
            // Console.WriteLine(LDQO.query);
            //IQueryable<Employee> employeeContext = _context.Employee.Where(LDQO.query);

            Console.WriteLine($"Execution Time (ms): {bench.Elapsed.TotalMilliseconds}");
            bench.Stop();


            //  return RedirectToAction(nameof(SearchSelection));

            // return View("Index", employeeContext.ToList());
        }

        // GET: Analytics
        public IActionResult Analytics()
        {
            List<PieChartData> chartData = new List<PieChartData>
            {

                new PieChartData { xValue = "Chrome", yValue = 37 },
                new PieChartData { xValue = "UC Browser", yValue = 17 },
                new PieChartData { xValue = "iPhone", yValue = 19 },
                new PieChartData { xValue = "Others", yValue = 4  },
                new PieChartData { xValue = "Opera", yValue = 11 },
                new PieChartData { xValue = "Android", yValue = 12 },
            };
            ViewBag.dataSource = chartData;

            List<ChartData> barChartData = new List<ChartData>
            {
                new ChartData { xValue = "2014", yValue = 21 },
                new ChartData { xValue = "2015", yValue = 24 },
                new ChartData { xValue = "2016", yValue = 36 },
                new ChartData { xValue = "2017", yValue = 38 },
                new ChartData { xValue = "2018", yValue = 54 },
                new ChartData { xValue = "2019", yValue = 57 },
                new ChartData { xValue = "2020", yValue = 70 },
            };
            ViewBag.dataSource = barChartData;

            return View();
        }

        public IActionResult SearchResults()
        {
            return View();
        }

        public class ChartData
        {
            public string xValue;
            public double yValue;
        }

        public class PieChartData
        {
            public string xValue;
            public double yValue;
        }

        [HttpPost]
        public IActionResult Test(SearchParameters sp)
        {

            return RedirectToAction(nameof(SearchSelection));
        }
        
       

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(uint id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(uint id)
        {
            return _context.Employee.Any(e => e.EmployeeNumber == id);
        }
    }
}
