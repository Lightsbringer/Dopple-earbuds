#pragma checksum "C:\Users\Jerem\source\repos\WebApplication3\WebApplication3\Views\Admin\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ce571054f2ba2a5589a5146cf33892a5eb5ee05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Report), @"mvc.1.0.view", @"/Views/Admin/Report.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ce571054f2ba2a5589a5146cf33892a5eb5ee05", @"/Views/Admin/Report.cshtml")]
    public class Views_Admin_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Jerem\source\repos\WebApplication3\WebApplication3\Views\Admin\Report.cshtml"
  
    ViewData["Title"] = "Report";
    //https://localhost:44326/admin/report access this page
    Layout = "~/Views/Shared/_AdminPageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">OrderId</th>
            <th scope=""col"">TagId</th>
            <th scope=""col"">StationId</th>
            <th scope=""col"">Result</th>
            <th scope=""col"">Status</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">1</th>
            <td>234</td>
            <td>8</td>
            <td>Pass</td>
            <td>Complete</td>
        </tr>
        <tr>
            <th scope=""row"">2</th>
            <td>274</td>
            <td>7</td>
            <td>Fail</td>
            <td>Incomplete</td>
        </tr>
        <tr>
            <th scope=""row"">3</th>
            <td>224</td>
            <td>8</td>
            <td>Pass</td>
            <td>Completed</td>
        </tr>
        <tr>
            <th scope=""row"">2</th>
            <td>274</td>
            <td>7</td>
            <td>Fail</td>
            <td>Incomplete</td>
        </tr>
        <tr");
            WriteLiteral(@">
            <th scope=""row"">3</th>
            <td>224</td>
            <td>8</td>
            <td>Pass</td>
            <td>Completed</td>
        </tr>
        <tr>
            <th scope=""row"">2</th>
            <td>274</td>
            <td>7</td>
            <td>Fail</td>
            <td>Incomplete</td>
        </tr>
        <tr>
            <th scope=""row"">3</th>
            <td>224</td>
            <td>8</td>
            <td>Pass</td>
            <td>Completed</td>
        </tr>
    </tbody>
</table>

");
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
