#pragma checksum "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b3aeaf1047ac755d0aaa5a286cd3a6b762382a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EmployeesManagementSystem.Pages.Pages_contact), @"mvc.1.0.razor-page", @"/Pages/contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/contact.cshtml", typeof(EmployeesManagementSystem.Pages.Pages_contact), null)]
namespace EmployeesManagementSystem.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\_ViewImports.cshtml"
using EmployeesManagementSystem;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b3aeaf1047ac755d0aaa5a286cd3a6b762382a0", @"/Pages/contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82a9ebdbf2f64a7f22759eccb2cc3ae56e91d1a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\contact.cshtml"
  
    ViewData["Title"] = "contact";

#line default
#line hidden
            BeginContext(103, 26, true);
            WriteLiteral("\r\n<h1>add a contact</h1>\r\n");
            EndContext();
#line 8 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\contact.cshtml"
 if (Model.errorMessage.Length > 0)
{

#line default
#line hidden
            BeginContext(169, 96, true);
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissible fase show\" role=\"alert\">\r\n        <strong>");
            EndContext();
            BeginContext(266, 18, false);
#line 11 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\contact.cshtml"
           Write(Model.errorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(284, 23, true);
            WriteLiteral("</strong>\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\contact.cshtml"
}

#line default
#line hidden
            BeginContext(310, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(314, 1751, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b3aeaf1047ac755d0aaa5a286cd3a6b762382a04812", async() => {
                BeginContext(334, 214, true);
                WriteLiteral("\r\n        <div class=\"row mb-3\">\r\n            <label class=\"col-sm-3 col-form-label\">contact name</label>\r\n            <div class=\"col-sm-6\">\r\n                <input type=\"text\" class=\"form-control\" name=\"fullName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 548, "\"", 579, 1);
#line 18 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\contact.cshtml"
WriteAttributeValue("", 556, Model.contact.fullName, 556, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(580, 258, true);
                WriteLiteral(@" />
            </div>
        </div>
        <div class=""row mb-3"">
            <label class=""col-sm-3 col-form-label"">office number</label>
            <div class=""col-sm-6"">
                <input type=""text"" class=""form-control"" name=""officeNumber""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 838, "\"", 873, 1);
#line 24 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\contact.cshtml"
WriteAttributeValue("", 846, Model.contact.officeNumber, 846, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(874, 276, true);
                WriteLiteral(@" />
            </div>
        </div>
        <div class=""row mb-3"">
            <label class=""col-sm-3 col-form-label"">email</label>
            <div class=""col-sm-6"">
                <input type=""text"" required title=""9 chars exactly"" class=""form-control"" name=""email""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1150, "\"", 1178, 1);
#line 30 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\contact.cshtml"
WriteAttributeValue("", 1158, Model.contact.email, 1158, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1179, 43, true);
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n\r\n");
                EndContext();
#line 34 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\contact.cshtml"
         if (Model.successMessage.Length > 0)
        {

#line default
#line hidden
                BeginContext(1280, 204, true);
                WriteLiteral("            <div class=\"row mb-3\">\r\n                <div class=\"col-sm-9\">\r\n                    <div class=\"alert alert-success alert-dismissible fase show\" role=\"alert\">\r\n                        <strong>");
                EndContext();
                BeginContext(1485, 20, false);
#line 39 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\contact.cshtml"
                           Write(Model.successMessage);

#line default
#line hidden
                EndContext();
                BeginContext(1505, 201, true);
                WriteLiteral("</strong>\r\n                        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"close\"></button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 44 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\contact.cshtml"
        }

#line default
#line hidden
                BeginContext(1717, 341, true);
                WriteLiteral(@"        <div class=""row mb-3"">
            <div class=""offset-sm-3 col-sm-3 d-grid"">
                <button type=""submit"" class=""btn btn-primary"">Submit</button>
            </div>
            <div class=""col-sm-3 d-grid"">
                <a class=""btn btn-outline-primary"" href=""/"">Cancel</a>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2065, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeesManagementSystem.Pages.contactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeesManagementSystem.Pages.contactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeesManagementSystem.Pages.contactModel>)PageContext?.ViewData;
        public EmployeesManagementSystem.Pages.contactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
