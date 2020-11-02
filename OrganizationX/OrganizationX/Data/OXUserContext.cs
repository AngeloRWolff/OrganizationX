using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrganizationX.Models;

namespace OrganizationX.Data
{
    public class OXUserContext : DbContext
    {
        public OXUserContext (DbContextOptions<OXUserContext> options)
            : base(options)
        {
        }

        public DbSet<OrganizationX.Models.OXUser> OXUser { get; set; }
    }
}
