#pragma checksum "C:\Users\Паша\Desktop\SiteOfCurrencies\SiteOfCurrencies\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b2960e51e6a1f909cde11ad061e29613846ea6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SiteOfCurrencies.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
#line 1 "C:\Users\Паша\Desktop\SiteOfCurrencies\SiteOfCurrencies\Pages\_ViewImports.cshtml"
using SiteOfCurrencies;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b2960e51e6a1f909cde11ad061e29613846ea6a", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04dce5d3673a2c7d21d7fd38b1968fc0b2c270ef", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/val.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 100%; width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Паша\Desktop\SiteOfCurrencies\SiteOfCurrencies\Pages\Index.cshtml"
  
    ViewData["Title"] = "Курс валют";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .h3 {
            font-family: 'Times New Roman', Times, serif;
            text-align: justify;
            text-indent: 2em;
        }
</style>
<div class=""container-fluid"" style=""background-color: #676dc5; color: #ffffff;"">
    <h3 class=""h3"" style=""text-align: center"">Курс валют</h3>
    <div class=""row"" style=""background-color: #676dc5"">
        <div class=""col-lg-8"">
            <p class=""p1"">
                <b>Валюта</b> — национальные, иностранные и международные деньги, как в наличной форме, в виде банкнот, казначейских билетов, монет, так и безналичной на банковских счетах и в банковских вкладах, являющиеся законным средством платежа.

                Второе значение термина — денежная единица, то есть единица измерения денег, используемая для выражения цен товаров и услуг, для установления номиналов денежных знаков, для осуществления денежных расчётов, для определения стоимости курса иностранных валют.

                Национальной валютой Республики Беларусь является б");
            WriteLiteral(@"елорусский рубль, состоящий из 100 копеек, последние выступают по отношению к национальной валюте разменными денежными единицами. Примерами международных валют являются доллары, евро, специальные права заимствования.

                Ряд авторов считает, что валютой в широком смысле является любой товар, способный выполнять функцию денег при совершении обмена на рынке внутри страны или на международном рынке.
            </p>
        </div>
        <div class=""col-lg-4"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b2960e51e6a1f909cde11ad061e29613846ea6a5387", async() => {
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
    </div>
</div>
<div class=""container-fluid"" style=""background-color: #ffffff"">
    <h3 style=""text-align: center;"" class=""h3"">Этимология</h3>
    <div class=""row"" style=""background-color: #ffffff"">
        <div class=""col-lg-12"">
            <p style=""text-indent: 2em;"">Слово <i>«валюта»</i> происходит от итал. valuta <i>«стоимость, монета, валюта»</i>, в свою очередь восходящего к праиндоевр. wal <i>«быть сильным»</i>. Русское слово <i>«валюта»</i>, возможно, заимствовано через нем. Valuta или прямо из итальянского языка.</p>
            <p style=""text-align: center""><b>Термин Валюта также применяется для обозначения:</b></p>
            <ol class=""list-group"" style=""text-align: center"">
                <li class=""list-group-item"">иностранной валюты;</li>
                <li class=""list-group-item"">валютных ценностей;</li>
                <li class=""list-group-item"">валюты баланса.</li>
            </ol>
            <br />
        </div>
    </div>
    <div class=""row"" st");
            WriteLiteral(@"yle=""background-color: #bd1313"">
        <div class=""col-lg-12"">
            <h3 class=""h3"" style=""text-align: center; color: #ffffff;"">Валюта и деньги</h3>
            <p class=""p1"">Слово «валюта» вошло в широкий обиход только во второй половине XX века и обычно применяется только к действующим законным средствам платежа, существующим в формах наличных или безналичных денег. Так, древнеримский денарий не называют валютой, используя понятия «монета», «денежная единица». Термин «валюта» (как основная денежная единица государства) не тождественен понятию «деньги». Некоторые функции денег при определённых обстоятельствах могут выполнять некоторые товары (товарные деньги). Так, например, в Германии в первые годы после окончания Второй мировой войны, в Западной зоне оккупации на чёрном рынке роль денег играли американские сигареты.</p>
        </div>
    </div>
    <!--<div class=""row"">
        <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-");
            WriteLiteral(@"indicators"">
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
            </ol>
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">
                    <img class=""d-block w-100"" src=""~/img/1.jpg"" alt=""Первый слайд"">
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100"" src=""~/img/2.jpg"" alt=""Второй слайд"">
                </div>
                <div class=""carousel-item"">
                    <img class=""d-block w-100"" src=""~/img/3.jpg"" alt=""Третий слайд"">
                </div>
            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""t");
            WriteLiteral(@"rue""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>-->
    <h3 style=""text-align: center"" class=""h3"">Классификация валюты</h3>
    <div class=""row"">
        <div class=""col-lg-12"">
            <p style=""text-align: center; text-indent: 2em;"">Существует несколько подходов для выделения различных видов валют, в частности выделяют:</p>
        </div>
    </div>
    <div class=""row"">     
        <div class=""col-lg-6"">
            <ol>
                <li>
                    <i><b>По отношению к государству-эмитенту:</b></i>
                    <ul>
                        <li>национальная</li>
                        <li>иностранная</li>
                        <li>коллекти");
            WriteLiteral(@"вная</li>
                    </ul>
                </li>
                <li>
                    <i><b>По возможности обмена на другую валюту</b></i>
                    <ul>
                        <li>свободно конвертируемая</li>
                        <li>частично конвертируемая, частично обратимая</li>
                        <li>неконвертируемая, необратимая, замкнутая</li>
                    </ul>
                </li>
                <li>
                    <i><b>По обеспеченности драгоценными металлами в рамках действующей денежной системы:</b></i>
                    <ul>
                        <li>обеспеченная золотом</li>
                        <li>обеспеченная серебром</li>
                        <li>биметаллическая</li>
                        <li>необеспеченная драгоценными металлами</li>
                    </ul>
                </li>
                <li>
                    <i><b>По степени стабильности, устойчивости валютного курса:</b></i>

                    ");
            WriteLiteral(@"<ul>
                        <li>твёрдая / сильная</li>
                        <li>мягкая / слабая</li>
                    </ul>
                </li>
                <li>
                    <i><b>По статусу эмитента и территории обращения:</b></i>
                    <ul>
                        <li>национальная</li>
                        <li>региональная</li>
                        <li>частная</li>
                    </ul>
                </li>
                <li>
                    <i><b>По степени использования в мировом обороте:</b></i>
                    <ul>
                        <li>международная</li>
                        <li>ключевая</li>
                        <li>резервная</li>
                        <li>ведущая (доминирующая)</li>
                    </ul>
                </li>
            </ol>
        </div>
        <div class=""col-lg-6"">
            <ol>
                <li>
                    <i><b>По сфере применения:</b></i>
                    <");
            WriteLiteral(@"ul>
                        <li>валюта цены</li>
                        <li>валюта платежа</li>
                        <li>валюта чека, векселя</li>
                        <li>валюта ценных бумаг</li>
                        <li>валюта интервенции</li>
                        <li>клиринговая валюта</li>
                    </ul>
                </li>
                <li>
                    <i><b>По наличию других валют, участвующих в обращении:</b></i>
                    <ul>
                        <li>единственное законное платёжное средство</li>
                        <li>параллельная</li>
                        <li>суррогатная</li>
                    </ul>
                </li>
                <li>
                    <i><b>По сроку действия:</b></i>
                    <ul>
                        <li>постоянная</li>
                        <li>временная</li>
                    </ul>
                </li>
                <li>
                    <i><b>По наличию физическ");
            WriteLiteral(@"ой формы (в форме банкнот, казначейских билетов и монет):</b></i>
                    <ul>
                        <li>Наличные деньги</li>
                        <li>Счётные денежные единицы</li>
                    </ul>
                </li>
                <li>
                    <i><b>По своему текущему статусу:</b></i>
                    <ul>
                        <li>историческая</li>
                        <li>существующая</li>
                    </ul>
                </li>
            </ol>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
