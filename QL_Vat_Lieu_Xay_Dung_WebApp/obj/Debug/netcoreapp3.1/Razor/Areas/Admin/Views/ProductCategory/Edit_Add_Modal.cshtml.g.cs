#pragma checksum "D:\DoAnMonHoc\QL_Vat_Lieu_Xay_Dung\QL_Vat_Lieu_Xay_Dung_WebApp\Areas\Admin\Views\ProductCategory\Edit_Add_Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe62af588832d8834008f03f91f3913d616b9851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductCategory_Edit_Add_Modal), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductCategory/Edit_Add_Modal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe62af588832d8834008f03f91f3913d616b9851", @"/Areas/Admin/Views/ProductCategory/Edit_Add_Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10214bc65770daa23f4d292c05b20277ead16a9f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductCategory_Edit_Add_Modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral(@"<div id=""modal-add-edit"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Product Category Update</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""horizontal-form"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe62af588832d8834008f03f91f3913d616b98516830", async() => {
                WriteLiteral(@"

                        <div class=""form-group"">
                            <input type=""hidden"" id=""hidId"" value=""0"" />
                            <label for=""txtName"" class=""col-md-3 col-sm-3 control-label"" style=""padding-right:0"">Name</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input type=""text"" name=""txtName"" class=""form-control"" id=""txtName"" placeholder=""Name of category"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""col-md-3 col-sm-3 control-label"" style=""padding-right:0"">Parent</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input id=""ddlCategoryId"" class=""form-control"" name=""ddlCategoryId""");
                BeginWriteAttribute("value", " value=\"", 1564, "\"", 1572, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtAlias"" class=""col-md-4 col-sm-3 control-label"" style=""padding-right:0"">Alias</label>
                            <div class=""col-md-8 col-sm-9"">
                                <input type=""text"" name=""txtAlias"" class=""form-control"" id=""txtAlias"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtOrder"" class=""col-md-3 col-sm-3 control-label"" style=""padding-right:0"">Sort Order</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input type=""number"" min=""1"" onkeyup=""var result = document.getElementById('txtOrder');var qty = result.value;if (qty < 0 || isNaN( qty )) result.value = 0;return false;"" min=""0"" name=""txtOrder"" class=""form-control"" id=""txtOrder"">
                            </di");
                WriteLiteral(@"v>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtHomeOrder"" class=""col-md-3 col-sm-3 control-label"" style=""padding-right:0"">Home Order</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input type=""number"" min=""1"" onkeyup=""var result = document.getElementById('txtHomeOrder');var qty = result.value;if (qty < 0 || isNaN( qty )) result.value = 0;return false;"" min=""0"" name=""txtHomeOrder"" class=""form-control"" id=""txtHomeOrder"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtImage"" class=""col-md-3 col-sm-3 control-label"" style=""padding-right:0"">Images</label>
                            <div class=""col-md-9 col-sm-9"">
                                <div class=""input-group"">
                                    <input type=""text"" name=""txtImage"" class=""form-control"" id=");
                WriteLiteral(@"""txtImage"" />
                                    <input type=""file"" id=""fileInputImage"" style=""display:none"" />
                                    <span class=""input-group-btn"">
                                        <input type=""button"" id=""btnSelectImg"" class=""btn btn-default"" value=""Browser"" />
                                    </span>
                                </div><!-- /input-group -->
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtSeoPageTitle"" class=""col-md-3 col-sm-3 control-label"" style=""padding-right:0"">SEO Title</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input type=""text"" name=""txtSeoPageTitle"" class=""form-control"" id=""txtSeoPageTitle"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtSeoAlias"" clas");
                WriteLiteral(@"s=""col-md-3 col-sm-3 control-label"" style=""padding-right:0"">URL SEO</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input type=""text"" name=""txtSeoAlias"" class=""form-control"" id=""txtSeoAlias"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtSeoKeyword"" class=""col-md-3 col-sm-3 control-label"" style=""padding-right:0"">SEO Keyword</label>
                            <div class=""col-md-9 col-sm-9"">
                                <input type=""text"" name=""txtSeoKeyword"" class=""form-control"" id=""txtSeoKeyword"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""txtSeoDescription"" class=""col-md-3 col-sm-3 control-label"" style=""padding-right:0"">SEO Description</label>
                            <div class=""col-md-9 col-sm-9"">
                ");
                WriteLiteral(@"                <textarea rows=""3"" name=""txtSeoDescription"" class=""form-control"" id=""txtSeoDescription""></textarea>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-md-9 col-sm-9"">
                                <div class=""checkbox"">
                                    <label>
                                        <input type=""checkbox"" checked=""checked"" id=""ckStatus"">
                                        <span class=""text"">Active.</span>
                                    </label>
                                    <label>
                                        <input type=""checkbox"" id=""ckShowHome"">
                                        <span class=""text"">Show on home.</span>
                                    </label>
                                </div>
                            </div>
                        </div>
                    ");
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
            WriteLiteral(@"
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""btnCancel"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" id=""btnSave"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591