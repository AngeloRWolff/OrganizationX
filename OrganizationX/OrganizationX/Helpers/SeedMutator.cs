using OrganizationX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace OrganizationX.Helpers
{
    public class SeedMutator
    {
        public string SeedData { get; set; }
        public SeedOptions Options { get; set; }

        // Mutates Employee Seed Data Into Queue Type Of Employee Model
        public Queue<Employee> GetEmployees()
        {
            Queue<Employee> newEmployees = new Queue<Employee>();
            CharMapper charMap = new CharMapper();

            foreach(char character in SeedData)
            {
                if (character == '\n')
                {
                    newEmployees.Enqueue(Bind(charMap.Row));
                    charMap.ClearRow();
                }
                charMap.Append(character);
            }
            newEmployees.Enqueue(Bind(charMap.Row)); //EOF

            return newEmployees;
        }

        // Binds Row Of Data To Employee Model
        public Employee Bind(String row)
        {
            string[] col = row.Split(Options.CsvDelimeter);
            Employee employee = new Employee();
            PropertyInfo[] propertyInfo = typeof(Employee).GetProperties();
            int propertyIndex = 0;
            foreach (PropertyInfo property in propertyInfo)
            {
                if (property.Name != propertyInfo[0].Name)
                {
                    property.SetValue(employee, Convert.ChangeType(col[propertyIndex], property.PropertyType), null);
                    propertyIndex++;
                }
            }
            return employee;
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
