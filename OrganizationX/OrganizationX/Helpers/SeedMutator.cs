﻿using OrganizationX.Models;
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
        public int Size { get; set; } = 0;

        // Mutates Employee Seed Data Into Queue Type Of Employee Model
        public List<Employee> GetEmployees()
        {
            List<Employee> newEmployees = new List<Employee>();
            CharMapper charMap = new CharMapper();
            foreach (char character in SeedData)
            {
                if (character == '\n')
                {
                    if (Options.HasKeys == true && Size > 0)
                    {
                        newEmployees.Add(Bind(charMap.Row));
                    }
                    else
                    if (Options.HasKeys == false)
                    {
                        newEmployees.Add(Bind(charMap.Row));
                    }
                    Size++;

                    charMap.ClearRow();
                }
                charMap.Append(character);
            }
            
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

                property.SetValue(employee, Convert.ChangeType(col[propertyIndex], property.PropertyType), null);
                propertyIndex++;
            }

            return employee;

        }
        public List<Key> getKeys()
        {
            List<Key> employeeKeys = new List<Key>();
            PropertyInfo[] propertyInfo = typeof(Employee).GetProperties();
            foreach (var property in propertyInfo)
            {
                employeeKeys.Add(new Key { KeyName = property.Name });
            }
            return employeeKeys;
        }
    }


    public class SeedOptions
    {
        public bool HasKeys { get; set; }
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
}
