#pragma checksum "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b1f03c696aee53af8a7019857c9eb9d154165eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_UpdateCustomer), @"mvc.1.0.view", @"/Views/Customer/UpdateCustomer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1f03c696aee53af8a7019857c9eb9d154165eb", @"/Views/Customer/UpdateCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"541ca7789747cb7c5f2df6d9f44a148e708263dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_UpdateCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
  
    ViewData["Title"] = "UpdateCustomer";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Müşteri Bilgilerini Güncelle</h1>\r\n");
#nullable restore
#line 9 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
 using (Html.BeginForm("UpdateCustomer", "Customer", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b1f03c696aee53af8a7019857c9eb9d154165eb4520", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 11 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 14 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.Label("Müşteri Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.TextBoxFor(x=>x.CustomerName, new{@class="form-control",  @readonly = "readonly"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.ValidationMessageFor(x => x.CustomerName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 20 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.Label("Müşteri Soyadı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.TextBoxFor(x=>x.CustomerSurname, new{@class="form-control",  @readonly = "readonly"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.ValidationMessageFor(x => x.CustomerSurname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 26 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.Label("Müşteri Maili"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 27 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.TextBoxFor(x=>x.CustomerEmail, new{@class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.ValidationMessageFor(x => x.CustomerEmail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 32 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.Label("Müşteri Telefonu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.TextBoxFor(x=>x.CustomerPhone, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.ValidationMessageFor(x => x.CustomerPhone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 38 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.Label("Müşteri Adresi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 39 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.TextAreaFor(x => x.CustomerAdress, new { @class = "form-control", rows = 4 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 40 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"
   Write(Html.ValidationMessageFor(x => x.CustomerAdress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button class=\"btn btn-primary\">Bilgilerimi Güncelle</button>\r\n");
#nullable restore
#line 44 "C:\Users\miray.ipekli\source\repos\CRM\CRM\Views\Customer\UpdateCustomer.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
