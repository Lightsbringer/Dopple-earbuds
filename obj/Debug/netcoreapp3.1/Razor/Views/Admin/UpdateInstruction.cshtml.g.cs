#pragma checksum "C:\Users\Jerem\Desktop\New folder\Dopple-earbuds\Views\Admin\UpdateInstruction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1ff91e66ad409818a9e21ce5ce3c103f48baeea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateInstruction), @"mvc.1.0.view", @"/Views/Admin/UpdateInstruction.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ff91e66ad409818a9e21ce5ce3c103f48baeea", @"/Views/Admin/UpdateInstruction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a3c01fb660863d570e8b4328aef83fde4d0ba8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateInstruction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Jerem\Desktop\New folder\Dopple-earbuds\Views\Admin\UpdateInstruction.cshtml"
  
    ViewData["Title"] = "UpdateInstruction";
    //https://localhost:44326/admin/updateinstruction access this page
    Layout = "~/Views/Shared/_AdminPageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Number of steps</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Total time</th>
            <th scope=""col"">Number Of Image</th>
            <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">Sub-Assembly E-Module - input</th>
            <td>3</td>
            <td>
                Sub-assembled Bamboo E-Module left &
                right, ready for customization of the
                faceplates.
            </td>
            <td>45.5 S</td>
            <td>4</td>
            <td>
                <input type=""submit"" value=""Edit"" class=""btn btn-primary"" />
                <input type=""submit"" value=""Delete"" class=""btn btn-danger"" />
            </td>
        </tr>
        <tr>
            <th scope=""row"">Sub-Assembly Cradle - input</th>
            <td>4</td>
      ");
            WriteLiteral(@"      <td>
                Sub-assembled Bamboo Cradle, ready for
                customization of Visual bottom and Outer Top.
            </td>
            <td>35.6 S</td>
            <td>4</td>
            <td>
                <input type=""submit"" value=""Edit"" class=""btn btn-primary "" />
                <input type=""submit"" value=""Delete"" class=""btn btn-danger"" />
            </td>
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
