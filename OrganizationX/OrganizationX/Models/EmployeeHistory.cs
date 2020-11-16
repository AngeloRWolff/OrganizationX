using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Models
{
    public class EmployeeHistory
    {
        public int Id { get; set; }

        public int TargetId { get; set; }

        public string Author { get; set; }

        public DateTime ModifiedDate { get; set; }

       
    }
}
