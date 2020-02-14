#pragma checksum "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a56bbe7a588818d0a95bb1da850561c7648ffb48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Carousel), @"mvc.1.0.view", @"/Views/Shared/_Carousel.cshtml")]
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
#line 1 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a56bbe7a588818d0a95bb1da850561c7648ffb48", @"/Views/Shared/_Carousel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f688881c3b892b8ca8d9e9aa844d18118a3862c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Carousel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TubeStore.Models.Carousel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-12\">\r\n    <div id=\"myCarousel\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 6 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
               int counter = 0;
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li data-target=\"#myCarousel\" data-slide-to=\"");
#nullable restore
#line 9 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
                                                            Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", "\r\n                        class=\"", 358, "\"", 422, 1);
#nullable restore
#line 10 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
WriteAttributeValue("", 391, counter == 0 ? "active" : "", 391, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 11 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
                    counter++;
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n        <div class=\"carousel-inner\">\r\n\r\n");
#nullable restore
#line 17 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
               counter = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 662, "\"", 711, 2);
            WriteAttributeValue("", 670, "carousel-item", 670, 13, true);
#nullable restore
#line 21 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
WriteAttributeValue(" ", 683, counter==0 ? "active":"", 684, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 761, "\"", 781, 1);
#nullable restore
#line 22 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
WriteAttributeValue("", 767, item.ImageUrl, 767, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 782, "\"", 788, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"container\">\r\n                        <div class=\"carousel-caption text-right\">\r\n                            <h1>");
#nullable restore
#line 25 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <h2>");
#nullable restore
#line 26 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>\r\n                                <a class=\"btn btn-lg btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1110, "\"", 1147, 2);
            WriteAttributeValue("", 1117, "/home/details/", 1117, 14, true);
#nullable restore
#line 28 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
WriteAttributeValue("", 1131, item.CarouselId, 1131, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">\r\n                                    View Details\r\n                                </a>\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 35 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_Carousel.cshtml"
                counter++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TubeStore.Models.Carousel>> Html { get; private set; }
    }
}
#pragma warning restore 1591