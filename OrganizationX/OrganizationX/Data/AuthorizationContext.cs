using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrganizationX.Models;

namespace OrganizationX.Data
{
    public class AuthorizationContext : DbContext
    {
        public AuthorizationContext (DbContextOptions<AuthorizationContext> options)
            : base(options)
        {
        }

        public DbSet<OrganizationX.Models.Authorization> Authorization { get; set; }
    }
}
