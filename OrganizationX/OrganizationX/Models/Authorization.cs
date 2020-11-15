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

        public string CreatedBy { get; set; }

        public string Department { get; set; }

        public string Token { get; set; }

        public DateTime TokenExpireDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public TokenStatus TokenStatus { get; set; }

    }

    public enum RoleLevel
    {
        Level0 = 0, //Unresitricted Access
        Level1 = 1, //Create/Read/Update/Delete
        Level2 = 2, //Read/Update
        Level3 = 3, //Read
    }


    public enum TokenStatus
    {
        Pending,
        Consumed,
        Expired
    }


}
