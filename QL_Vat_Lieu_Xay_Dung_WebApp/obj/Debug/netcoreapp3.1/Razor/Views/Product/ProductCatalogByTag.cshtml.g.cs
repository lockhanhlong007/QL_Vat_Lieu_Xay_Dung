#pragma checksum "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4edfd8573b5434338bb6b36717ff8c87a5459de0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductCatalogByTag), @"mvc.1.0.view", @"/Views/Product/ProductCatalogByTag.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4edfd8573b5434338bb6b36717ff8c87a5459de0", @"/Views/Product/ProductCatalogByTag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f90c78da82dda6684e972a96cce09822da98ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductCatalogByTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QL_Vat_Lieu_Xay_Dung_WebApp.Models.ProductCatalogViewModel>
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
#line 2 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
  
    ViewData["Title"] = Model.Tag.Name;
    ViewData["MetaKeyword"] = Model.Tag.Name;
    ViewData["MetaDescription"] = Model.Tag.Name;

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
#line 15 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                           Write(Model.Tag.Name);

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
#line 29 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                       Write(Model.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n");
#nullable restore
#line 31 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                     if (@Model.Data.PageCount > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"toolbar\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4edfd8573b5434338bb6b36717ff8c87a5459de08339", async() => {
                WriteLiteral("\r\n                                <div class=\"sorter\">\r\n                                    <div class=\"short-by\">\r\n                                        <label>Sort By:</label>\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4edfd8573b5434338bb6b36717ff8c87a5459de08826", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 38 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SortType);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 39 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4edfd8573b5434338bb6b36717ff8c87a5459de011354", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 43 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageSize);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 44 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
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
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1184, "/tag-", 1184, 5, true);
#nullable restore
#line 34 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
AddHtmlAttributeValue("", 1189, Model.Tag.Id, 1189, 15, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1204, ".html", 1204, 5, true);
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
#line 49 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"product-grid-area\">\r\n                        <ul class=\"products-grid\">\r\n");
#nullable restore
#line 52 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
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
#line 58 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                                                 if (@item.PromotionPrice.HasValue)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"icon-sale-label sale-left\">Sale</div>\r\n                                                    <div class=\"icon-new-label new-right\">New</div>\r\n");
#nullable restore
#line 62 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"icon-new-label new-right\">New</div>\r\n");
#nullable restore
#line 66 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"pr-img-area\">\r\n                                                    <a");
            BeginWriteAttribute("title", " title=\"", 3434, "\"", 3452, 1);
#nullable restore
#line 68 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
WriteAttributeValue("", 3442, item.Name, 3442, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3453, "\"", 3493, 5);
            WriteAttributeValue("", 3460, "/", 3460, 1, true);
#nullable restore
#line 68 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
WriteAttributeValue("", 3461, item.SeoAlias, 3461, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3475, "-p.", 3475, 3, true);
#nullable restore
#line 68 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
WriteAttributeValue("", 3478, item.Id, 3478, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3488, ".html", 3488, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <figure> <img class=\"first-img\" width=\"260\" height=\"260\"");
            BeginWriteAttribute("src", " src=\"", 3609, "\"", 3626, 1);
#nullable restore
#line 69 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
WriteAttributeValue("", 3615, item.Image, 3615, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3627, "\"", 3643, 1);
#nullable restore
#line 69 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
WriteAttributeValue("", 3633, item.Name, 3633, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <img class=\"hover-img\"");
            BeginWriteAttribute("src", " src=\"", 3668, "\"", 3685, 1);
#nullable restore
#line 69 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
WriteAttributeValue("", 3674, item.Image, 3674, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3686, "\"", 3702, 1);
#nullable restore
#line 69 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
WriteAttributeValue("", 3692, item.Name, 3692, 10, false);

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
            BeginWriteAttribute("title", " title=\"", 4103, "\"", 4121, 1);
#nullable restore
#line 75 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
WriteAttributeValue("", 4111, item.Name, 4111, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 4122, "\"", 4162, 5);
            WriteAttributeValue("", 4129, "/", 4129, 1, true);
#nullable restore
#line 75 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
WriteAttributeValue("", 4130, item.SeoAlias, 4130, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4144, "-p.", 4144, 3, true);
#nullable restore
#line 75 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
WriteAttributeValue("", 4147, item.Id, 4147, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4157, ".html", 4157, 5, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 75 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                                                                                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </div>\r\n                                                    <div class=\"item-content\">\r\n                                                        <div class=\"item-price\">\r\n");
#nullable restore
#line 78 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                                                             if (@item.PromotionPrice.HasValue)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <div class=\"price-box\">\r\n                                                                    <p class=\"special-price\"> <span class=\"price-label\">Special Price</span> <span class=\"price\"> ");
#nullable restore
#line 81 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                                                                                                                                                             Write(string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.PromotionPrice.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </p>\r\n                                                                    <p class=\"old-price\"> <span class=\"price-label\">Regular Price:</span> <span class=\"price\"> ");
#nullable restore
#line 82 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                                                                                                                                                          Write(string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </p>\r\n                                                                </div>\r\n");
#nullable restore
#line 84 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"

                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <div class=\"price-box\"> <span class=\"regular-price\"> <span class=\"price\">");
#nullable restore
#line 88 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
                                                                                                                                    Write(string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </span> </div>\r\n");
#nullable restore
#line 89 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
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
#line 97 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    ");
#nullable restore
#line 101 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Views\Product\ProductCatalogByTag.cshtml"
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
