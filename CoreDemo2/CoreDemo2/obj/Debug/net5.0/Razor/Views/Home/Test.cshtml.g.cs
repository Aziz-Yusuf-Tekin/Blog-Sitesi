#pragma checksum "C:\Users\AZİZ YUSUF TEKİN\Source\Repos\CoreDemo2\CoreDemo2\Views\Home\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f5b6652166dd0fafa3790f12a34c79de13282ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test), @"mvc.1.0.view", @"/Views/Home/Test.cshtml")]
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
#line 1 "C:\Users\AZİZ YUSUF TEKİN\Source\Repos\CoreDemo2\CoreDemo2\Views\_ViewImports.cshtml"
using CoreDemo2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AZİZ YUSUF TEKİN\Source\Repos\CoreDemo2\CoreDemo2\Views\_ViewImports.cshtml"
using CoreDemo2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f5b6652166dd0fafa3790f12a34c79de13282ae", @"/Views/Home/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91ed8241a8cc81a93277436f44a799da43aa55e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\AZİZ YUSUF TEKİN\Source\Repos\CoreDemo2\CoreDemo2\Views\Home\Test.cshtml"
  
    ViewData["Title"] = "Test";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Test</h1>
<h3>Burası kendi oluşturduğumuz view sayfasıdır.</h3>
<table>
    <tr>
        <th>ID</th>
        <th>Ad</th>
        <th>Departman</th>
    </tr>
    <tr>
        <td>1</td>
        <td>Murat</td>
        <td>Yazılım</td>
    </tr>
        <tr>
        <td>2</td>
        <td>Aziz</td>
        <td>Mühendis</td>
    </tr>
</table>");
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
