#pragma checksum "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b7557e3cc7b71b394236df4ed3bf9483615b8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductCatalogByBrand), @"mvc.1.0.view", @"/Views/Product/ProductCatalogByBrand.cshtml")]
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
#line 1 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b7557e3cc7b71b394236df4ed3bf9483615b8c", @"/Views/Product/ProductCatalogByBrand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f90c78da82dda6684e972a96cce09822da98ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductCatalogByBrand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QL_Vat_Lieu_Xay_Dung_WebApp.Models.ProductCatalogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "sortBy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "pageSize", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
  
    ViewData["Title"] = Model.Brand.SeoPageTitle;
    ViewData["MetaKeyword"] = Model.Brand.SeoKeywords;
    ViewData["MetaDescription"] = Model.Brand.SeoDescription;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumbs -->
<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <ul>
                    <li class=""home""> <a title=""Go to Home Page"" href=""/"">Home</a><span>&raquo;</span></li>
                    <li><strong>");
#nullable restore
#line 15 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                           Write(Model.Brand.Name);

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
#line 29 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                       Write(Model.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n");
#nullable restore
#line 31 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                     if (@Model.Data.PageCount > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"toolbar\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b7557e3cc7b71b394236df4ed3bf9483615b8c8728", async() => {
                WriteLiteral("\r\n                                <div class=\"sorter\">\r\n                                    <div class=\"short-by\">\r\n                                        <label>Sort By:</label>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b7557e3cc7b71b394236df4ed3bf9483615b8c9215", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 38 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SortType);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 39 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
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
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"short-by page\">\r\n                                        <label>Show:</label>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2b7557e3cc7b71b394236df4ed3bf9483615b8c11795", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 43 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageSize);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 44 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
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
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1219, "/", 1219, 1, true);
#nullable restore
#line 34 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
AddHtmlAttributeValue("", 1220, Model.Brand.SeoAlias, 1220, 21, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1241, "-c.", 1241, 3, true);
#nullable restore
#line 34 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
AddHtmlAttributeValue("", 1244, Model.Brand.Id, 1244, 17, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1261, ".html", 1261, 5, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 49 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"product-grid-area\">\r\n                        <ul class=\"products-grid\">\r\n");
#nullable restore
#line 52 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
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
#line 58 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                                                 if (@item.PromotionPrice.HasValue)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"icon-sale-label sale-left\">Sale</div>\r\n                                                    <div class=\"icon-new-label new-right\">New</div>\r\n");
#nullable restore
#line 62 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"icon-new-label new-right\">New</div>\r\n");
#nullable restore
#line 66 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"pr-img-area\">\r\n                                                    <a");
            BeginWriteAttribute("title", " title=\"", 3491, "\"", 3509, 1);
#nullable restore
#line 68 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
WriteAttributeValue("", 3499, item.Name, 3499, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3510, "\"", 3550, 5);
            WriteAttributeValue("", 3517, "/", 3517, 1, true);
#nullable restore
#line 68 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
WriteAttributeValue("", 3518, item.SeoAlias, 3518, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3532, "-p.", 3532, 3, true);
#nullable restore
#line 68 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
WriteAttributeValue("", 3535, item.Id, 3535, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3545, ".html", 3545, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <figure> <img class=\"first-img\" width=\"260\" height=\"260\"");
            BeginWriteAttribute("src", " src=\"", 3666, "\"", 3683, 1);
#nullable restore
#line 69 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
WriteAttributeValue("", 3672, item.Image, 3672, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3684, "\"", 3700, 1);
#nullable restore
#line 69 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
WriteAttributeValue("", 3690, item.Name, 3690, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img class=\"hover-img\"");
            BeginWriteAttribute("src", " src=\"", 3725, "\"", 3742, 1);
#nullable restore
#line 69 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
WriteAttributeValue("", 3731, item.Image, 3731, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3743, "\"", 3759, 1);
#nullable restore
#line 69 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
WriteAttributeValue("", 3749, item.Name, 3749, 10, false);

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
            BeginWriteAttribute("title", " title=\"", 4160, "\"", 4178, 1);
#nullable restore
#line 75 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
WriteAttributeValue("", 4168, item.Name, 4168, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 4179, "\"", 4219, 5);
            WriteAttributeValue("", 4186, "/", 4186, 1, true);
#nullable restore
#line 75 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
WriteAttributeValue("", 4187, item.SeoAlias, 4187, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4201, "-p.", 4201, 3, true);
#nullable restore
#line 75 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
WriteAttributeValue("", 4204, item.Id, 4204, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4214, ".html", 4214, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 75 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                                                                                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </div>\r\n                                                    <div class=\"item-content\">\r\n                                                        <div class=\"item-price\">\r\n");
#nullable restore
#line 78 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                                                             if (@item.PromotionPrice.HasValue)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <div class=\"price-box\">\r\n                                                                    <p class=\"special-price\"> <span class=\"price-label\">Special Price</span> <span class=\"price\"> ");
#nullable restore
#line 81 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                                                                                                                                                             Write(string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.PromotionPrice.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </p>\r\n                                                                    <p class=\"old-price\"> <span class=\"price-label\">Regular Price:</span> <span class=\"price\"> ");
#nullable restore
#line 82 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                                                                                                                                                          Write(string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </p>\r\n                                                                </div>\r\n");
#nullable restore
#line 84 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"

                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <div class=\"price-box\"> <span class=\"regular-price\"> <span class=\"price\">");
#nullable restore
#line 88 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
                                                                                                                                    Write(string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </span> </div>\r\n");
#nullable restore
#line 89 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
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
#line 97 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    ");
#nullable restore
#line 101 "D:\Learning_Code\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByBrand.cshtml"
               Write(await Component.InvokeAsync("Pager", Model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <aside class=""sidebar col-sm-3 col-xs-12 col-sm-pull-9"">
                <div class=""block shop-by-side"">
                    <div class=""sidebar-bar-title"">
                        <h3>Shop By</h3>
                    </div>
                    <div class=""block-content"">
                        <p class=""block-subtitle"">Shopping Options</p>
                        <div class=""layered-Category"">
                            <h2 class=""saider-bar-title"">Categories</h2>
                            <div class=""layered-content"">
                                <ul class=""check-box-list"">
                                    <li>
                                        <input type=""checkbox"" id=""jtv1"" name=""jtvc"">
                                        <label for=""jtv1""> <span class=""button""></span> Women<span class=""count"">(12)</span> </label>
                                    </li>
                                    <li>
               ");
            WriteLiteral(@"                         <input type=""checkbox"" id=""jtv1"" name=""jtvc"">
                                        <label for=""jtv1""> <span class=""button""></span> Men<span class=""count"">(22)</span> </label>
                                    </li>
                                    <li>
                                        <input type=""checkbox"" id=""jtv1"" name=""jtvc"">
                                        <label for=""jtv1""> <span class=""button""></span> Kids<span class=""count"">(15)</span> </label>
                                    </li>
                                    <li>
                                        <input type=""checkbox"" id=""jtv1"" name=""jtvc"">
                                        <label for=""jtv1""> <span class=""button""></span> Accessories<span class=""count"">(12)</span> </label>
                                    </li>
                                    <li>
                                        <input type=""checkbox"" id=""jtv1"" name=""jtvc"">
                            ");
            WriteLiteral(@"            <label for=""jtv1""> <span class=""button""></span> Camera & Photo<span class=""count"">(12)</span> </label>
                                    </li>
                                    <li>
                                        <input type=""checkbox"" id=""jtv2"" name=""jtvc"">
                                        <label for=""jtv2""> <span class=""button""></span> Computers<span class=""count"">(18)</span> </label>
                                    </li>
                                    <li>
                                        <input type=""checkbox"" id=""jtv3"" name=""jtvc"">
                                        <label for=""jtv3""> <span class=""button""></span> Apple Store<span class=""count"">(15)</span> </label>
                                    </li>
                                    <li>
                                        <input type=""checkbox"" id=""jtv4"" name=""jtvc"">
                                        <label for=""jtv4""> <span class=""button""></span> Car Electronic<span clas");
            WriteLiteral(@"s=""count"">(03)</span> </label>
                                    </li>
                                    <li>
                                        <input type=""checkbox"" id=""jtv5"" name=""jtvc"">
                                        <label for=""jtv5""> <span class=""button""></span> Accessories<span class=""count"">(04)</span> </label>
                                    </li>
                                    <li>
                                        <input type=""checkbox"" id=""jtv7"" name=""jtvc"">
                                        <label for=""jtv7""> <span class=""button""></span> Game & Video<span class=""count"">(07)</span> </label>
                                    </li>
                                    <li>
                                        <input type=""checkbox"" id=""jtv8"" name=""jtvc"">
                                        <label for=""jtv8""> <span class=""button""></span> Best selling<span class=""count"">(05)</span> </label>
                                    </li>
        ");
            WriteLiteral(@"                        </ul>
                            </div>
                        </div>
                        <div class=""size-area"">
                            <h2 class=""saider-bar-title"">Size</h2>
                            <div class=""size"">
                                <ul>
                                    <li><a href=""#"">S</a></li>
                                    <li><a href=""#"">L</a></li>
                                    <li><a href=""#"">M</a></li>
                                    <li><a href=""#"">XL</a></li>
                                    <li><a href=""#"">XXL</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""block product-price-range "">
                    <div class=""sidebar-bar-title"">
                        <h3>Price</h3>
                    </div>
                    <div class=""block-content"">
            ");
            WriteLiteral(@"            <div class=""slider-range"">
                            <div data-label-reasult=""Range:"" data-min=""0"" data-max=""500"" data-unit=""$"" class=""slider-range-price"" data-value-min=""50"" data-value-max=""350""></div>
                            <div class=""amount-range-price"">Range: $10 - $550</div>
                        </div>
                    </div>
                </div>
                <div class=""block compare"">
                    <div class=""sidebar-bar-title"">
                        <h3>Compare Products (2)</h3>
                    </div>
                    <div class=""block-content"">
                        <ol id=""compare-items"">
                            <li class=""item""> <a href=""compare.html"" title=""Remove This Item"" class=""remove-cart""><i class=""icon-close""></i></a> <a href=""#"" class=""product-name""><i class=""fa fa-angle-right""></i>&nbsp; Vestibulum porta tristique porttitor.</a> </li>
                            <li class=""item""> <a href=""compare.html"" title=""Remove This It");
            WriteLiteral(@"em"" class=""remove-cart""><i class=""icon-close""></i></a> <a href=""#"" class=""product-name""><i class=""fa fa-angle-right""></i>&nbsp; Lorem ipsum dolor sit amet</a> </li>
                        </ol>
                        <div class=""ajax-checkout"">
                            <button type=""submit"" title=""Submit"" class=""button button-compare""> <span>Compare</span></button>
                            <button type=""submit"" title=""Submit"" class=""button button-clear""> <span>Clear All</span></button>
                        </div>
                    </div>
                </div>

                <div class=""block popular-tags-area "">
                    <div class=""sidebar-bar-title"">
                        <h3>Popular Tags</h3>
                    </div>
                    <div class=""tag"">
                        <ul>
                            <li><a href=""#"">Boys</a></li>
                            <li><a href=""#"">Camera</a></li>
                            <li><a href=""#"">good</a></li>
  ");
            WriteLiteral(@"                          <li><a href=""#"">Computers</a></li>
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QL_Vat_Lieu_Xay_Dung_WebApp.Models.ProductCatalogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
