#pragma checksum "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\Product\Edit_Add_Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3f0c7e22a3854a66eb678d573103da282113680"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Edit_Add_Modal), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Edit_Add_Modal.cshtml")]
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
#line 1 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_Services.ViewModels.System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\_ViewImports.cshtml"
using QL_Vat_Lieu_Xay_Dung_WebApp.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3f0c7e22a3854a66eb678d573103da282113680", @"/Areas/Admin/Views/Product/Edit_Add_Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10214bc65770daa23f4d292c05b20277ead16a9f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Edit_Add_Modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmMaintainance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""modal-add-edit"" class=""bootbox modal fade modal-darkorange in"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog  modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Add Edit Product</h4>
                <button type=""button"" class=""bootbox-close-button close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
            </div>
            <div class=""modal-body"">
                <div id=""horizontal-form"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3f0c7e22a3854a66eb678d573103da2821136806706", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""hidden"" id=""hidId"" value=""0"" />
                            <input type=""hidden"" id=""hidDateCreated"" value=""0"" />
                            <label for=""txtName"" class=""col-md-3 col-sm-3 control-label "" style=""padding-right:0"">Name</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input type=""text"" name=""txtName"" class=""form-control"" id=""txtName"">
                            </div>
                        </div>
                        <br />
                        <div class=""form-group"">
                            <label class=""col-md-3 col-sm-3 control-label "" style=""padding-right:0"">Category</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input id=""ddlCategoryId"" required class=""form-control form-control-category"" name=""ddlCategoryId""");
                BeginWriteAttribute("value", " value=\"", 1603, "\"", 1611, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n");
                WriteLiteral(@"                        <div class=""form-group"">
                            <label class=""col-md-3 col-sm-3 control-label "" style=""padding-right:0"">Brand</label>
                            <div class=""col-md-9 col-sm-9"">
                                <select required class=""form-control form-control-category"" id=""ddlBrandId"">
                                </select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtDesc"" class=""col-md-3 col-sm-3 control-label "" style=""padding-right:0"">Description</label>
                            <div class=""col-md-６ col-sm-9"">
                                <textarea rows=""4"" name=""txtDesc"" class=""form-control"" id=""txtDesc""></textarea>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtUnit"" class=""col-md-3 col-sm-3 control-label "" style=""pad");
                WriteLiteral(@"ding-right:0"">Unit</label>
                            <div class=""col-sm-9"">
                                <input type=""text"" name=""txtUnit"" class=""form-control"" id=""txtUnit"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-3 col-sm-3 control-label "">Sell price</label>
                            <div class=""col-md-3 col-sm-3"">
                                <input type=""text"" onkeyup=""var result = document.getElementsById('txtPrice');var qty = result.value;if (qty < 0 || isNaN( qty )) result.value = 0;"" name=""txtPrice"" class=""form-control"" id=""txtPrice"">
                            </div>

                            <label class=""col-md-3 col-sm-3 control-label"">Promotion</label>
                            <div class=""col-md-3 col-sm-3"">
                                <input type=""text"" onkeyup=""var result = document.getElementsById('txtPromotionPrice');var qty = result.valu");
                WriteLiteral(@"e;if (qty < 0 || isNaN( qty )) result.value = 0;"" name=""txtPromotionPrice"" class=""form-control"" id=""txtPromotionPrice"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtImage"" class=""col-md-3 col-sm-3 control-label "" style=""padding-right:0"">Image</label>
                            <div class=""col-sm-9"">
                                <div class=""input-group"">
                                    <input type=""text"" readonly name=""txtImage"" class=""form-control"" id=""txtImage"" />
                                    <input type=""file"" id=""fileInputImage"" style=""display:none"" />
                                    <span class=""input-group-btn"">
                                        <input type=""button"" id=""btnSelectImg"" class=""btn btn-warning"" value=""Browser"" />
                                    </span>
                                </div>
                            </div>
             ");
                WriteLiteral(@"           </div>
                        <div class=""form-group"">
                            <label for=""txtContent"" class=""col-md-3 col-sm-3 control-label "" style=""padding-right:0"">Content</label>
                            <div class=""col-md-9 col-sm-9"">
                                <textarea id=""txtContent"" rows=""6"" class=""form-control""></textarea>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtSeoPageTitle"" class=""col-md-3 col-sm-3 control-label "" style=""padding-right:0"">SEO title</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input type=""text"" name=""txtSeoPageTitle"" class=""form-control"" id=""txtSeoPageTitle"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtSeoAlias"" class=""col-md-3 col-sm-3 control-label "" style=""pa");
                WriteLiteral(@"dding-right:0"">SEO Url</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input type=""text"" name=""txtSeoAlias"" class=""form-control"" id=""txtSeoAlias"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtMetaKeyWord"" class=""col-md-3 col-sm-3 control-label "" style=""padding-right:0"">SEO Keywords</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input type=""text"" name=""txtMetaKeyWord"" class=""form-control"" id=""txtMetaKeyWord"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtMetaDescription"" class=""col-md-3 col-sm-3 control-label "" style=""padding-right:0"">SEO Description</label>
                            <div class=""col-md-9 col-sm-9"">
                                <textarea rows=""3"" nam");
                WriteLiteral(@"e=""txtMetaDescription"" class=""form-control"" id=""txtMetaDescription""></textarea>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtTag"" class=""col-md-3 col-sm-3 control-label "" style=""padding-right:0"">Tag (separated by comma)</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input type=""text"" name=""txtTag"" class=""form-control"" id=""txtTag"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-md-9 col-sm-9"">
                                <div class=""checkbox"">
                                    <label>
                                        <input type=""checkbox"" checked=""checked"" id=""ckStatus"">
                                        <span class=""text"">Active.</span>
                                    </label>
   ");
                WriteLiteral(@"                                 <label>
                                        <input type=""checkbox"" id=""ckHot"">
                                        <span class=""text"">Hot product</span>
                                    </label>

                                    <label>
                                        <input type=""checkbox"" checked=""checked"" id=""ckShowHome"">
                                        <span class=""text"">Show on home</span>
                                    </label>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-md-9 col-sm-9"">
                                <button type=""button"" id=""btnSave"" class=""btn btn-success"">Save changes</button>
                                <button type=""button"" id=""btnCancel"" data-dismiss=""modal"" class=""btn btn-danger"">Cancel</button>
                            </");
                WriteLiteral("div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
