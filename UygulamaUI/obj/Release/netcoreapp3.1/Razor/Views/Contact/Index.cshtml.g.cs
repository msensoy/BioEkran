#pragma checksum "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "110ce4272ab964c16ab9b4a06b522e57ef1463b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\Views\_ViewImports.cshtml"
using UygulamaUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\Views\_ViewImports.cshtml"
using UygulamaUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"110ce4272ab964c16ab9b4a06b522e57ef1463b9", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3948a4527c2784b3c457e340758cac077a39073b", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\Views\Contact\Index.cshtml"
Write(Html.Partial("_Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""gpdiv"">
        <div class=""row justify-content-center mt-5 ml-1 "">
            <div class=""iletisimBilgileri col-6"" style=""font-size:xx-large; color:dodgerblue; font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif"">Harita</div>
            <div class=""iletisimBilgileri col-4 mr-2"" style=""font-size:xx-large; color:dodgerblue; font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif"">İletişim Bilgileri</div>
        </div>
        <div class=""row justify-content-center m-1 gpdiv "" >

            <div class=""haritaBilgileri col-6"" style=""width: 100%""><iframe width=""100%"" height=""500"" frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0"" src=""https://maps.google.com/maps?width=100%25&amp;height=600&amp;hl=en&amp;q=Yukar%C4%B1dudullu%20Mah.%20Tavuk%C3%A7uyolu%20Cd.%20Tando%C4%9Fanay%20Sk.%20Doruk%20Plaza%20No:11%20%C3%9Cmraniye/%C4%B0stanbul+(Baktek)&amp;t=&amp;z=14&amp;ie=UTF8&amp;iwloc=B&amp;output=embed""></iframe></div>
            <div clas");
            WriteLiteral(@"s=""iletisimBilgileri col-4"">


                <div class=""row mt-1"">
                    <div class=""pl-2""><i class=""fa fa-hand-o-right fa-2x"" aria-hidden=""true""></i></i></div>
                    <div class=""pl-2"" style=""font-size:x-large; color:#00539F;"">Merkez Ofis</div>
                    <div class=""row mt-3 ml-3"">
                        <div class=""col-1""><i class=""fa fa-map-marker fa-2x"" style=""color:#00539F;""></i></div>
                        <div class=""col-10"">Yukarıdudullu Mah. Tavukçuyolu Cd. andoğanay Sk. Doruk Plaza No:11 K: 2-3-4 Ümraniye/İstanbul </div>
                    </div>
                </div>

                <div class=""row mt-3 ml-3"">
                    <div><i class=""fa fa-phone fa-2x"" style=""color:#00539F""></i></div>
                    <div class=""ml-4""> (0216) 594 7727 </div>
                </div>

                <div class=""row mt-3 ml-3"">
                    <div><i class=""fa fa-envelope fa-2x"" style=""color:#00539F;margin-left: -2px;""></i></div>
    ");
            WriteLiteral(@"                <div class=""ml-4""> info@bak-tek.com</div>

                </div>



                <div class=""row mt-5"">
                    <div class=""pl-2""><i class=""fa fa-hand-o-right fa-2x"" aria-hidden=""true""></i></i></div>
                    <div class=""pl-2"" style=""font-size:x-large; color:#00539F;"">Teknokent Ofis</div>
                    <div class=""row mt-3 ml-3"">
                        <div class=""col-1""><i class=""fa fa-map-marker fa-2x"" style=""color:#00539F;""></i></div>
                        <div class=""col-10"">Reşit Paşa Mah. Katar Cad. ARI 4 Binası (İTÜ Magnet) No: 2/50/6 SARIYER/Istanbul </div>
                    </div>
                </div>
            </div>



        </div>
    </div>
   



");
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
