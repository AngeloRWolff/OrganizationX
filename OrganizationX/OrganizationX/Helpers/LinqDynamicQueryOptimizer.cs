using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OrganizationX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Helpers
{
    public class LinqDynamicQueryOptimizer 
    {
        List<string> queryBlocks = new List<string>();


       

        public void AddExactInt(string property, int[] @values)
        {
            String exactIntegerQuery = String.Empty;
            for (int i = 0; i < values.Length; i++)
            {
               // Console.WriteLine($"{property} = \"{values[i]}\"");                        
                    if (i == 0)
                    {
                        exactIntegerQuery += ($"({property} = {values[i]}");
                    }
                    else
                    {
                        exactIntegerQuery += ($" OR {property} = {values[i]}");
                    }            
            }
            if (exactIntegerQuery != "")
            {
                queryBlocks.Add(exactIntegerQuery + ") ");
            }
        }
        public void AddExactString(string property, string[] @values)
        {
            String exactStringQuery = String.Empty;
            for (int i = 0; i < values.Length; i++)
            {
                //Console.WriteLine($"{property} = \"{values[i]}\"");
                if (values[i] != null)
                {
                    if (values[i].Trim() != "")
                    {
                        if (i == 0)
                        {
                            exactStringQuery += ($" ({property} = \"{values[i]}\"");
                        }
                        else
                        {
                            exactStringQuery += ($" OR {property} = \"{values[i]}\" ");
                        }
                    }
                }
            }
            if (exactStringQuery != "")
            {
                queryBlocks.Add(exactStringQuery + ") ");
            }
        }

        public void AddRange(string property, IntegerRange @values)
        {
            if (values.Max >= values.Min && values.Max != -1 && values.Min != -1)
            {
                queryBlocks.Add($" {property} >= {values.Min} AND {property} <= {values.Max}");
            }
        }

        public void AddRelation(string property, RelationCondition @values)
        {
           // Console.WriteLine("RelationChecked");
            queryBlocks.Add($"{property} {values.Relation.AsciiCode} {values.Value} ");
        }

        public string GetQuery()
        {
            string query = string.Empty;
            for (int i = 0; i < queryBlocks.Count-1; i++)
            {
                query += $"{queryBlocks[i]} AND ";
            }
            query += $" {queryBlocks[queryBlocks.Count-1]} ";

            return query;
        }
    }

   
    public class Operator
    {
        
    }
    public class DataType
    {
        
    }

    public class Query
    {
        
    }

}
