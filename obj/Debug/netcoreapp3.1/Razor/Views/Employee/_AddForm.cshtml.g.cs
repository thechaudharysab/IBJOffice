#pragma checksum "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3875dc2dc1814c193309832f4474d5eca6ab7042"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee__AddForm), @"mvc.1.0.view", @"/Views/Employee/_AddForm.cshtml")]
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
#line 1 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\_ViewImports.cshtml"
using IBJOffice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\_ViewImports.cshtml"
using IBJOffice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3875dc2dc1814c193309832f4474d5eca6ab7042", @"/Views/Employee/_AddForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ed072de2d3e8125b11208c54247f9ebaafeb8d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee__AddForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
   
    Employee Employee = (Employee)ViewData["Employee"];
    string Title = (string)ViewData["Title"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <label style=\"font-weight:bold\">");
#nullable restore
#line 7 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
                               Write(Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
</div>
<div class=""pt-2 mb-2 employee_form"" style=""overflow:auto"">
    <table class=""table table-bordered table-sm table-striped table-bordered"">
        <thead>
            <tr style=""background-color:azure"">
                <td>Property</td>
                <td>Value</td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td style=""width: 100px"">First Name*</td>
                <td>
                    <input class=""form-control-sm w-100"" id=""first_name""");
            BeginWriteAttribute("value", " value=\"", 680, "\"", 707, 1);
#nullable restore
#line 21 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
WriteAttributeValue("", 688, Employee.FirstName, 688, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" autocomplete=\"off\" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td style=\"width: 100px\">Last Name*</td>\r\n                <td>\r\n                    <input class=\"form-control-sm w-100\" id=\"last_name\"");
            BeginWriteAttribute("value", " value=\"", 943, "\"", 969, 1);
#nullable restore
#line 27 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
WriteAttributeValue("", 951, Employee.LastName, 951, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" autocomplete=\"off\" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td style=\"width: 100px\">Position*</td>\r\n                <td>\r\n                    <input class=\"form-control-sm w-100\" id=\"position\"");
            BeginWriteAttribute("value", " value=\"", 1203, "\"", 1229, 1);
#nullable restore
#line 33 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
WriteAttributeValue("", 1211, Employee.Position, 1211, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" autocomplete=\"off\" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td style=\"width: 100px\">Department*</td>\r\n                <td>\r\n                    <input class=\"form-control-sm w-100\" id=\"department\"");
            BeginWriteAttribute("value", " value=\"", 1467, "\"", 1495, 1);
#nullable restore
#line 39 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
WriteAttributeValue("", 1475, Employee.Department, 1475, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" autocomplete=\"off\" list=\"departments\" />\r\n                    <datalist id=\"departments\">\r\n");
#nullable restore
#line 41 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
                         foreach (var dept in Enum.GetValues(typeof(Department)))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3875dc2dc1814c193309832f4474d5eca6ab70426790", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
                               WriteLiteral(dept);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </datalist>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td style=\"width: 100px\">Salary</td>\r\n                <td>\r\n                    <input class=\"form-control-sm w-100\" id=\"salary\"");
            BeginWriteAttribute("value", " value=\"", 2016, "\"", 2040, 1);
#nullable restore
#line 51 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
WriteAttributeValue("", 2024, Employee.Salary, 2024, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" autocomplete=\"off\" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td style=\"width: 100px\">Date Joined</td>\r\n                <td>\r\n                    <input class=\"form-control-sm w-100\" id=\"date_joined\"");
            BeginWriteAttribute("value", " value=\"", 2279, "\"", 2367, 1);
#nullable restore
#line 57 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
WriteAttributeValue("", 2287, Employee.DateJoined == DateTime.MinValue ? DateTime.Now : Employee.DateJoined, 2287, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" autocomplete=\"off\" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td style=\"width: 100px\">Last Changed</td>\r\n                <td>\r\n                    <input class=\"form-control-sm w-100\" id=\"last_changed\"");
            BeginWriteAttribute("value", " value=\"", 2608, "\"", 2629, 1);
#nullable restore
#line 63 "C:\Users\REG-LPT-061\source\repos\IBJOffice\Views\Employee\_AddForm.cshtml"
WriteAttributeValue("", 2616, DateTime.Now, 2616, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly=""readonly"" />
                </td>
            </tr>
        </tbody>
        <tfoot>
            <tr>
                <td colspan=""2"" style=""text-align:right"">

                    <button type=""button"" class=""btn btn-sm btn-outline-primary employee-form-save"" id=""save_form"">
                        <i class=""fa fa-floppy-o"" style=""margin-right:5px""></i>
                        Save
                    </button>

                    <button type=""button"" class=""btn btn-sm btn-outline-primary employee-form-close"" id=""close_form"">
                        <i class=""fa fa-close"" style=""margin-right:5px""></i>
                        Close
                    </button>
                </td>
            </tr>
        </tfoot>
    </table>
</div>");
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
