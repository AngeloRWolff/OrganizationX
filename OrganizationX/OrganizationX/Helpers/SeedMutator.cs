using OrganizationX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Helpers
{
    public class SeedMutator
    {
        public string SeedData { get; set; }
        public SeedOptions Options { get; set; }

        public Queue<Employee> GetEmployees()
        {
            Queue<Employee> newEmployees = new Queue<Employee>();

            return newEmployees;
        }
    }
}

public class SeedOptions
{
    public bool Keyless { get; set; }
    public char CsvDelimeter { get; set; } = ','; //As defualt 
}

public class CharMapper
{
    public string Row { get; set; } = String.Empty;

    public void ClearRow()
    {
        Row = String.Empty;
    }

    public void Append(char character)
    {
        Row += character;
    }
}
