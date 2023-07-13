#pragma checksum "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ef8443d59075b2bd072c20c6f18b3185e644dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_List), @"mvc.1.0.view", @"/Views/Blog/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/List.cshtml", typeof(AspNetCore.Views_Blog_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ef8443d59075b2bd072c20c6f18b3185e644dd", @"/Views/Blog/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21193531e6522edd8cf5e7c5acef2305059c3264", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
  
    ViewData["Title"] = "Blog List";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(118, 203, true);
            WriteLiteral("\n\n<div class=\"container mt-3\">\n    <h2>Blog List</h2>\n    <hr>\n    <div>\n        <a class=\"btn btn-primary mb-2\" href=\"/Blog/Create\">Create</a>\n    </div>\n    <div class=\"row\">\n        <div class=\"col\">\n");
            EndContext();
#line 16 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
             if (Model.Count()>0)
            {

#line default
#line hidden
            BeginContext(369, 527, true);
            WriteLiteral(@"                <table class=""table table-bordered table-striped"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Image</th>
                        <th>Title</th>
                        <th>Date</th>
                        <th>Is Approved</th>
                        <th>Is Home</th>
                        <th>Is Slider</th>
                        <th></th>
                    </tr>
                    
                </thead>
                <tbody>
");
            EndContext();
#line 33 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(967, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(1029, 11, false);
#line 36 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                           Write(item.BlogId);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1078, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "70ef8443d59075b2bd072c20c6f18b3185e644dd7129", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1088, "~/img/", 1088, 6, true);
#line 37 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
AddHtmlAttributeValue("", 1094, item.Image, 1094, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1119, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1158, 10, false);
#line 38 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1207, 9, false);
#line 39 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                           Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1216, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
#line 40 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                                 if(item.IsApproved)
                                {

#line default
#line hidden
            BeginContext(1309, 64, true);
            WriteLiteral("                                    <i class=\"fa fa-check\"></i>\n");
            EndContext();
#line 43 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1478, 64, true);
            WriteLiteral("                                    <i class=\"fa fa-times\"></i>\n");
            EndContext();
#line 47 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                                }

#line default
#line hidden
            BeginContext(1576, 66, true);
            WriteLiteral("                            </td>\n                            <td>");
            EndContext();
#line 49 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                                 if(item.IsHome)
                                {

#line default
#line hidden
            BeginContext(1693, 64, true);
            WriteLiteral("                                    <i class=\"fa fa-check\"></i>\n");
            EndContext();
#line 52 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1862, 64, true);
            WriteLiteral("                                    <i class=\"fa fa-times\"></i>\n");
            EndContext();
#line 56 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                                }

#line default
#line hidden
            BeginContext(1960, 66, true);
            WriteLiteral("                            </td>\n                            <td>");
            EndContext();
#line 58 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                                 if(item.IsSlider)
                                {

#line default
#line hidden
            BeginContext(2079, 64, true);
            WriteLiteral("                                    <i class=\"fa fa-check\"></i>\n");
            EndContext();
#line 61 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2248, 64, true);
            WriteLiteral("                                    <i class=\"fa fa-times\"></i>\n");
            EndContext();
#line 65 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                                }

#line default
#line hidden
            BeginContext(2346, 99, true);
            WriteLiteral("                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(2445, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ef8443d59075b2bd072c20c6f18b3185e644dd12684", async() => {
                BeginContext(2547, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                                                                                                            WriteLiteral(item.BlogId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2555, 33, true);
            WriteLiteral("\n                                ");
            EndContext();
            BeginContext(2588, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ef8443d59075b2bd072c20c6f18b3185e644dd15357", async() => {
                BeginContext(2691, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                                                                                                             WriteLiteral(item.BlogId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2701, 94, true);
            WriteLiteral("\n                            \n                            </td>\n                        </tr>\n");
            EndContext();
#line 73 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
                    }

#line default
#line hidden
            BeginContext(2817, 46, true);
            WriteLiteral("                </tbody>\n            </table>\n");
            EndContext();
#line 76 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"

            }
            else
            {

#line default
#line hidden
            BeginContext(2909, 109, true);
            WriteLiteral("                <div class=\"alert alert-danger\">\n                    Blog Eklenmemiş.\n                </div>\n");
            EndContext();
#line 83 "/Users/tunc/Documents/C#/BlogApp/BlogApp.WebUI/Views/Blog/List.cshtml"
            }

#line default
#line hidden
            BeginContext(3032, 32, true);
            WriteLiteral("        </div>\n    </div>\n</div>");
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
