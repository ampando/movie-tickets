#pragma checksum "/Users/adriennematosich/Desktop/epicodus/MovieTickets.Solution/MovieTickets/Views/Theaters/AddMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84b323b34eba5afa3d960ddd1ff796eaabb36de5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Theaters_AddMovie), @"mvc.1.0.view", @"/Views/Theaters/AddMovie.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b323b34eba5afa3d960ddd1ff796eaabb36de5", @"/Views/Theaters/AddMovie.cshtml")]
    public class Views_Theaters_AddMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieTickets.Models.Theater>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/adriennematosich/Desktop/epicodus/MovieTickets.Solution/MovieTickets/Views/Theaters/AddMovie.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Add A Movie</h2>\r\n\r\n<h4>Add a movie for this theater: ");
#nullable restore
#line 9 "/Users/adriennematosich/Desktop/epicodus/MovieTickets.Solution/MovieTickets/Views/Theaters/AddMovie.cshtml"
                             Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 11 "/Users/adriennematosich/Desktop/epicodus/MovieTickets.Solution/MovieTickets/Views/Theaters/AddMovie.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/adriennematosich/Desktop/epicodus/MovieTickets.Solution/MovieTickets/Views/Theaters/AddMovie.cshtml"
Write(Html.HiddenFor(model => model.TheaterId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/adriennematosich/Desktop/epicodus/MovieTickets.Solution/MovieTickets/Views/Theaters/AddMovie.cshtml"
Write(Html.Label("Select Movie"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/adriennematosich/Desktop/epicodus/MovieTickets.Solution/MovieTickets/Views/Theaters/AddMovie.cshtml"
Write(Html.DropDownList("MovieId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 19 "/Users/adriennematosich/Desktop/epicodus/MovieTickets.Solution/MovieTickets/Views/Theaters/AddMovie.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 21 "/Users/adriennematosich/Desktop/epicodus/MovieTickets.Solution/MovieTickets/Views/Theaters/AddMovie.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieTickets.Models.Theater> Html { get; private set; }
    }
}
#pragma warning restore 1591
