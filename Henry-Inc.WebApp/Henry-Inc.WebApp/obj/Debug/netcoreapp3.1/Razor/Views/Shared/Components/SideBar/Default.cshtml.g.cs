#pragma checksum "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e11f7c30eb8b4ba49ec1e82211a3a53a671a2a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBar/Default.cshtml")]
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
#line 1 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e11f7c30eb8b4ba49ec1e82211a3a53a671a2a9", @"/Views/Shared/Components/SideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e83a8ae7c1eb9f4507c4dc4ed40a8820201efe86", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Henry_Inc.ViewModels.Catalogs.Categories.CategoryViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
  
    var culture = CultureInfo.CurrentCulture.Name;
    var categoryUrl = "";
    if (culture == "vi")
    {
        categoryUrl = "danh-muc";
    }
    else
    {
        categoryUrl = "categories";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"sidebar\" class=\"span3\">\r\n    <div class=\"well well-small\">\r\n        <a id=\"myCart\"");
            BeginWriteAttribute("href", " href=\"", 482, "\"", 503, 3);
            WriteAttributeValue("", 489, "/", 489, 1, true);
#nullable restore
#line 18 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 490, culture, 490, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 498, "/cart", 498, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img src=\"/themes/images/ico-cart.png\" alt=\"cart\">All Categories\r\n        </a>\r\n    </div>\r\n    <ul id=\"sideManu\" class=\"nav nav-tabs nav-stacked\">\r\n");
#nullable restore
#line 23 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
          
            var parents = Model.Where(x => x.ParentId == null);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
         for (int index = 0; index < parents.Count(); index++)
        {
            var parent = parents.ElementAt(index);
            var children = Model.Where(x => x.ParentId == parent.Id);
            if (children.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"subMenu open\">\r\n                    <a>");
#nullable restore
#line 33 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
                  Write(parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <ul>\r\n");
#nullable restore
#line 35 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
                         foreach (var child in children)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a class=\"active\"");
            BeginWriteAttribute("href", " href=\"", 1280, "\"", 1318, 4);
            WriteAttributeValue("", 1287, "/culture/", 1287, 9, true);
#nullable restore
#line 38 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1296, categoryUrl, 1296, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1308, "/", 1308, 1, true);
#nullable restore
#line 38 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1309, child.Id, 1309, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                                    <i class=\"icon-chevron-right\"></i>\r\n                                    ");
#nullable restore
#line 41 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
                               Write(child.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 44 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </li>\r\n                <br />\r\n");
#nullable restore
#line 48 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1893, "\"", 1933, 6);
            WriteAttributeValue("", 1900, "/", 1900, 1, true);
#nullable restore
#line 52 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1901, culture, 1901, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1909, "/", 1909, 1, true);
#nullable restore
#line 52 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1910, categoryUrl, 1910, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1922, "/", 1922, 1, true);
#nullable restore
#line 52 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
WriteAttributeValue("", 1923, parent.Id, 1923, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"
                                                           Write(parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 53 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.WebApp\Views\Shared\Components\SideBar\Default.cshtml"

            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <br />\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Henry_Inc.ViewModels.Catalogs.Categories.CategoryViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
