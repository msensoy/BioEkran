#pragma checksum "C:\Users\MONSTER\GitHub\BioEkran\UygulamaUI\Views\TrackingNetwork\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755f54329346a81dd4a86991b4ea0c48aebcbfd0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755f54329346a81dd4a86991b4ea0c48aebcbfd0", @"/Views/TrackingNetwork/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3948a4527c2784b3c457e340758cac077a39073b", @"/Views/_ViewImports.cshtml")]
    public class Views_TrackingNetwork_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SelectList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<br />\r\n<div class=\"mb-2\" id=\"divHarita\" style=\"width:100%; height:600px;\">\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row bg-primary\">\r\n        czcasd\r\n    </div>\r\n\r\n</div>\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "755f54329346a81dd4a86991b4ea0c48aebcbfd04214", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $(""#ddlCihazlar"").change(function () {
            if ($(""#ddlCihazlar option:selected"").text() == ""Cihaz Seçin"") {
                $(""#deviceName"").html("""");
                $(""#deviceId"").html("""");
                $(""#deviceWMode"").html("""");
                $(""#divCharts"").load(`/Home/GetCharts/${0}`);
            }
            $.ajax({
                url: '/TrackingNetwork/GetDeviceInfo',
                data: { id: $(""#ddlCihazlar"").val() },
                success: function (device) {
                    $(""#deviceName"").html(device.name);
                    $(""#deviceId"").html(device.id);
                    $(""#deviceWMode"").html(device.workingMode);

                    $(""#divCharts"").load(`/Home/GetCharts/${device.id}`);
                }
            });
        });

    });
</script>
<script async defer src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyA4MlKy6TkDxM1mW6lpGj0-PlF1btdJsd8&callback=initMap""
        t");
            WriteLiteral(@"ype=""text/javascript""></script>
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
    };
</script>");
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
