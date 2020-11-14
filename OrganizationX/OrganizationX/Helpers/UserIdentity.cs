using OrganizationX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Helpers
{
    public class UserIdentity
    {
        private string UserName { get; set; }
        private string Email { get; set; }
        private string Department { get; set; }

        public UserIdentity(AuthorizationContext authorization, OXUserContext oXUser, string Username)
        {
            var employee = oXUser.OXUser
               .First(m => m.Username == Username);
            Console.WriteLine(employee.PhoneNumber);
        }
    }

   
}
