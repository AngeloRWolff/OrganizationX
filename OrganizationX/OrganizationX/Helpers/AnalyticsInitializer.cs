using OrganizationX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationX.Helpers
{
    public class AnalyticsInitializer
    {
        public Analytics Get()
        {
            Analytics analytics = new Analytics
            {
                Age = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),
                        
                    },
                    NumericInsight = new NumericInsight
                    {
                        Max=0,
                        Min= 0,
                        Distribution = new Dictionary<int, int>(),
                        Total =0,
                    },
                    InsightType = InsightType.Unset
                },
                Attrition = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                BusinessTravel = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                DailyRate = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                Department = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }
                ,
                DistanceFromHome = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                Education = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                EducationField = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),


                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                } ,
                EmployeeCount = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }
                ,
                EmployeeNumber = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                } ,
                EnvironmentSatisfaction = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),


                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }
                ,
                Gender = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }

                ,
                HourlyRate = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                JobInvolvement = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                JobLevel = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                JobRole = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                JobSatisfaction = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }
                ,
                MaritalStatus = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                MonthlyIncome = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }
                ,
                MonthlyRate = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }
                ,
                NumCompaniesWorked = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }
                ,
                OverTime = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                PercentSalaryHike = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }
                ,
                PerformanceRating = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }
                ,
                RelationshipSatisfaction = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                StandardHours = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                StockInsightLevel = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                TotalWorkingYears = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                TrainingTimesLastYear = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                WorkLifeBalance = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                YearsAtCompany = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                YearsInCurrentRole = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                },
                YearsSinceLastPromotion = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }
                ,
                YearsWithCurrManager = new Insight
                {
                    AlphaInsight = new AlphaInsight
                    {
                        AlphaPairs = new Dictionary<string, int>(),

                    },
                    NumericInsight = new NumericInsight
                    {
                        Max = 0,
                        Min = 0,
                        Distribution = new Dictionary<int, int>(),
                        Total = 0,
                    },
                    InsightType = InsightType.Unset
                }

            };

            return analytics;
        }
    }
}
