#pragma checksum "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58e052c40888cedd4f7ee3e1859ed83433990d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Slider), @"mvc.1.0.view", @"/Views/Shared/_Slider.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Slider.cshtml", typeof(AspNetCore.Views_Shared__Slider))]
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
#line 1 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/_ViewImports.cshtml"
using BlogApp.WebUI.Models;

#line default
#line hidden
#line 2 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/_ViewImports.cshtml"
using BlogApp.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58e052c40888cedd4f7ee3e1859ed83433990d2", @"/Views/Shared/_Slider.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21193531e6522edd8cf5e7c5acef2305059c3264", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Slider : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 104, true);
            WriteLiteral("\n <div id=\"carouselExampleIndicators\" class=\"carousel slide mb-3\">\n  <div class=\"carousel-indicators\">\n\n");
            EndContext();
#line 6 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
     for (int i = 0; i < Model.Count(); i++)
    {
        if (i==0) {

#line default
#line hidden
            BeginContext(200, 78, true);
            WriteLiteral("            <li data-bs-target=\"#carouselExampleIndicators\" data-bs-slide-to=\"");
            EndContext();
            BeginContext(279, 1, false);
#line 9 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
                                                                         Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(280, 23, true);
            WriteLiteral("\" class=\"active\"></li>\n");
            EndContext();
#line 10 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(336, 78, true);
            WriteLiteral("            <li data-bs-target=\"#carouselExampleIndicators\" data-bs-slide-to=\"");
            EndContext();
            BeginContext(415, 1, false);
#line 13 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
                                                                         Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(416, 8, true);
            WriteLiteral("\"></li>\n");
            EndContext();
#line 14 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(440, 55, true);
            WriteLiteral("  </div>\n  <div class=\"carousel-inner\" role=\"listbox\">\n");
            EndContext();
#line 18 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
      var index = 0;

#line default
#line hidden
            BeginContext(517, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 19 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
     foreach (var item in Model)
    {
        if (index == 0)
         {

#line default
#line hidden
            BeginContext(591, 63, true);
            WriteLiteral("            <div class=\"carousel-item active\">\n                ");
            EndContext();
            BeginContext(654, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f58e052c40888cedd4f7ee3e1859ed83433990d25944", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 664, "~/img/", 664, 6, true);
#line 24 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
AddHtmlAttributeValue("", 670, item.Image, 670, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
AddHtmlAttributeValue("", 710, item.Title, 710, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(723, 90, true);
            WriteLiteral("\n                <div class=\"carousel-caption d-none d-md-block\">\n                    <h5>");
            EndContext();
            BeginContext(814, 10, false);
#line 26 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(824, 29, true);
            WriteLiteral("</h5>\n                    <p>");
            EndContext();
            BeginContext(854, 16, false);
#line 27 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
                  Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(870, 49, true);
            WriteLiteral("</p>\n                </div>\n            </div>  \n");
            EndContext();
#line 30 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
            index++;
         }
         else
         {

#line default
#line hidden
            BeginContext(976, 56, true);
            WriteLiteral("            <div class=\"carousel-item\">\n                ");
            EndContext();
            BeginContext(1032, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f58e052c40888cedd4f7ee3e1859ed83433990d29115", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1042, "~/img/", 1042, 6, true);
#line 35 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
AddHtmlAttributeValue("", 1048, item.Image, 1048, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 35 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
AddHtmlAttributeValue("", 1088, item.Title, 1088, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1101, 90, true);
            WriteLiteral("\n                <div class=\"carousel-caption d-none d-md-block\">\n                    <h5>");
            EndContext();
            BeginContext(1192, 10, false);
#line 37 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1202, 29, true);
            WriteLiteral("</h5>\n                    <p>");
            EndContext();
            BeginContext(1232, 16, false);
#line 38 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
                  Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1248, 49, true);
            WriteLiteral("</p>\n                </div>\n            </div>  \n");
            EndContext();
#line 41 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Shared/_Slider.cshtml"
         }     
    }

#line default
#line hidden
            BeginContext(1319, 494, true);
            WriteLiteral(@"  </div>
  <button class=""carousel-control-prev"" role=""button"" href=""#carouselExampleIndicators"" data-slide=""prev"">
    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    <span class=""visually-hidden"">Previous</span>
  </button>
  <button class=""carousel-control-next"" role=""button"" href=""#carouselExampleIndicators"" data-slide=""next"">
    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    <span class=""visually-hidden"">Next</span>
  </button>
</div> ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591