#pragma checksum "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92bf241ba11a750375305e24fe4964a3b9dcebad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_StationReport), @"mvc.1.0.view", @"/Views/Admin/StationReport.cshtml")]
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
#line 1 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\_ViewImports.cshtml"
using SignUp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\_ViewImports.cshtml"
using SignUp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92bf241ba11a750375305e24fe4964a3b9dcebad", @"/Views/Admin/StationReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a3c01fb660863d570e8b4328aef83fde4d0ba8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_StationReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.StationReport>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
  
    ViewData["Title"] = "StationReport";
    Layout = "~/Views/Shared/_AdminPageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>StationReport</h1>\r\n\r\n<p>\r\n    \r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Station));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.UserLoggedIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
           Write(Html.DisplayFor(modelItem => item.Station));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserLoggedIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 42 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 43 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "E:\y2\y2 again\MMP\Dopple-earbuds\Views\Admin\StationReport.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication3.Models.StationReport>> Html { get; private set; }
    }
}
#pragma warning restore 1591
