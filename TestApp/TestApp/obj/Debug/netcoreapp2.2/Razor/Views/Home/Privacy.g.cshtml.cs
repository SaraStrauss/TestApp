#pragma checksum "C:\temp\TestApp\TestApp\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8504f9bcb76eaf6e6d2e34687f47d8f16198e7e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "C:\temp\TestApp\TestApp\Views\_ViewImports.cshtml"
using TestApp;

#line default
#line hidden
#line 2 "C:\temp\TestApp\TestApp\Views\_ViewImports.cshtml"
using TestApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8504f9bcb76eaf6e6d2e34687f47d8f16198e7e2", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25db771d30abaf29d3599c25e6deb12289bab6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestApp.Models.Queue>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\temp\TestApp\TestApp\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(79, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(84, 17, false);
#line 5 "C:\temp\TestApp\TestApp\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(101, 177, true);
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n<script type=\"text/javascript\">\r\n    function show() {\r\n        $(\"#dialog\").dialog();\r\n    }\r\n</script>\r\n\r\n");
            EndContext();
#line 14 "C:\temp\TestApp\TestApp\Views\Home\Privacy.cshtml"
 if (Model.UserId!=null)
{

#line default
#line hidden
            BeginContext(307, 83, true);
            WriteLiteral("    <div id=\"dialog\" title=\"Test dialog\">\r\n        <p>Hello world</p>\r\n    </div>\r\n");
            EndContext();
            BeginContext(392, 30, true);
            WriteLiteral("    <script>show();</script>\r\n");
            EndContext();
#line 21 "C:\temp\TestApp\TestApp\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestApp.Models.Queue> Html { get; private set; }
    }
}
#pragma warning restore 1591