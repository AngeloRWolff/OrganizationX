using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Models
{
    public class Authorization
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public int RolePolicy { get; set; }

        [Phone]
        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Token { get; set; }

        public DateTime TokenExpirationDate { get; set; }

        public DateTime CreationTime { get; set; }

        public int CreatedBy { get; set; }
    }

  
}
