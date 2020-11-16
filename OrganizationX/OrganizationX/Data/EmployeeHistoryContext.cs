using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrganizationX.Models;

namespace OrganizationX.Data
{
    public class EmployeeHistoryContext : DbContext
    {
        public EmployeeHistoryContext (DbContextOptions<EmployeeHistoryContext> options)
            : base(options)
        {
        }

        public DbSet<OrganizationX.Models.EmployeeHistory> EmployeeHistory { get; set; }
    }
}
