#pragma checksum "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Category), @"mvc.1.0.view", @"/Views/Product/Category.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e", @"/Views/Product/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e83a8ae7c1eb9f4507c4dc4ed40a8820201efe86", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategoryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal span6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
  
    ViewData["Title"] = Model.Category.Name + (Model.Products.PageIndex == 1 ? "" : " - " + _loc["Page"] + " " + Model.Products.PageIndex);
    ViewData["Description"] = Model.Category.Name + (Model.Products.PageIndex == 1 ? "" : " - " + _loc["Page"] + " " + Model.Products.PageIndex);
    Layout = "~/Views/Shared/_Layout.cshtml";
    var culture = CultureInfo.CurrentCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"breadcrumb\">\r\n    <li><a href=\"index.html\">Home</a> <span class=\"divider\">/</span></li>\r\n    <li class=\"active\">Products Name</li>\r\n</ul>\r\n<h3> ");
#nullable restore
#line 15 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small class=\"pull-right\"> 40 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e5704", async() => {
                WriteLiteral("available products");
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
            WriteLiteral(" </small></h3>\r\n<hr class=\"soft\" />\r\n<p>\r\n    Mô tả của ứng dụng (hard)\r\n</p>\r\n<hr class=\"soft\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e6803", async() => {
                WriteLiteral("\r\n    <div class=\"control-group\">\r\n        <label class=\"control-label alignL\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e7144", async() => {
                    WriteLiteral("Sort By");
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
                WriteLiteral(" </label>\r\n        <select>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e8217", async() => {
                    WriteLiteral("Priduct name A - Z");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e9255", async() => {
                    WriteLiteral("Priduct name Z - A");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e10293", async() => {
                    WriteLiteral("Priduct Stoke");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e11327", async() => {
                    WriteLiteral("Price Lowest first");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </select>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div id=""myTab"" class=""pull-right"">
    <a href=""#listView"" data-toggle=""tab""><span class=""btn btn-large""><i class=""icon-list""></i></span></a>
    <a href=""#blockView"" data-toggle=""tab""><span class=""btn btn-large btn-primary""><i class=""icon-th-large""></i></span></a>
</div>
<br class=""clr"" />
<div class=""tab-content"">
    <div class=""tab-pane"" id=""listView"">
");
#nullable restore
#line 40 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
         for (int i = 0; i < Model.Products.Items.Count; i++)
        {
            var item = Model.Products.Items[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"span2\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1897, "\"", 1957, 2);
#nullable restore
#line 45 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 1903, Configuration["BaseAddress"] + item.ThumbnailImage, 1903, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1956, "", 1957, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1958, "\"", 1974, 1);
#nullable restore
#line 45 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 1964, item.Name, 1964, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"span4\">\r\n                    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e15254", async() => {
                WriteLiteral("New | Available");
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
            WriteLiteral("</h3>\r\n                    <hr class=\"soft\" />\r\n                    <h5>");
#nullable restore
#line 50 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p>\r\n                        ");
#nullable restore
#line 52 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <a class=\"btn btn-small pull-right\" href=\"product_details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e17032", async() => {
                WriteLiteral("Xem chi tiết");
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
            WriteLiteral("</a>\r\n                    <br class=\"clr\" />\r\n                </div>\r\n                <div class=\"span3 alignR\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e18156", async() => {
                WriteLiteral("\r\n                        <h3> ");
#nullable restore
#line 59 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
                        Write(item.Price.ToString("C", culture));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                        <label class=""checkbox"">
                            <input type=""checkbox"">  Adds product to compair
                        </label><br />

                        <a href=""product_details.html"" class=""btn btn-large btn-primary""> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e19019", async() => {
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
                WriteLiteral(" <i class=\" icon-shopping-cart\"></i></a>\r\n                        <a href=\"product_details.html\" class=\"btn btn-large\"><i class=\"icon-zoom-in\"></i></a>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <hr class=\"soft\" />\r\n");
#nullable restore
#line 70 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"tab-pane  active\" id=\"blockView\">\r\n        <ul class=\"thumbnails\">\r\n");
#nullable restore
#line 75 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
             for (int i = 0; i < Model.Products.Items.Count; i++)
            {   
                var dfImg = "https://via.placeholder.com/625x800";
                var item = Model.Products.Items[i];
                var imageUrl = String.IsNullOrEmpty(item.ThumbnailImage) ? dfImg : (Configuration["BaseAddress"] + item.ThumbnailImage);


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"span3\">\r\n                    <div class=\"col-xl-3 col-lg-4 col-md-6 col-6\">\r\n                    <div class=\"thumbnail\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3820, "\"", 3868, 6);
            WriteAttributeValue("", 3827, "/", 3827, 1, true);
#nullable restore
#line 84 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3828, culture.Name, 3828, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3841, "/", 3841, 1, true);
#nullable restore
#line 84 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3842, _loc["products"], 3842, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3859, "/", 3859, 1, true);
#nullable restore
#line 84 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3860, item.Id, 3860, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 3925, "\"", 3940, 1);
#nullable restore
#line 85 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3931, imageUrl, 3931, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3941, "\"", 3957, 1);
#nullable restore
#line 85 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 3947, item.Name, 3947, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"800\" width=\"625\"/>\r\n                        </a>\r\n                        <div class=\"caption\">\r\n                            <h5>");
#nullable restore
#line 88 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>\r\n                                ");
#nullable restore
#line 90 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                            <h4 style=""text-align:center"">
                                <a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a>
                                <a class=""btn"" href=""#"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d0f7513963a61a8b62fd76d0a4c5f42fd8b527e25468", async() => {
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
            WriteLiteral(" <i class=\"icon-shopping-cart\"></i></a>\r\n                                <a class=\"btn btn-primary\" href=\"#\">");
#nullable restore
#line 95 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
                                                               Write(item.Price.ToString("C", culture));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h4>\r\n                        </div>\r\n                    </div>\r\n                    </div>\r\n\r\n                </li>\r\n");
#nullable restore
#line 102 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        <hr class=\"soft\" />\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 107 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Product\Category.cshtml"
Write(await Component.InvokeAsync("Pager", Model.Products));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br class=\"clr\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCategoryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
