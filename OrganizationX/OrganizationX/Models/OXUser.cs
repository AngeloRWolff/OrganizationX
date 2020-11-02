using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Models
{
    public class OXUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string PasswordHash { get; set; }
        public RoleLevel RoleLevel { get; set; }
        public Permissions Permissions { get; set; }
    }

    public enum Permissions
    {
        Unrestricted,
        Read,
        Write,
        Delete,
        ReadWrite,
        ReadWriteDelete,
    }
}
