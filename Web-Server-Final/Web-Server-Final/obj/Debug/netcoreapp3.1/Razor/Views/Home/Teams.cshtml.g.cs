#pragma checksum "C:\Users\ymeat\Source\Repos\Web-Server-Final12\Web-Server-Final\Web-Server-Final\Views\Home\Teams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6b1a77d226315b2eebcde3fecdb3664a4488ae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Teams), @"mvc.1.0.view", @"/Views/Home/Teams.cshtml")]
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
#line 1 "C:\Users\ymeat\Source\Repos\Web-Server-Final12\Web-Server-Final\Web-Server-Final\Views\_ViewImports.cshtml"
using Web_Server_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ymeat\Source\Repos\Web-Server-Final12\Web-Server-Final\Web-Server-Final\Views\_ViewImports.cshtml"
using Web_Server_Final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6b1a77d226315b2eebcde3fecdb3664a4488ae4", @"/Views/Home/Teams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"635cfeba122ba9a9d323120ae8b264f15271b6a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Teams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Team>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ymeat\Source\Repos\Web-Server-Final12\Web-Server-Final\Web-Server-Final\Views\Home\Teams.cshtml"
  
    ViewData["Title"] = "Teams";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Teams</h1>\r\n</div>\r\n\r\n<hr />\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr><th>Name</th><th>City</th><th>SportId</th></tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\ymeat\Source\Repos\Web-Server-Final12\Web-Server-Final\Web-Server-Final\Views\Home\Teams.cshtml"
         foreach(Team t in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\ymeat\Source\Repos\Web-Server-Final12\Web-Server-Final\Web-Server-Final\Views\Home\Teams.cshtml"
               Write(t.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\ymeat\Source\Repos\Web-Server-Final12\Web-Server-Final\Web-Server-Final\Views\Home\Teams.cshtml"
               Write(t.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\ymeat\Source\Repos\Web-Server-Final12\Web-Server-Final\Web-Server-Final\Views\Home\Teams.cshtml"
               Write(t.SportId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\ymeat\Source\Repos\Web-Server-Final12\Web-Server-Final\Web-Server-Final\Views\Home\Teams.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Team>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591