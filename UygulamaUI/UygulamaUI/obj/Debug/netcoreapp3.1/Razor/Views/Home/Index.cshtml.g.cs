#pragma checksum "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\UygulamaUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2b14464ec1639928ad7574c6b13620823b423cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\UygulamaUI\Views\_ViewImports.cshtml"
using UygulamaUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\UygulamaUI\Views\Home\Index.cshtml"
using UygulamaUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2b14464ec1639928ad7574c6b13620823b423cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3948a4527c2784b3c457e340758cac077a39073b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SelectList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\UygulamaUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Anasayfa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">


    <div class=""row justify-content-end m-3"">
        <div class=""col-9"">
            <a class=""btn btn-info mr-3"" href=""/Login/Index"">Düzenle</a>
            <a class=""btn btn-danger"" href=""/Login/Index"">Çıkış Yap</a>
        </div>
        

    </div>

    <div class=""row justify-content-center"">

        <div class=""col-3 border"">
            ");
#nullable restore
#line 23 "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\UygulamaUI\Views\Home\Index.cshtml"
       Write(Html.DropDownList("ddlCihazlar", Model, "Cihaz Seçin"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        </div>\r\n\r\n        <div class=\"col-6 border ml-5\">\r\n            <p>Grafik yeri</p>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SelectList> Html { get; private set; }
    }
}
#pragma warning restore 1591
