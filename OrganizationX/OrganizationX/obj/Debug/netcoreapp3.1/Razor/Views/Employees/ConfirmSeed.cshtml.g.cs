#pragma checksum "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d7615c24c743706c93a6d6224b20e7676e67356"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_ConfirmSeed), @"mvc.1.0.view", @"/Views/Employees/ConfirmSeed.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\OrganizationX\OrganizationX\OrganizationX\Views\_ViewImports.cshtml"
using OrganizationX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OrganizationX\OrganizationX\OrganizationX\Views\_ViewImports.cshtml"
using OrganizationX.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d7615c24c743706c93a6d6224b20e7676e67356", @"/Views/Employees/ConfirmSeed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aadd68e63806b8d98c6fab6f0a576c24b7f095a", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_ConfirmSeed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrganizationX.Models.SeedDataProperties>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
  
    ViewData["Title"] = "ConfirmSeed";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
Write(Model.EmployeeQueue.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ConfirmSeed</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
 using (Html.BeginForm("SubmitSeed", "Employees", Model, FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button>Submit</button>\r\n");
#nullable restore
#line 12 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<font size=\"2\">\r\n    <table>\r\n        <thead>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 19 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
             foreach (var item in Model.EmployeeQueue)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 23 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 26 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 29 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 80 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 83 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 86 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 89 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 92 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 95 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 98 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 101 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 104 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 107 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 110 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 113 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 116 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 119 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 122 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
                   Write(Html.DisplayFor(modelItem => item.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 125 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</font>\r\n\r\n");
#nullable restore
#line 130 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\ConfirmSeed.cshtml"
Write(Model.EmployeeQueue.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrganizationX.Models.SeedDataProperties> Html { get; private set; }
    }
}
#pragma warning restore 1591
