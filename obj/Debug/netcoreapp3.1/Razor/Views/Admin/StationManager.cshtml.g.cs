#pragma checksum "C:\Users\Jerem\Desktop\New folder\Dopple-earbuds\Views\Admin\StationManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6f73e1906ad255422a61d1bd78ce91e9cc9f3c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_StationManager), @"mvc.1.0.view", @"/Views/Admin/StationManager.cshtml")]
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
#line 1 "C:\Users\Jerem\Desktop\New folder\Dopple-earbuds\Views\_ViewImports.cshtml"
using SignUp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jerem\Desktop\New folder\Dopple-earbuds\Views\_ViewImports.cshtml"
using SignUp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6f73e1906ad255422a61d1bd78ce91e9cc9f3c4", @"/Views/Admin/StationManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a3c01fb660863d570e8b4328aef83fde4d0ba8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_StationManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jerem\Desktop\New folder\Dopple-earbuds\Views\Admin\StationManager.cshtml"
  
    ViewData["Title"] = "StationManager";
    //https://localhost:44326/admin/StationManager access this page

    Layout = "~/Views/Shared/_AdminPageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Station#</th>
            <th scope=""col"">User Logged In</th>
            <th scope=""col"">Status</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">1</th>
            <td>1</td>
            <td>Occupied</td>
            <td></td>
        </tr>
        <tr>
            <th scope=""row"">2</th>
            <td>3</td>
            <td>Occupied</td>
            <td></td>
        </tr>
    </tbody>
</table>
<button type=""button"" class=""btn-primary""");
            BeginWriteAttribute("href", " href=\"", 769, "\"", 776, 0);
            EndWriteAttribute();
            WriteLiteral(">Create Station</button>\r\n");
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
