#pragma checksum "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e45e1cba03a4a6922e5bc4dc4bfde3af6e72b674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\_ViewImports.cshtml"
using Henry_Inc.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\_ViewImports.cshtml"
using Henry_Inc.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45e1cba03a4a6922e5bc4dc4bfde3af6e72b674", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e83a8ae7c1eb9f4507c4dc4ed40a8820201efe86", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var culture = CultureInfo.CurrentCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"breadcrumb\">\r\n    <li><a href=\"/\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e1cba03a4a6922e5bc4dc4bfde3af6e72b6745789", async() => {
                WriteLiteral("Home");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a> <span class=\"divider\">/</span></li>\r\n");
            WriteLiteral("    <li class=\"active\">");
#nullable restore
#line 13 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
                  Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n<div class=\"modal-fullscreen\">\r\n    <div class=\"quick_view_wrap\">\r\n        <div class=\"quick_view_thmb\">\r\n            <div class=\"quick_view_slide\">\r\n                <div id=\"gallery\" class=\"single_view_slide\">\r\n");
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 938, "\"", 1007, 1);
#nullable restore
#line 21 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 945, Configuration["BaseAddress"] + Model.Product.ThumbnailImage, 945, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1008, "\"", 1035, 1);
#nullable restore
#line 21 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1016, Model.Product.Name, 1016, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1067, "\"", 1135, 1);
#nullable restore
#line 22 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1073, Configuration["BaseAddress"] + Model.Product.ThumbnailImage, 1073, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\"");
            BeginWriteAttribute("alt", " alt=\"", 1155, "\"", 1180, 1);
#nullable restore
#line 22 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1161, Model.Product.Name, 1161, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </a>
                    <div id=""differentview"" class=""moreOptopm carousel slide"">
                        <div class=""carousel-inner"">
                            <div class=""item active"">
                                <a href=""themes/images/products/large/f1.jpg""> <img style=""width:29%"" src=""themes/images/products/large/f1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1544, "\"", 1550, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                <a href=\"themes/images/products/large/f2.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1703, "\"", 1709, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                <a href=\"themes/images/products/large/f3.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1862, "\"", 1868, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                            </div>\r\n                            <div class=\"item\">\r\n                                <a href=\"themes/images/products/large/f3.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2105, "\"", 2111, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                <a href=\"themes/images/products/large/f1.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2264, "\"", 2270, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                <a href=\"themes/images/products/large/f2.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2423, "\"", 2429, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                            </div>
                        </div>
                        <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">‹</a>
                        <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">›</a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""quick_view_capt"">
            <div class=""prd_details"">

                <div class=""prt_01 mb-1""><span class=""text-light bg-info rounded px-2 py-1"">");
#nullable restore
#line 47 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
                                                                                       Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                <div class=\"prt_02 mb-2\">\r\n                    <h2 class=\"ft-bold mb-1\">");
#nullable restore
#line 49 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
                                        Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <div class=""text-left"">
                        <div class=""star-rating align-items-center d-flex justify-content-left mb-1 p-0"">
                            <i class=""fas fa-star filled""></i>
                            <i class=""fas fa-star filled""></i>
                            <i class=""fas fa-star filled""></i>
                            <i class=""fas fa-star filled""></i>
                            <i class=""fas fa-star""></i>
                            <span class=""small"">(412 Reviews)</span>
                        </div>
                        <div class=""elis_rty"">
                            <span class=""ft-bold theme-cl fs-lg mr-2"">$ ");
#nullable restore
#line 60 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
                                                                   Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 61 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
                              
                                var remainText = @Model.Product.Stock == 0 ? "out of stock" : (@Model.Product.Stock + "remaining");
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"ft-regular text-danger bg-light-danger py-1 px-2 fs-sm\">");
#nullable restore
#line 64 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
                                                                                            Write(remainText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"prt_03 mb-3\">\r\n                    <p>");
#nullable restore
#line 70 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
                  Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>

                <div class=""prt_04 mb-2"">
                    <p class=""d-flex align-items-center mb-0 text-dark ft-medium"">Color:</p>
                    <div class=""text-left"">
                        <div class=""form-check form-option form-check-inline mb-1"">
                            <input class=""form-check-input"" type=""radio"" name=""color8"" id=""white8"">
                            <label class=""form-option-label rounded-circle"" for=""white8""><span class=""form-option-color rounded-circle blc7""></span></label>
                        </div>
                        <div class=""form-check form-option form-check-inline mb-1"">
                            <input class=""form-check-input"" type=""radio"" name=""color8"" id=""blue8"">
                            <label class=""form-option-label rounded-circle"" for=""blue8""><span class=""form-option-color rounded-circle blc2""></span></label>
                        </div>
                        <div class=""form-check form-option f");
            WriteLiteral(@"orm-check-inline mb-1"">
                            <input class=""form-check-input"" type=""radio"" name=""color8"" id=""yellow8"">
                            <label class=""form-option-label rounded-circle"" for=""yellow8""><span class=""form-option-color rounded-circle blc5""></span></label>
                        </div>
                        <div class=""form-check form-option form-check-inline mb-1"">
                            <input class=""form-check-input"" type=""radio"" name=""color8"" id=""pink8"">
                            <label class=""form-option-label rounded-circle"" for=""pink8""><span class=""form-option-color rounded-circle blc3""></span></label>
                        </div>
                        <div class=""form-check form-option form-check-inline mb-1"">
                            <input class=""form-check-input"" type=""radio"" name=""color8"" id=""red"">
                            <label class=""form-option-label rounded-circle"" for=""red""><span class=""form-option-color rounded-circle blc4""></span></la");
            WriteLiteral(@"bel>
                        </div>
                        <div class=""form-check form-option form-check-inline mb-1"">
                            <input class=""form-check-input"" type=""radio"" name=""color8"" id=""green"">
                            <label class=""form-option-label rounded-circle"" for=""green""><span class=""form-option-color rounded-circle blc6""></span></label>
                        </div>
                    </div>
                </div>

                <div class=""prt_04 mb-4"">
                    <p class=""d-flex align-items-center mb-0 text-dark ft-medium"">Size:</p>
                    <div class=""text-left pb-0 pt-2"">
                        <div class=""form-check size-option form-option form-check-inline mb-2"">
                            <input class=""form-check-input"" type=""radio"" name=""size"" id=""28""");
            BeginWriteAttribute("checked", " checked=\"", 7222, "\"", 7232, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <label class=""form-option-label"" for=""28"">28</label>
                        </div>
                        <div class=""form-check form-option size-option  form-check-inline mb-2"">
                            <input class=""form-check-input"" type=""radio"" name=""size"" id=""30"">
                            <label class=""form-option-label"" for=""30"">30</label>
                        </div>
                        <div class=""form-check form-option size-option  form-check-inline mb-2"">
                            <input class=""form-check-input"" type=""radio"" name=""size"" id=""32"">
                            <label class=""form-option-label"" for=""32"">32</label>
                        </div>
                        <div class=""form-check form-option size-option  form-check-inline mb-2"">
                            <input class=""form-check-input"" type=""radio"" name=""size"" id=""34"">
                            <label class=""form-option-label"" for=""34"">34</label>
                  ");
            WriteLiteral(@"      </div>
                        <div class=""form-check form-option size-option  form-check-inline mb-2"">
                            <input class=""form-check-input"" type=""radio"" name=""size"" id=""36"">
                            <label class=""form-option-label"" for=""36"">36</label>
                        </div>
                        <div class=""form-check form-option size-option  form-check-inline mb-2"">
                            <input class=""form-check-input"" type=""radio"" name=""size"" id=""38"">
                            <label class=""form-option-label"" for=""38"">38</label>
                        </div>
                        <div class=""form-check form-option size-option  form-check-inline mb-2"">
                            <input class=""form-check-input"" type=""radio"" name=""size"" id=""40"">
                            <label class=""form-option-label"" for=""40"">40</label>
                        </div>
                    </div>
                </div>

                <div class=""prt_05 ");
            WriteLiteral(@"mb-4"">
                    <div class=""form-row mb-7"">
                        <div class=""col-12 col-lg-auto"">
                            <!-- Quantity -->
                            <select class=""mb-2 custom-select"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e1cba03a4a6922e5bc4dc4bfde3af6e72b67420610", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e1cba03a4a6922e5bc4dc4bfde3af6e72b67421880", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e1cba03a4a6922e5bc4dc4bfde3af6e72b67423067", async() => {
                WriteLiteral("3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e1cba03a4a6922e5bc4dc4bfde3af6e72b67424254", async() => {
                WriteLiteral("4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e1cba03a4a6922e5bc4dc4bfde3af6e72b67425441", async() => {
                WriteLiteral("5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <div class=\"col-12 col-lg\">\r\n                            <!-- Submit -->\r\n                            <a class=\"btn btn-add-cart\" data-id=\"");
#nullable restore
#line 151 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Detail.cshtml"
                                                            Write(Model.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e1cba03a4a6922e5bc4dc4bfde3af6e72b67427170", async() => {
                WriteLiteral("Add to");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" <i class=""icon-shopping-cart""></i></a>

                        </div>
                    </div>
                </div>

                <div class=""prt_06"">
                    <p class=""mb-0 d-flex align-items-center"">
                        <span class=""mr-4"">Share:</span>
                        <a class=""d-inline-flex align-items-center justify-content-center p-3 gray circle fs-sm text-muted mr-2"" href=""#!"">
                            <i class=""fab fa-twitter position-absolute""></i>
                        </a>
                        <a class=""d-inline-flex align-items-center justify-content-center p-3 gray circle fs-sm text-muted mr-2"" href=""#!"">
                            <i class=""fab fa-facebook-f position-absolute""></i>
                        </a>
                        <a class=""d-inline-flex align-items-center justify-content-center p-3 gray circle fs-sm text-muted"" href=""#!"">
                            <i class=""fab fa-pinterest-p position-absolute""></i>
                ");
            WriteLiteral("        </a>\r\n                    </p>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
