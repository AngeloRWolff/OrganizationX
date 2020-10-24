using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Models
{
    public class SeedDataProperties
    {
        public Queue<Employee> Employees { get; set; }
      
        public int TotalRecords { get; set; }

        //Psuedo - In process
        public List<Key> MissingKeys { get; set; }
        public List<EmployeeConflicts> Conflicts { get; set; }
    }

    public class Key
    {
        public string KeyName { get; set; }
    }

    public class EmployeeConflicts
    {
        public Employee originEmployee;
        public Employee conflictEmployee;
    }
}
