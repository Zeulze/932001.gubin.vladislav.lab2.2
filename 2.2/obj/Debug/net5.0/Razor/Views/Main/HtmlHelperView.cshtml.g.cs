#pragma checksum "C:\Users\Zeulze\Desktop\2.2\2.2\Views\Main\HtmlHelperView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eb4e691b8fe3fa3c86ad4407ee38c0297086693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_HtmlHelperView), @"mvc.1.0.view", @"/Views/Main/HtmlHelperView.cshtml")]
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
#line 1 "C:\Users\Zeulze\Desktop\2.2\2.2\Views\_ViewImports.cshtml"
using _2._2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zeulze\Desktop\2.2\2.2\Views\_ViewImports.cshtml"
using _2._2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb4e691b8fe3fa3c86ad4407ee38c0297086693", @"/Views/Main/HtmlHelperView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b2130436ea1b968e0f5d077a59325702bf1e0f9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Main_HtmlHelperView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Zeulze\Desktop\2.2\2.2\Views\Main\HtmlHelperView.cshtml"
  
    var controller = ViewContext.RouteData.Values["Controller"] as string;
    var action = ViewContext.RouteData.Values["Action"] as string;
    ViewBag.Title = action;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Zeulze\Desktop\2.2\2.2\Views\Main\HtmlHelperView.cshtml"
Write(action);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Zeulze\Desktop\2.2\2.2\Views\Main\HtmlHelperView.cshtml"
 using (Html.BeginForm(action, controller, FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Zeulze\Desktop\2.2\2.2\Views\Main\HtmlHelperView.cshtml"
Write(Html.TextBox("x", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 12 "C:\Users\Zeulze\Desktop\2.2\2.2\Views\Main\HtmlHelperView.cshtml"
Write(Html.DropDownList("operation", new SelectList(new []{"+", "-", "*", "/"})));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Zeulze\Desktop\2.2\2.2\Views\Main\HtmlHelperView.cshtml"
Write(Html.TextBox("y", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <input type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 17 "C:\Users\Zeulze\Desktop\2.2\2.2\Views\Main\HtmlHelperView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591