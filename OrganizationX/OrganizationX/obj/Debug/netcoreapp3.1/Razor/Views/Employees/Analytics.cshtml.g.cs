#pragma checksum "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\Analytics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c33b95f6f0a959871d714a2cb80e00561694f8ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Analytics), @"mvc.1.0.view", @"/Views/Employees/Analytics.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c33b95f6f0a959871d714a2cb80e00561694f8ee", @"/Views/Employees/Analytics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96679be2df49e4010ee7aca693dd30007da881e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Analytics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Analytics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\Analytics.cshtml"
  
    ViewData["Title"] = "Analytics";
    var keys = new Analytics().GetType().GetProperties();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""text-center"">
        <div class=""inline-block max-width"">
            <h3 class=""inline-block"">Employee Analytics</h3>
            <button class=""btn btn-primary inline-block"">Download Full Report</button>
        </div>
        <hr />
        <h4>Select Attribute To Analyze</h4>

");
#nullable restore
#line 15 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\Analytics.cshtml"
         foreach (var k in keys)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c33b95f6f0a959871d714a2cb80e00561694f8ee4746", async() => {
                WriteLiteral("\r\n                <input hidden");
                BeginWriteAttribute("value", " value=\"", 553, "\"", 568, 1);
#nullable restore
#line 18 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\Analytics.cshtml"
WriteAttributeValue("", 561, k.Name, 561, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Target\" />\r\n                <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 624, "\"", 639, 1);
#nullable restore
#line 19 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\Analytics.cshtml"
WriteAttributeValue("", 632, k.Name, 632, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-primary\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\Analytics.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n        <h3>Insights on ");
#nullable restore
#line 23 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\Analytics.cshtml"
                   Write(ViewBag.TargetName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        <div id=""chartContainer"" style=""height: 370px; width: 100%; z-index:-100;""></div>
        <div id=""chartContainer2"" style=""height: 370px; width: 100%;""></div>

        <script src=""https://canvasjs.com/assets/script/canvasjs.min.js""></script>
    </div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

                // this.document.getElementById('chartContainer').style.visibility = ""hidden"";
    window.onload = function () {

    var chart = new CanvasJS.Chart(""chartContainer"", {
	theme: ""light2"", // ""light1"", ""light2"", ""dark1"", ""dark2""
	animationEnabled: true,
    zoomEnabled: true,
    backgroundColor: ""rgba(0,0,0,0)"",
	title: {

        },
    axisY:{
        gridThickness: 0
      },
	data: [{
		type: ""line"",
		dataPoints: ");
#nullable restore
#line 52 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\Analytics.cshtml"
               Write(Html.Raw(ViewBag.DataPoints));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t}]\r\n    });\r\n        var g = ");
#nullable restore
#line 55 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\Analytics.cshtml"
           Write(Html.Raw(ViewBag.DataPoints));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        if (g.length > 0) {
             this.document.getElementById('chartContainer').style.display = ""block"";
            chart.render();
        }
        else {
            this.document.getElementById('chartContainer').style.display = ""none"";
        }

        var chart2 = new CanvasJS.Chart(""chartContainer2"", {
	theme: ""light2"", // ""light1"", ""light2"", ""dark1"", ""dark2""
	exportEnabled: true,
     animationEnabled: true,
      backgroundColor: ""rgba(0,0,0,0)"",
	title: {
		text: ""Automotive Semiconductor Vendors 2015"",
		fontSize: 21
	},
	data: [{
		type: ""pie"",
		startAngle: 160,
		toolTipContent: ""<b>{label}</b>: {y}%"",
		indexLabel: ""{label} - {y}%"",
		dataPoints: ");
#nullable restore
#line 78 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\Analytics.cshtml"
               Write(Html.Raw(ViewBag.DataPointsString));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t}]\r\n        });\r\n        var g = ");
#nullable restore
#line 81 "C:\OrganizationX\OrganizationX\OrganizationX\Views\Employees\Analytics.cshtml"
           Write(Html.Raw(ViewBag.DataPointsString));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n        if (g.length > 0)\r\n        chart2.render();\r\n}\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
