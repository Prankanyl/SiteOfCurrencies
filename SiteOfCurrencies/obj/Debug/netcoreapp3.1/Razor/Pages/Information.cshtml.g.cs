#pragma checksum "/Users/Valera/Projects/SiteOfCurrencies/SiteOfCurrencies/Pages/Information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d8b9760d7f62a21d834b94681d77160da704822"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SiteOfCurrencies.Pages.Pages_Information), @"mvc.1.0.razor-page", @"/Pages/Information.cshtml")]
namespace SiteOfCurrencies.Pages
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
#line 1 "/Users/Valera/Projects/SiteOfCurrencies/SiteOfCurrencies/Pages/_ViewImports.cshtml"
using SiteOfCurrencies;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d8b9760d7f62a21d834b94681d77160da704822", @"/Pages/Information.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01441299ffa739fc7eefd25782cc145b0d3faaa9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Information : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/Valera/Projects/SiteOfCurrencies/SiteOfCurrencies/Pages/Information.cshtml"
  
    ViewData["Title"] = "О проекте";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <h3 style=""text-align: center"">Веб-приложение ""Курс валют""</h3>
    <p><b>Тема:</b> Курс валют</p>
    <p><b>Язык программирования:</b> C#</p>
    <p><b>Среда разработки:</b> Visual Studio</p>
    <p><b>Разработчик:</b> Королев А.И.</p>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Information> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Information> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Information>)PageContext?.ViewData;
        public Pages_Information Model => ViewData.Model;
    }
}
#pragma warning restore 1591
