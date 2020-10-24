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
    }
}

public class SeedOptions
{
    public bool Keyless { get; set; }
    public char CsvDelimeter { get; set; } = ','; //As defualt 
}
