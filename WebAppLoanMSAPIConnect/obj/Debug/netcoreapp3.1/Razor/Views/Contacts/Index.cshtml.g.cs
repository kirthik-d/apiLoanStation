#pragma checksum "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "746b2e5b154905bee8edf0b22a0d4a479386b028"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Index), @"mvc.1.0.view", @"/Views/Contacts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"746b2e5b154905bee8edf0b22a0d4a479386b028", @"/Views/Contacts/Index.cshtml")]
    #nullable restore
    public class Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContactWebAPI.Models.Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Full_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Full_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 973, "\"", 996, 1);
#nullable restore
#line 40 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
WriteAttributeValue("", 988, item.Id, 988, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1049, "\"", 1072, 1);
#nullable restore
#line 41 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
WriteAttributeValue("", 1064, item.Id, 1064, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1127, "\"", 1150, 1);
#nullable restore
#line 42 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
WriteAttributeValue("", 1142, item.Id, 1142, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\kirth\Desktop\WebAppLoanMSAPIConnect (3)\WebAppLoanMSAPIConnect\WebAppLoanMSAPIConnect\Views\Contacts\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContactWebAPI.Models.Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
