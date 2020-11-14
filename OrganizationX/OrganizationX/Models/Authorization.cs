using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Models
{
    public class Authorization
    {

        public int Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public RoleLevel Role { get; set; }

        public string Department { get; set; }

        public string Token { get; set; }

        public DateTime TokenExpireDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public TokenStatus TokenStatus { get; set; }

    }

    public enum RoleLevel
    {
        Level0,
        Level1,
        Level2,
        Level3,
    }


    public enum TokenStatus
    {
        Pending,
        Consumed,
        Expired
    }


}
