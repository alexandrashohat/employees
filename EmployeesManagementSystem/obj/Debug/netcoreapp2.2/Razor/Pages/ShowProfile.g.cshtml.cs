#pragma checksum "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7f15e2102ea5b1d77666bf7c8c80e2e5822da78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EmployeesManagementSystem.Pages.Pages_ShowProfile), @"mvc.1.0.razor-page", @"/Pages/ShowProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ShowProfile.cshtml", typeof(EmployeesManagementSystem.Pages.Pages_ShowProfile), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7f15e2102ea5b1d77666bf7c8c80e2e5822da78", @"/Pages/ShowProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82a9ebdbf2f64a7f22759eccb2cc3ae56e91d1a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ShowProfile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
  
    ViewData["Title"] = "ShowProfile";

#line default
#line hidden
            BeginContext(111, 107, true);
            WriteLiteral("\r\n<h1>Selected Customer Information</h1>\r\n<div>\r\n    <b style=\"padding-right:5px\">Customer name: </b><span>");
            EndContext();
            BeginContext(219, 27, false);
#line 9 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
                                                     Write(Model.selectedCustomer.name);

#line default
#line hidden
            EndContext();
            BeginContext(246, 81, true);
            WriteLiteral("</span>\r\n    <br />\r\n    <b style=\"padding-right:5px\">Customer number: </b><span>");
            EndContext();
            BeginContext(328, 37, false);
#line 11 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
                                                       Write(Model.selectedCustomer.customerNumber);

#line default
#line hidden
            EndContext();
            BeginContext(365, 56, true);
            WriteLiteral("</span>\r\n    <br />\r\n    <h3>Addresses</h3>\r\n    <div>\r\n");
            EndContext();
#line 15 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
         if (Model.selectedCustomer.addressCount == 0)
        {

#line default
#line hidden
            BeginContext(488, 39, true);
            WriteLiteral("            <span>No Addresses</span>\r\n");
            EndContext();
#line 18 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
        }
        else
        {
            foreach (var item in Model.selectedCustomer.addresses)
            {

#line default
#line hidden
            BeginContext(646, 108, true);
            WriteLiteral("                <div style=\"padding:5px\">\r\n                    <b style=\"padding-right:5px\">City: </b><span>");
            EndContext();
            BeginContext(755, 9, false);
#line 24 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
                                                            Write(item.city);

#line default
#line hidden
            EndContext();
            BeginContext(764, 104, true);
            WriteLiteral("</span>\r\n                    <br />\r\n                    <b style=\"padding-right:5px\">Street: </b><span>");
            EndContext();
            BeginContext(869, 11, false);
#line 26 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
                                                              Write(item.street);

#line default
#line hidden
            EndContext();
            BeginContext(880, 33, true);
            WriteLiteral("</span>\r\n                </div>\r\n");
            EndContext();
#line 28 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(939, 49, true);
            WriteLiteral("\r\n    </div>\r\n    <h3>Contancts</h3>\r\n    <div>\r\n");
            EndContext();
#line 34 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
         if (Model.selectedCustomer.contactCount == 0)
        {

#line default
#line hidden
            BeginContext(1055, 39, true);
            WriteLiteral("            <span>No Contancts</span>\r\n");
            EndContext();
#line 37 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
        }
        else
        {
            foreach (var item in Model.selectedCustomer.contacts)
            {

#line default
#line hidden
            BeginContext(1212, 114, true);
            WriteLiteral("                <div style=\" padding:5px\">\r\n                    <b style=\"padding-right:5px\">Full Name: </b><span>");
            EndContext();
            BeginContext(1327, 13, false);
#line 43 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
                                                                 Write(item.fullName);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 111, true);
            WriteLiteral("</span>\r\n                    <br />\r\n                    <b style=\"padding-right:5px\">Office Number: </b><span>");
            EndContext();
            BeginContext(1452, 17, false);
#line 45 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
                                                                     Write(item.officeNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1469, 103, true);
            WriteLiteral("</span>\r\n                    <br />\r\n                    <b style=\"padding-right:5px\">Email: </b><span>");
            EndContext();
            BeginContext(1573, 10, false);
#line 47 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
                                                             Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(1583, 33, true);
            WriteLiteral("</span>\r\n                </div>\r\n");
            EndContext();
#line 49 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\ShowProfile.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1642, 144, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-3 d-grid\">\r\n        <a class=\"btn btn-outline-primary\" href=\"/\">Go Back To List</a>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeesManagementSystem.Pages.ShowProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeesManagementSystem.Pages.ShowProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EmployeesManagementSystem.Pages.ShowProfileModel>)PageContext?.ViewData;
        public EmployeesManagementSystem.Pages.ShowProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591