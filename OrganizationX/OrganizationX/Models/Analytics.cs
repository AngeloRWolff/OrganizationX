using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Models
{
    public class Analytics
    {
        public Insight Age { get; set; }

        public Insight Attrition { get; set; }

        public Insight BusinessTravel { get; set; }

        public Insight DailyRate { get; set; }

        public Insight Department { get; set; }

        public Insight DistanceFromHome { get; set; }

        public Insight Education { get; set; }

        public Insight EducationField { get; set; }

        public Insight EmployeeCount { get; set; }

        public Insight EmployeeNumber { get; set; }

        public Insight EnvironmentSatisfaction { get; set; }

        public Insight Gender { get; set; }

        public Insight HourlyRate { get; set; }

        public Insight JobInvolvement { get; set; }

        public Insight JobLevel { get; set; }

        public Insight JobRole { get; set; }

        public Insight JobSatisfaction { get; set; }

        public Insight MaritalStatus { get; set; }

        public Insight MonthlyIncome { get; set; }

        public Insight MonthlyRate { get; set; }

        public Insight NumCompaniesWorked { get; set; }

        public Insight OverTime { get; set; }

        public Insight PercentSalaryHike { get; set; }

        public Insight PerformanceRating { get; set; }

        public Insight RelationshipSatisfaction { get; set; }

        public Insight StandardHours { get; set; }

        public Insight StockInsightLevel { get; set; }

        public Insight TotalWorkingYears { get; set; }

        public Insight TrainingTimesLastYear { get; set; }

        public Insight WorkLifeBalance { get; set; }

        public Insight YearsAtCompany { get; set; }

        public Insight YearsInCurrentRole { get; set; }

        public Insight YearsSinceLastPromotion { get; set; }

        public Insight YearsWithCurrManager { get; set; }
    }

    public class Insight
    {
        public NumericInsight NumericInsight { get; set; }
        public AlphaInsight AlphaInsight { get; set; }
        public InsightType InsightType { get; set; }
      

    }
    public class NumericInsight
    {
        public int Max { get; set; } = int.MinValue;
        public int Min { get; set; } = int.MaxValue;
        public int Count { get; set; } = 0;
        public int Total { get; set; } = 0;
        public int Mode { get; set; }
        public Dictionary<int,int> Distribution { get; set; }
    }
    public class AlphaInsight
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
    public enum InsightType
    {
        NumericInsight,
        AlphaInsight
    }
}
