#pragma checksum "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3f9f83db2bb57bdd3982252751346e783a15af0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EmployeesManagementSystem.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(EmployeesManagementSystem.Pages.Pages_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3f9f83db2bb57bdd3982252751346e783a15af0", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82a9ebdbf2f64a7f22759eccb2cc3ae56e91d1a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 515, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <div><a class=""btn btn-primary"" href=""/add"">Add a new customer</a></div>
    <br />
    <br />
    <table style=""border:1px solid gray;padding: 5px"">
        <thead>
            <tr style=""border:1px solid gray;padding: 5px"">
                <th style=""padding: 10px"">customer name</th>
                <th style=""padding: 10px"">customer id</th>
                <th>actions</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\Index.cshtml"
             foreach (var item in Model.Customers)
            {

#line default
#line hidden
            BeginContext(653, 62, true);
            WriteLiteral("                <tr style=\"border:1px solid gray;padding: 5px\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 715, "\"", 766, 5);
            WriteAttributeValue("", 725, "location.href", 725, 13, true);
            WriteAttributeValue(" ", 738, "=", 739, 2, true);
            WriteAttributeValue(" ", 740, "\'ShowProfile?id=", 741, 17, true);
#line 23 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\Index.cshtml"
WriteAttributeValue("", 757, item.id, 757, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 765, "\'", 765, 1, true);
            EndWriteAttribute();
            BeginContext(767, 118, true);
            WriteLiteral(">                    \r\n                    <td style=\"padding: 5px;cursor:pointer\" title=\"CLICK for more information\">");
            EndContext();
            BeginContext(886, 9, false);
#line 24 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\Index.cshtml"
                                                                                          Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(895, 102, true);
            WriteLiteral("</td>\r\n                    <td style=\"padding: 5px;cursor:pointer\" title=\"CLICK for more information\">");
            EndContext();
            BeginContext(998, 19, false);
#line 25 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\Index.cshtml"
                                                                                          Write(item.customerNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 133, true);
            WriteLiteral("</td>\r\n                    <td style=\"padding: 15px\">\r\n\r\n                        <a style=\"padding-right:5px\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1150, "\"", 1174, 2);
            WriteAttributeValue("", 1157, "/edit?id=", 1157, 9, true);
#line 28 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\Index.cshtml"
WriteAttributeValue("", 1166, item.id, 1166, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1175, 96, true);
            WriteLiteral(">edit customer</a>\r\n                        <a style=\"padding-right:5px\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1271, "\"", 1298, 2);
            WriteAttributeValue("", 1278, "/contact?id=", 1278, 12, true);
#line 29 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\Index.cshtml"
WriteAttributeValue("", 1290, item.id, 1290, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1299, 94, true);
            WriteLiteral(">add contact</a>\r\n                        <a style=\"padding-right:5px\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1393, "\"", 1420, 2);
            WriteAttributeValue("", 1400, "/address?id=", 1400, 12, true);
#line 30 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\Index.cshtml"
WriteAttributeValue("", 1412, item.id, 1412, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1421, 68, true);
            WriteLiteral(">add address</a>\r\n                        <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1489, "\"", 1515, 2);
            WriteAttributeValue("", 1496, "/delete?id=", 1496, 11, true);
#line 31 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\Index.cshtml"
WriteAttributeValue("", 1507, item.id, 1507, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1516, 63, true);
            WriteLiteral(">remove</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "C:\Users\sasha\source\repos\EmployeesManagementSystem\EmployeesManagementSystem\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1594, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
