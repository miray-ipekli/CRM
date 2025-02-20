#pragma checksum "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b35580ea194bb3cc3d1b20df39af1810a4091aee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
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
#line 2 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35580ea194bb3cc3d1b20df39af1810a4091aee", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"541ca7789747cb7c5f2df6d9f44a148e708263dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EmployeeTask>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Görevler</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Görev</th>\r\n        <th>Görevli Çalışan</th>\r\n        <th>Görev Durumu</th>\r\n        <th>Görev Durumunu Güncelle</th>\r\n        <th>Detay</th>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
           Write(item.TaskId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"task-cell\">\r\n                <a href=\"#\" data-toggle=\"modal\" data-target=\"#taskModal\" data-task=\"");
#nullable restore
#line 26 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                                                                               Write(item.Task);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-task-description=\"");
#nullable restore
#line 26 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                                                                                                                  Write(item.TaskDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
               Write(item.Task);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
           Write(item.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                              Write(item.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
           Write(item.TaskStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 32 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
             if (ViewBag.user == item.AppUser.Id)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                 if (item.TaskStatus == "Yeni Görev")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td> <center> <a");
            BeginWriteAttribute("href", " href=\"", 1161, "\"", 1220, 4);
            WriteAttributeValue("", 1168, "/Task/UpdateTask/", 1168, 17, true);
#nullable restore
#line 36 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
WriteAttributeValue("", 1185, item.TaskId, 1185, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1197, "?status=Göreve", 1197, 14, true);
            WriteAttributeValue(" ", 1211, "Başlandı", 1212, 9, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Göreve Başladım</a> </center> </td>\r\n");
#nullable restore
#line 37 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                }
                else if (item.TaskStatus == "Devam Ediyor")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td> <center> <a");
            BeginWriteAttribute("href", " href=\"", 1418, "\"", 1472, 3);
            WriteAttributeValue("", 1425, "/Task/UpdateTask/", 1425, 17, true);
#nullable restore
#line 40 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
WriteAttributeValue("", 1442, item.TaskId, 1442, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1454, "?status=Tamamlandı", 1454, 18, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Görevi Tamamladım</a> </center> </td>\r\n");
#nullable restore
#line 41 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                }
                else if (item.TaskStatus == "Görev Tamamlandı")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><p style=\"text-align:center;\">");
#nullable restore
#line 44 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                                                 Write(item.CompletionDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 45 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                 
            }
            else
            {
                if (item.AppUser.Status != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><p style=\"text-align:center; font-weight:bold; color:#b2b2b2;\">Bu kullanıcı aktif değil.</p></td>\r\n");
#nullable restore
#line 52 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td><p style=\"text-align:center; font-weight:bold;\">Görev size ait değil.</p></td>\r\n");
#nullable restore
#line 56 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                }        
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td> <center> <a href=\"#\" data-toggle=\"modal\" data-target=\"#taskModal\" data-task=\"");
#nullable restore
#line 58 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                                                                                         Write(item.Task);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-task-description=\"");
#nullable restore
#line 58 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
                                                                                                                            Write(item.TaskDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-outline-info\" >Detay</a></center> </td>\r\n        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 62 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
 if (SignInManager.Context.User.IsInRole("Yönetici"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/Task/AddTask\" class=\"btn btn-primary\" style=\"float:right\">Yeni Görev Ekle</a>\r\n");
#nullable restore
#line 65 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"pull-left\">\r\n    ");
#nullable restore
#line 67 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Task\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index",new{page}),
    new PagedListRenderOptionsBase
    {
    LiElementClasses = new string[] { "page-item" },
    PageClasses = new string[] { "page-link" },
    Display = PagedListDisplayMode.IfNeeded

    }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>



<!-- Modal bileşeni -->
<div class=""modal fade"" id=""taskModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""taskModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""taskModalLabel""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p id=""modal-task-description""></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
            </div>
        </div>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EmployeeTask>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
