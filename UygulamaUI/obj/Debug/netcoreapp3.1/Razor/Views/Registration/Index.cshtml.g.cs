#pragma checksum "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ba8aea44e3ee208f0132d118b090afaddefdfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_Index), @"mvc.1.0.view", @"/Views/Registration/Index.cshtml")]
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
#line 1 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\_ViewImports.cshtml"
using UygulamaUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\_ViewImports.cshtml"
using UygulamaUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ba8aea44e3ee208f0132d118b090afaddefdfe", @"/Views/Registration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3948a4527c2784b3c457e340758cac077a39073b", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UygulamaUI.Models.RegisterBindingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
  
    ViewData["Title"] = "Kayıt";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"alert-danger text-white\">");
#nullable restore
#line 7 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
                                    Write(ViewData["Hata"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"kayit col-5 border\">\r\n");
#nullable restore
#line 10 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
             using (Html.BeginForm("Index", "Registration", FormMethod.Post))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label>Mail Adresiniz:</label>\r\n                    ");
#nullable restore
#line 15 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control", placeholder = "Mail adresinizi giriniz.." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Telefon Numaranız:</label>\r\n                    ");
#nullable restore
#line 20 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
               Write(Html.TextBoxFor(m => m.PhoneNumber, new { @class = "form-control", placeholder = "Telefon numaranızı giriniz.." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Şifreniz:</label>\r\n                    ");
#nullable restore
#line 25 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
               Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", placeholder = "Şifrenizi giriniz.." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 26 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Şifre Onay:</label>\r\n                    ");
#nullable restore
#line 30 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
               Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control", placeholder = "Tekrar şifrenizi giriniz.." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 31 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
               Write(Html.ValidationMessageFor(m => m.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""form-inline justify-content-between mb-1"">
                    <a class=""btn btn-warning"" href=""/Login/Index"">Geri Dön</a>
                    <button type=""submit"" class=""btn btn-success"">Tamamla</button>
                </div>
");
#nullable restore
#line 38 "C:\Users\MelinaAero\Documents\Github\BioEkran\UygulamaUI\Views\Registration\Index.cshtml"
                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UygulamaUI.Models.RegisterBindingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
