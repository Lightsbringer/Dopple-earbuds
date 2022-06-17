#pragma checksum "C:\Users\Jerem\source\repos\WebApplication3\WebApplication3\Views\Admin\AddStation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05081161722efd6b6ae4184c6982261f17d2678f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddStation), @"mvc.1.0.view", @"/Views/Admin/AddStation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05081161722efd6b6ae4184c6982261f17d2678f", @"/Views/Admin/AddStation.cshtml")]
    public class Views_Admin_AddStation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.AddInstruction>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Jerem\source\repos\WebApplication3\WebApplication3\Views\Admin\AddStation.cshtml"
  
    ViewData["Title"] = "AddInstruction";
    //https://localhost:44326/admin/addinstruction access this page
    Layout = "~/Views/Shared/_AdminPageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<h4>AddInstruction</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""AddInstruction"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Step"" class=""control-label""></label>
                <input asp-for=""Step"" class=""form-control"" />
                <span asp-validation-for=""Step"" class=""text-danger""></span>
            </div>
            <div class=""form-group mb-3"">
                <label asp-for=""Description"" class=""control-label""></label>
                <textarea asp-for=""Description"" class=""form-control"" rows=""3""></textarea>
                <span asp-validation-for=""Description"" class=""text-");
            WriteLiteral(@"danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SelectStation"" class=""control-label""></label>
                <select class=""form-select"" aria-label=""Default select example"">
                    <option selected>Choose station</option>
                    <option value=""1"">Station 1</option>
                    <option value=""2"">Station 2</</option>
                    <option value=""3"">Station 3</</option>
                </select>
            </div>
            <div class=""form-group"">
                <label asp-for=""Time"" class=""control-label""></label>
                <input asp-for=""Time"" class=""form-control"" />
                <span asp-validation-for=""Time"" class=""text-danger""></span>
            </div>
            <div class="" form-group mb-3"">
                <label for=""formFile"" class=""form-label"">Image</label>
                <input class=""form-control"" type=""file"" id=""formFile"">
            </div>
            <div class=""f");
            WriteLiteral(@"orm-group"">
                <input type=""submit"" value=""Add"" class=""btn btn-primary"" />
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary float-right"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.Models.AddInstruction> Html { get; private set; }
    }
}
#pragma warning restore 1591
