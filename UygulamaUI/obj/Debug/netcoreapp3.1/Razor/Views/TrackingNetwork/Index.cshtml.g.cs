#pragma checksum "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\Views\TrackingNetwork\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "421f9bd30e41840358c51204d7cb948a4eaf4cd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrackingNetwork_Index), @"mvc.1.0.view", @"/Views/TrackingNetwork/Index.cshtml")]
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
#line 1 "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\Views\TrackingNetwork\Index.cshtml"
using UygulamaUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"421f9bd30e41840358c51204d7cb948a4eaf4cd0", @"/Views/TrackingNetwork/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3948a4527c2784b3c457e340758cac077a39073b", @"/Views/_ViewImports.cshtml")]
    public class Views_TrackingNetwork_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SelectList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/IconGreen.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 100%; max-height: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\Views\TrackingNetwork\Index.cshtml"
  
    ViewData["Title"] = "İzleme Ağı";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\Views\TrackingNetwork\Index.cshtml"
Write(Html.Partial("_Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<div class=""mb-2"" id=""divHarita"" style=""width:100%; height:600px;"">
</div>

<div class=""container"">

    <div id=""gosterge"" class=""row justify-content-center"" style=""display:none; z-index:9; position: fixed;
  top: 12%;
  left:40%;
  "">

        <div class=""row justify-content-center m-5"" style=""height:600px;width:100%"">
            <div style=""
        height: 90%;
        width: 100%;
        border-radius: 25px;
        border: 1px solid;
        border-color: rgb(220, 220, 217);
        box-shadow: 6px 6px 6px rgba(103, 221, 35, 0.4);
        background-color: white
    "">
                <div class=""row "" style=""height:15%;width:100%; text-align:center"">
                    <div style=""margin-left:35%"">
                        <span style=""color:rgba(11, 137, 11, 0.63);font-size:xx-large;font-family: 'Roboto Condensed', sans-serif !important; margin-top:3px; margin-left:3px;"">KADIKÖY</span>

                    </div>
                    <div style=""margin-left:15%"">
 ");
            WriteLiteral(@"                       <button type=""button"" class=""btn cancel"" onclick=""closeForm()"">
                            <span style=""color:rgba(100, 239, 52, 0.75); font-size:x-large;"">X</span>
                        </button>
                    </div>


                </div>
                <div class=""row ml-1"" style=""height:35%;width:100%;padding-left:90px;"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "421f9bd30e41840358c51204d7cb948a4eaf4cd06182", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div style=""height:20%;width:100%; margin-top:-80px; margin-left:30px;"">
                    <div style=""width:30%; font-size:xx-large; color:forestgreen"">pH:7</div>
                    <div style=""width:30%; font-size:x-large; color:rgba(11, 137, 11, 0.63)"">İYİ</div>
                </div>
                <hr />
                <div>

                    <div class=""degerler row justify-content-between m-2 pl-3 border-bottom"">
                        <div>pH:</div>
                        <div class=""mr-5"">6.5-9</div>
                    </div>

                    <div class=""degerler row justify-content-between m-2 pl-3 border-bottom"">
                        <div>Yağ Gres Oranı</div>
                        <div class=""mr-5"">%20</div>
                    </div>

                    <div class=""degerler row justify-content-between m-2 pl-3 border-bottom"">
                        <div>KOİ</div>
                        <div class=""mr-5"">İnaktif</di");
            WriteLiteral(@"v>
                    </div>

                    <div class=""degerler row justify-content-between m-2 pl-3 border-bottom"">
                        <div>BOİ</div>
                        <div class=""mr-5"">İnaktif</div>
                    </div>

                    <div class=""degerler row justify-content-between m-2 pl-3 border-bottom"">
                        <div>Akış Debisi</div>
                        <div class=""mr-5"">İnaktif</div>
                    </div>
                    <div class=""degerler row justify-content-between m-2 pl-3 "">
                        <div>Su Seviyesi</div>
                        <div class=""mr-5"">0</div>
                    </div>
                </div>
            </div>

        </div>




    </div>
    <div style=""width:100%; height:50px;""></div>

</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "421f9bd30e41840358c51204d7cb948a4eaf4cd09217", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script async defer src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyA4MlKy6TkDxM1mW6lpGj0-PlF1btdJsd8&callback=initMap""
        type=""text/javascript""></script>
<script>
    function initMap() {
        var options = {
            center: new google.maps.LatLng(41.015137, 28.979530),
            zoom: 11,
        };
        var kadiköyPosition = { lat: 40.985496058, lng: 29.035333192 };
        var map = new google.maps.Map(document.getElementById(""divHarita""), options);
        var marker = new google.maps.Marker({
            position: kadiköyPosition,
            map: map
        });
        marker.addListener('click', openForm);

    };

    function openForm() {
        document.getElementById(""gosterge"").style.display = ""block"";
        document.getElementById(""divHarita"").style.opacity = ""0.3"";
    };

    function closeForm() {
        document.getElementById(""gosterge"").style.display = ""none"";
        document.getElementById(""divHarita"").style.opacity = ""1"";
    }");
            WriteLiteral(";\r\n</script>");
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
