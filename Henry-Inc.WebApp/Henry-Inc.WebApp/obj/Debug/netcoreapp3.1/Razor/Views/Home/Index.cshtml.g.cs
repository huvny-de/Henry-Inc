#pragma checksum "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8de16ea4d79e689b8ef0b76b7a4570548a3acd69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\_ViewImports.cshtml"
using Henry_Inc.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\_ViewImports.cshtml"
using Henry_Inc.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
using Henry_Inc.ViewModels.Catalogs.Products;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de16ea4d79e689b8ef0b76b7a4570548a3acd69", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e83a8ae7c1eb9f4507c4dc4ed40a8820201efe86", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::LazZiya.ExpressLocalization.TagHelpers.LocalizeAttributesTagHelper __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper;
        private global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var culture = CultureInfo.CurrentCulture.Name;
    var productUrl = "";
    if (culture == "vi")
    {
        productUrl = "san-pham";
    }
    else
    {
        productUrl = "products";
    }

#line default
#line hidden
#nullable disable
            DefineSection("slider", async() => {
                WriteLiteral("\r\n    <div id=\"carouselBlk\">\r\n        <div id=\"myCarousel\" class=\"carousel slide\">\r\n            <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 22 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                 for (int index = 0; index < Model.Slides.Count; index++)
                {
                    var slide = Model.Slides[index];

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div");
                BeginWriteAttribute("class", " class=\"", 780, "\"", 822, 2);
                WriteAttributeValue("", 788, "item", 788, 4, true);
#nullable restore
#line 25 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 792, index == 0 ? "active" : "", 793, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"container\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 905, "\"", 922, 1);
#nullable restore
#line 27 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 912, slide.Url, 912, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img style=\"width:100%\"");
                BeginWriteAttribute("src", " src=\"", 947, "\"", 965, 1);
#nullable restore
#line 27 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 953, slide.Image, 953, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 966, "\"", 983, 1);
#nullable restore
#line 27 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 972, slide.Name, 972, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></a>\r\n                            <div class=\"carousel-caption\">\r\n                                <h4>");
#nullable restore
#line 29 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                               Write(slide.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 30 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                              Write(slide.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 34 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <a class=\"left carousel-control\" href=\"#myCarousel\" data-slide=\"prev\">&lsaquo;</a>\r\n            <a class=\"right carousel-control\" href=\"#myCarousel\" data-slide=\"next\">&rsaquo;</a>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("<div class=\"well well-small\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("h4", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8de16ea4d79e689b8ef0b76b7a4570548a3acd698380", async() => {
                WriteLiteral("Featured Products<small class=\"pull-right\">200+ featured products</small>");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeAttributesTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper);
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize = true;
            __tagHelperExecutionContext.AddTagHelperAttribute("localize-content", __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"row-fluid\">\r\n        <div id=\"featured\" class=\"carousel slide\">\r\n            <div class=\"carousel-inner\">\r\n\r\n");
#nullable restore
#line 47 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                   List<List<ProductViewModel>> featuredProducts = new List<List<ProductViewModel>>();
                    List<ProductViewModel> featuredPart = new List<ProductViewModel>(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                 for (int index = 0; index < Model.FeaturedProducts.Count; index++)
                {
                    featuredPart.Add(Model.FeaturedProducts[index]);
                    if (featuredPart.Count == 4 || Model.FeaturedProducts.Count < 4)
                    {
                        featuredProducts.Add(featuredPart);
                        featuredPart = new List<ProductViewModel>();
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                 for (int index = 0; index < featuredProducts.Count; index++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 2563, "\"", 2601, 2);
            WriteAttributeValue("", 2571, "item", 2571, 4, true);
#nullable restore
#line 62 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2575, index == 0?"active":"", 2576, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <ul class=\"thumbnails\">\r\n");
#nullable restore
#line 64 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                             foreach (var item in featuredProducts[index])
                            {


                                var url = $"/{culture}/{@productUrl}/{item.Id}";

                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"span3\">\r\n                                    <div class=\"thumbnail\">\r\n                                        <i class=\"tag\"></i>\r\n");
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 3271, "\"", 3282, 1);
#nullable restore
#line 75 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3278, url, 3278, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 3288, "\"", 3347, 1);
#nullable restore
#line 75 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3294, Configuration["BaseAddress"] + item.ThumbnailImage, 3294, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3348, "\"", 3364, 1);
#nullable restore
#line 75 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3354, item.Name, 3354, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                                        <div class=\"caption\">\r\n                                            <h5>");
#nullable restore
#line 77 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8de16ea4d79e689b8ef0b76b7a4570548a3acd6914046", async() => {
                WriteLiteral("VIEW");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeAttributesTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize = true;
            __tagHelperExecutionContext.AddTagHelperAttribute("localize-content", __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <span class=\"pull-right\">");
#nullable restore
#line 78 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                                                                                                                     Write(item.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                                        </div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 82 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 85 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <a class=""left carousel-control"" href=""#featured"" data-slide=""prev"">‹</a>
            <a class=""right carousel-control"" href=""#featured"" data-slide=""next"">›</a>
        </div>
    </div>
</div>
<h4>Latest Products </h4>
<ul class=""thumbnails"">
");
#nullable restore
#line 94 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
     foreach (var item in Model.LastedProducts)
    {
        var url = $"/{culture}/{@productUrl}/{item.Id}";
        //var url = $"/{culture}/{_loc["productUrl"]}/{item.Id}";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"span3\">\r\n            <div class=\"thumbnail\">\r\n");
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 4537, "\"", 4548, 1);
#nullable restore
#line 101 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 4544, url, 4544, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 4554, "\"", 4613, 1);
#nullable restore
#line 101 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 4560, Configuration["BaseAddress"] + item.ThumbnailImage, 4560, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4614, "\"", 4630, 1);
#nullable restore
#line 101 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 4620, item.Name, 4620, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                <div class=\"caption\">\r\n                    <h5>");
#nullable restore
#line 103 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p>\r\n                        ");
#nullable restore
#line 105 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <h4 style=\"text-align:center\">\r\n                        <a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 4902, "\"", 4913, 1);
#nullable restore
#line 108 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 4909, url, 4909, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"icon-zoom-in\"></i>\r\n                        </a> <a class=\"btn btn-add-cart\" data-id=\"");
#nullable restore
#line 110 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8de16ea4d79e689b8ef0b76b7a4570548a3acd6920024", async() => {
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
            WriteLiteral(" <i class=\"icon-shopping-cart\"></i></a>\r\n                        <a class=\"btn btn-primary\" href=\"#\">");
#nullable restore
#line 111 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </h4>\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 116 "C:\Henry\Projects\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
