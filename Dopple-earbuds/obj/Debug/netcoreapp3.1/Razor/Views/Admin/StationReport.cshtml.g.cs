#pragma checksum "C:\Users\Gebruiker\Downloads\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e (2)\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e\Views\Admin\StationReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaf8c2bedc698dd433ae078011b6a22e6633c4c5"
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
#line 1 "C:\Users\Gebruiker\Downloads\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e (2)\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e\Views\_ViewImports.cshtml"
using SignUp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gebruiker\Downloads\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e (2)\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e\Views\_ViewImports.cshtml"
using SignUp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaf8c2bedc698dd433ae078011b6a22e6633c4c5", @"/Views/Admin/StationReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fdec876d917d4ac26de859f9caa5b4d705828d7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_StationReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.APIDTOs.StationEntity>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Gebruiker\Downloads\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e (2)\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e\Views\Admin\StationReport.cshtml"
  
    ViewData["Title"] = "StationReport";
    Layout = "~/Views/Shared/_AdminPageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>StationReport</h1>

<p>
    
</p>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Station#</th>
            <th scope=""col"">Status</th>
            <th scope=""col"">Operator at Station</th>
        </tr>
    </thead>
    <tbody>
        <tr>
    <td>");
#nullable restore
#line 23 "C:\Users\Gebruiker\Downloads\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e (2)\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e\Views\Admin\StationReport.cshtml"
   Write(Model.StationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 24 "C:\Users\Gebruiker\Downloads\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e (2)\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e\Views\Admin\StationReport.cshtml"
   Write(Model.StatusStation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 25 "C:\Users\Gebruiker\Downloads\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e (2)\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e\Views\Admin\StationReport.cshtml"
   Write(Html.ActionLink("Update To Offline", "Update", new { id = Model.StationId, status = "OFFLIN" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 26 "C:\Users\Gebruiker\Downloads\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e (2)\Dopple-earbuds-85cbd56230ddc2d8aa663360008f879a9d537f7e\Views\Admin\StationReport.cshtml"
   Write(Html.ActionLink("Update To Working", "Update", new { id = Model.StationId , status = "WORKIN" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.APIDTOs.StationEntity> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
