#pragma checksum "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a22a9530c3ec8784d96d6baf3651bce16d5a818"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
#line 1 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\_ViewImports.cshtml"
using Henry_Inc.AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\_ViewImports.cshtml"
using Henry_Inc.AdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a22a9530c3ec8784d96d6baf3651bce16d5a818", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6e0f84ac2cdd9f916c566eaa0de165288068539", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Henry_Inc.ViewModels.Commons.PagedResultBase>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
  
    var urlTemplate = Url.Action() + "?pageIndex={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "pageIndex")
        {
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\r\n");
#nullable restore
#line 43 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 1451, "\"", 1490, 1);
#nullable restore
#line 46 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1458, urlTemplate.Replace("{0}", "1"), 1458, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1592, "\"", 1658, 1);
#nullable restore
#line 49 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1599, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1599, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trước</a>\r\n            </li>\r\n");
#nullable restore
#line 51 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\r\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 57 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 59 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 2097, "\"", 2124, 2);
            WriteAttributeValue("", 2105, "Trang", 2105, 5, true);
#nullable restore
#line 62 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 2110, i.ToString(), 2111, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2125, "\"", 2173, 1);
#nullable restore
#line 62 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2132, urlTemplate.Replace("{0}", i.ToString()), 2132, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 63 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 2343, "\"", 2378, 1);
#nullable restore
#line 68 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2351, Model.PageCount.ToString(), 2351, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2379, "\"", 2445, 1);
#nullable restore
#line 68 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2386, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 2386, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2547, "\"", 2609, 1);
#nullable restore
#line 71 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2554, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 2554, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\r\n            </li>\r\n");
#nullable restore
#line 73 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 75 "C:\Users\neopi\Desktop\E commerce lol Son\Henry-Inc\Henry-Inc.WebApp\Henry-Inc.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Henry_Inc.ViewModels.Commons.PagedResultBase> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
