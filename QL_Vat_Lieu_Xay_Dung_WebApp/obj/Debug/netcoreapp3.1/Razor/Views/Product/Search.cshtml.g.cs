#pragma checksum "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87a715cffdb1e85fc95e5f479db0be25ea6f2795"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Search), @"mvc.1.0.view", @"/Views/Product/Search.cshtml")]
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
#line 1 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a715cffdb1e85fc95e5f479db0be25ea6f2795", @"/Views/Product/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c6c625a70cb7131686aad2eeec821a61608648", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QL_Vat_Lieu_Xay_Dung_WebApp.Models.SearchViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "sortBy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "pageSize", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/search.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
  
    ViewData["Title"] = "Search Results Of " + Model.Keyword;
    ViewData["MetaKeyword"] = "Search Results Of " + Model.Keyword;
    ViewData["MetaDescription"] = "Search Results Of " + Model.Keyword;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Breadcrumbs -->\r\n<div class=\"breadcrumbs\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-xs-12\">\r\n                <ul>\r\n                    <li class=\"home\"> <a title=\"Go to Home Page\" href=\"/\">");
#nullable restore
#line 16 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                     Write(Localizer["Home"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span>&raquo;</span></li>\r\n                    <li><strong>");
#nullable restore
#line 17 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                           Write(Localizer["SearchResult"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 17 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                       Write(Model.Keyword);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumbs End -->
<!-- Main Container -->
<div class=""main-container col2-left-layout"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-main col-sm-9 col-xs-12 col-sm-push-3"">
                <div class=""shop-inner"">
                    <div class=""page-title"">
                        <h2>");
#nullable restore
#line 31 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                       Write(Localizer["SearchResult"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 31 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                   Write(Model.Keyword);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n");
#nullable restore
#line 33 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                     if (@Model.Data.PageCount > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"toolbar\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87a715cffdb1e85fc95e5f479db0be25ea6f27959744", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"keyword\"");
                BeginWriteAttribute("value", " value=\"", 1486, "\"", 1508, 1);
#nullable restore
#line 37 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 1494, Model.Keyword, 1494, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <div class=\"sorter\">\r\n                                    <div class=\"short-by\">\r\n                                        <label>>");
#nullable restore
#line 40 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                           Write(Localizer["Sort"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</label>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87a715cffdb1e85fc95e5f479db0be25ea6f279510970", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 41 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SortType);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 42 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.SortTypes;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"short-by page\">\r\n                                        <label>>");
#nullable restore
#line 45 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                           Write(Localizer["Show"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(":</label>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87a715cffdb1e85fc95e5f479db0be25ea6f279513747", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 46 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageSize);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 47 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.PageSizes;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 52 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"product-grid-area\">\r\n                        <ul class=\"products-grid\">\r\n");
#nullable restore
#line 55 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                             foreach (var item in Model.Data.ResultList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <li class=""item col-lg-4 col-md-4 col-sm-6 col-xs-6 "">
                                    <div class=""product-item"">
                                        <div class=""item-inner"">
                                            <div class=""product-thumbnail"">
");
#nullable restore
#line 61 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                 if (@item.PromotionPrice.HasValue)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"icon-sale-label sale-left\">");
#nullable restore
#line 63 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                                      Write(Localizer["Sale"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                    <div class=\"icon-new-label new-right\">");
#nullable restore
#line 64 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                                     Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 65 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"icon-new-label new-right\">");
#nullable restore
#line 68 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                                     Write(Localizer["New"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 69 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"pr-img-area\">\r\n                                                    <a");
            BeginWriteAttribute("title", " title=\"", 3791, "\"", 3809, 1);
#nullable restore
#line 71 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 3799, item.Name, 3799, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3810, "\"", 3850, 5);
            WriteAttributeValue("", 3817, "/", 3817, 1, true);
#nullable restore
#line 71 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 3818, item.SeoAlias, 3818, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3832, "-p.", 3832, 3, true);
#nullable restore
#line 71 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 3835, item.Id, 3835, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3845, ".html", 3845, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <figure> <img class=\"first-img\" width=\"260\" height=\"260\"");
            BeginWriteAttribute("src", " src=\"", 3966, "\"", 3983, 1);
#nullable restore
#line 72 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 3972, item.Image, 3972, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3984, "\"", 4000, 1);
#nullable restore
#line 72 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 3990, item.Name, 3990, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img class=\"hover-img\"");
            BeginWriteAttribute("src", " src=\"", 4025, "\"", 4042, 1);
#nullable restore
#line 72 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 4031, item.Image, 4031, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4043, "\"", 4059, 1);
#nullable restore
#line 72 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 4049, item.Name, 4049, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></figure>
                                                    </a>
                                                </div>
                                            </div>
                                            <div class=""item-info"">
                                                <div class=""info-inner"">
                                                    <div class=""item-title""> <a");
            BeginWriteAttribute("title", " title=\"", 4460, "\"", 4478, 1);
#nullable restore
#line 78 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 4468, item.Name, 4468, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 4479, "\"", 4519, 5);
            WriteAttributeValue("", 4486, "/", 4486, 1, true);
#nullable restore
#line 78 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 4487, item.SeoAlias, 4487, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4501, "-p.", 4501, 3, true);
#nullable restore
#line 78 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
WriteAttributeValue("", 4504, item.Id, 4504, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4514, ".html", 4514, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </div>\r\n                                                    <div class=\"item-content\">\r\n                                                        <div class=\"item-price\">\r\n");
#nullable restore
#line 81 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                             if (@item.PromotionPrice.HasValue)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <div class=\"price-box\">\r\n                                                                    <p class=\"special-price\"> <span class=\"price-label\">");
#nullable restore
#line 84 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                                                                   Write(Localizer["SpecialPrice"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> <span class=\"price\"> ");
#nullable restore
#line 84 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                                                                                                                           Write(string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.PromotionPrice.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </p>\r\n                                                                    <p class=\"old-price\"> <span class=\"price-label\">");
#nullable restore
#line 85 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                                                               Write(Localizer["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> <span class=\"price\"> ");
#nullable restore
#line 85 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                                                                                                                Write(string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </p>\r\n                                                                </div>\r\n");
#nullable restore
#line 87 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"

                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <div class=\"price-box\"> <span class=\"regular-price\"> <span class=\"price\">");
#nullable restore
#line 91 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                                                                                    Write(string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </span> </div>\r\n");
#nullable restore
#line 92 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </li>
");
#nullable restore
#line 100 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    ");
#nullable restore
#line 104 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
               Write(await Component.InvokeAsync("Pager", Model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <aside class=\"sidebar col-sm-3 col-xs-12 col-sm-pull-9\">\r\n                <div class=\"block product-price-range \">\r\n                    <div class=\"sidebar-bar-title\">\r\n                        <h3>");
#nullable restore
#line 110 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                       Write(Localizer["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"block-content\">\r\n                        <div class=\"slider-range\">\r\n                            <div data-label-reasult=\"");
#nullable restore
#line 114 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                Write(Localizer["Range"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":\" data-min=\"0\" data-max=\"500\" data-unit=\"$\" class=\"slider-range-price\" data-value-min=\"50\" data-value-max=\"350\"></div>\r\n                            <div class=\"amount-range-price\">");
#nullable restore
#line 115 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                       Write(Localizer["Range"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": $10 - $550</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"block compare\">\r\n                    <div class=\"sidebar-bar-title\">\r\n                        <h3>");
#nullable restore
#line 121 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                       Write(Localizer["Compare"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    </div>
                    <div class=""block-content"">
                        <ol id=""compare-items"">
                            <li class=""item""> <a href=""compare.html"" title=""Remove This Item"" class=""remove-cart""><i class=""icon-close""></i></a> <a href=""#"" class=""product-name""><i class=""fa fa-angle-right""></i>&nbsp; Vestibulum porta tristique porttitor.</a> </li>
                            <li class=""item""> <a href=""compare.html"" title=""Remove This Item"" class=""remove-cart""><i class=""icon-close""></i></a> <a href=""#"" class=""product-name""><i class=""fa fa-angle-right""></i>&nbsp; Lorem ipsum dolor sit amet</a> </li>
                        </ol>
                        <div class=""ajax-checkout"">
                            <button type=""submit"" title=""Submit"" class=""button button-compare""> <span>");
#nullable restore
#line 129 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                                                 Write(Localizer["Compare"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></button>\r\n                            <button type=\"submit\" title=\"Submit\" class=\"button button-clear\"> <span>");
#nullable restore
#line 130 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                                                                                               Write(Localizer["Clear"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"block popular-tags-area \">\r\n                    <div class=\"sidebar-bar-title\">\r\n                        <h3>");
#nullable restore
#line 137 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\Search.cshtml"
                       Write(Localizer["Tags"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    </div>
                    <div class=""tag"">
                        <ul>
                            <li><a href=""#"">Boys</a></li>
                            <li><a href=""#"">Camera</a></li>
                            <li><a href=""#"">good</a></li>
                            <li><a href=""#"">Computers</a></li>
                            <li><a href=""#"">Phone</a></li>
                            <li><a href=""#"">clothes</a></li>
                            <li><a href=""#"">girl</a></li>
                            <li><a href=""#"">shoes</a></li>
                            <li><a href=""#"">women</a></li>
                            <li><a href=""#"">accessoties</a></li>
                            <li><a href=""#"">View All Tags</a></li>
                        </ul>
                    </div>
                </div>
            </aside>
        </div>
    </div>
</div>
<!-- Main Container End -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QL_Vat_Lieu_Xay_Dung_WebApp.Models.SearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
