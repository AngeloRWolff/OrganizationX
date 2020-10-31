using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Models
{
    public class SearchParameters 
    {
        
        public Option Age { get; set; }

        public Option Attrition { get; set; }

        public Option BusinessTravel { get; set; }

        public Option DailyRate { get; set; }

        public Option Department { get; set; }

        public Option DistanceFromHome { get; set; }
        
        public Option Education { get; set; }
        
        public Option EducationField { get; set; }
        
        public Option EmployeeCount { get; set; }
        
        public Option EmployeeNumber { get; set; }
        
        public Option EnvironmentSatisfaction { get; set; }
        
        public Option Gender { get; set; }
        
        public Option HourlyRate { get; set; }
        
        public Option JobInvolvement { get; set; }
        
        public Option JobLevel { get; set; }
        
        public Option JobRole { get; set; }
        
        public Option JobSatisfaction { get; set; }
        
        public Option MaritalStatus { get; set; }
        
        public Option MonthlyIncome { get; set; }
        
        public Option MonthlyRate { get; set; }
        
        public Option NumCompaniesWorked { get; set; }
        
        public Option Over18 { get; set; }
        
        public Option OverTime { get; set; }
        
        public Option PercentSalaryHike { get; set; }
        
        public Option PerformanceRating { get; set; }
        
        public Option RelationshipSatisfaction { get; set; }
        
        public Option StandardHours { get; set; }
        
        public Option StockOptionLevel { get; set; }
        
        public Option TotalWorkingYears { get; set; }
        
        public Option TrainingTimesLastYear { get; set; }
        
        public Option WorkLifeBalance { get; set; }
        
        public Option YearsAtCompany { get; set; }
        
        public Option YearsInCurrentRole { get; set; }
        
        public Option YearsSinceLastPromotion { get; set; }
        
        public Option YearsWithCurrManager { get; set; }
    }

    public class Option
    {
        public string[] Exact { get; set; }

        public IntegerRange Range { get; set; }

        public RelationCondition Relation { get; set; }

        public OptionType OptionType { get; set; } = OptionType.None;
    }

    public class IntegerRange
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class RelationCondition
    {
        public RelationType Relation { get; set; }
        public int Value { get; set; }
    }

    
    public class RelationType
    {
        public string Title { get; set; }
        public string HtmlCode { get; set; }
        public string AsciiCode { get; set; }
    }

    public enum OptionType
    {
        Exact,
        Range,
        Relation,
        None
    }
 
}
