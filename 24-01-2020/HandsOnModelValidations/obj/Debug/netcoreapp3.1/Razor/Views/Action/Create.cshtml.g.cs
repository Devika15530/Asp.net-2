#pragma checksum "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6b6a0aed7c6737d2e630c50f06cfae9f6944539"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Action_Create), @"mvc.1.0.view", @"/Views/Action/Create.cshtml")]
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
#line 1 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\_ViewImports.cshtml"
using HandsOnModelValidations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\_ViewImports.cshtml"
using HandsOnModelValidations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b6a0aed7c6737d2e630c50f06cfae9f6944539", @"/Views/Action/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca8e6c37953a5766f725359e896b8bd6bfc690b", @"/Views/_ViewImports.cshtml")]
    public class Views_Action_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnModelValidations.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n\r\n");
#nullable restore
#line 8 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-borderd\">\r\n    <tr>\r\n        <td>");
#nullable restore
#line 12 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 13 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.EditorFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 17 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 22 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 27 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.EditorFor(m => m.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 32 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.EditorFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 37 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.EditorFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 39 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>");
#nullable restore
#line 43 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.DisplayNameFor(m => m.Cpwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 44 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.EditorFor(m => m.Cpwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 45 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Cpwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td colsapan=\"2\">\r\n            <input type=\"submit\" value=\"login\" />\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 53 "E:\devika\Asp.net\24-01-2020\HandsOnModelValidations\Views\Action\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnModelValidations.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
