using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Models
{
    public class Employee
    {
        [Required]
        public uint Age { get; set; }

        [Required]
        public string Attrition { get; set; }
        
        [Required]       
        public string BusinessTravel { get; set; }

        [Required]
        public uint DailyRate { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public uint DistanceFromHome { get; set; }

        [Required]
        public uint Education { get; set; }

        [Required]
        public string EducationField { get; set; }

        [Required]
        public uint EmployeeCount { get; set; }

        [Required]
        public uint EmployeeNumber { get; set; }

        [Required]
        public uint EnvironmentSatisfaction { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public uint HourlyRate { get; set; }

        [Required]
        public uint JobInvolvement { get; set; }

        [Required]
        public uint JobLevel { get; set; }

        [Required]
        public string JobRole { get; set; }

        [Required]
        public uint JobSatisfaction { get; set; }

        [Required]
        public string MaritalStatus { get; set; }

        [Required]
        public uint MonthlyIncome { get; set; }

        [Required]
        public uint MonthlyRate { get; set; }

        [Required]
        public uint NumCompaniesWorked { get; set; }

        [Required]
        public string Over18 { get; set; }

        [Required]
        public string OverTime { get; set; }

        [Required]
        public uint PercentSalaryHike { get; set; }

        [Required]
        public uint PerformanceRating { get; set; }

        [Required]
        public uint RelationshipSatisfaction { get; set; }

        [Required]
        public uint StandardHours { get; set; }

        [Required]
        public uint StockOptionLevel { get; set; }

        [Required]
        public uint TotalWorkingYears { get; set; }

        [Required]
        public uint TrainingTimesLastYear { get; set; }

        [Required]
        public uint WorkLifeBalance { get; set; }

        [Required]
        public uint YearsAtCompany { get; set; }

        [Required]
        public uint YearsInCurrentRole { get; set; }

        [Required]
        public uint YearsSinceLastPromotion { get; set; }

        [Required]
        public uint YearsWithCurrManager { get; set; }
    }
}
