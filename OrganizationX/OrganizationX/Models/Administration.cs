using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Models
{
    public class Administration
    {
        [Key]
        public int Id { get; set; }

        public String Username { get; set; }

        public String PasswordHash { get; set; }

        [EmailAddress]
        public String Email { get; set; }
    }
}
