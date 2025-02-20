#pragma checksum "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "724f78f677941e3a4d861db654035c4cfc52447c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\_ViewImports.cshtml"
using CRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\_ViewImports.cshtml"
using CRM.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"724f78f677941e3a4d861db654035c4cfc52447c", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"541ca7789747cb7c5f2df6d9f44a148e708263dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Çalışanlar</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Ad Soyad</th>\r\n        <th>E-Posta</th>\r\n        <th>Telefon</th>\r\n");
#nullable restore
#line 18 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
          if (SignInManager.Context.User.IsInRole("Yönetici"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>Çalışan Durumu</th>\r\n");
#nullable restore
#line 21 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n");
#nullable restore
#line 23 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
                      Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 30 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
             if (SignInManager.Context.User.IsInRole("Yönetici"))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
                 if (item.Status == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td> <center> <a");
            BeginWriteAttribute("href", " href=\"", 968, "\"", 1017, 3);
            WriteAttributeValue("", 975, "/Employee/UpdateEmployee/", 975, 25, true);
#nullable restore
#line 34 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1000, item.Id, 1000, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1008, "?status=1", 1008, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Pasifleştir</a> </center> </td>\r\n");
#nullable restore
#line 35 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
                }
                else 
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td> <center> <a");
            BeginWriteAttribute("href", " href=\"", 1180, "\"", 1229, 3);
            WriteAttributeValue("", 1187, "/Employee/UpdateEmployee/", 1187, 25, true);
#nullable restore
#line 38 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1212, item.Id, 1212, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1220, "?status=0", 1220, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Aktifleştir</a> </center> </td>\r\n");
#nullable restore
#line 39 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 44 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
 if (SignInManager.Context.User.IsInRole("Yönetici"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/Employee/AddEmployee\" class=\"btn btn-primary\" style=\"float:right\">Yeni Çalışan Ekle</a>\r\n");
#nullable restore
#line 47 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"pull-left\">\r\n    ");
#nullable restore
#line 50 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Employee\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index",
    new
    {
    page

    }),
    new PagedListRenderOptionsBase
    {
    LiElementClasses = new string[] { "page-item" },
    PageClasses = new string[] { "page-link" },
    Display = PagedListDisplayMode.IfNeeded

    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
