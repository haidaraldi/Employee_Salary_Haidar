#pragma checksum "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa0fb2508e806f86dad4d78ce53b845d47670fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payrolls_Details), @"mvc.1.0.view", @"/Views/Payrolls/Details.cshtml")]
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
#line 1 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\_ViewImports.cshtml"
using Employee_Salary_Haidar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\_ViewImports.cshtml"
using Employee_Salary_Haidar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa0fb2508e806f86dad4d78ce53b845d47670fe", @"/Views/Payrolls/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea56b232801c814406d4ac9f23f00955c37fcbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Payrolls_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee_Salary_Haidar.ViewModel.PayrollsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Payroll</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
#nullable restore
#line 13 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
             if (item.EmployeeType == "Regular")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 18 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.Period));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 21 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Period));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 24 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 27 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 30 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.EmployeeType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 33 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmployeeType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 36 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 39 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 42 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.TIN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 45 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.TIN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 48 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.Absences));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 51 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Absences));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 54 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.SalaryTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 57 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.SalaryTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 59 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 64 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.Period));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 67 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Period));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 70 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 73 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 76 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.EmployeeType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 79 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmployeeType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 82 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 85 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 88 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.TIN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 91 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.TIN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 94 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.WorkDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 97 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.WorkDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 100 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => item.SalaryTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 103 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.SalaryTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 105 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "D:\Sprout Solutions\Employee_Salary_Haidar\Employee_Salary_Haidar\Views\Payrolls\Details.cshtml"
             

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dl>\r\n</div>\r\n<div>    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa0fb2508e806f86dad4d78ce53b845d47670fe15464", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee_Salary_Haidar.ViewModel.PayrollsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
