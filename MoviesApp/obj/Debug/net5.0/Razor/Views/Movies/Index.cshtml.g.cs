#pragma checksum "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ef3305eb116d6f1706376682ac992ee384a5a28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\_ViewImports.cshtml"
using MoviesApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\_ViewImports.cshtml"
using MoviesApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\_ViewImports.cshtml"
using MoviesApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ef3305eb116d6f1706376682ac992ee384a5a28", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fc65e4521c2c205188cf7e49a23e42d4118d8e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = localizer["Movies"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>\r\n    <i class=\"bi bi-film\"></i>\r\n    ");
#nullable restore
#line 13 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
Write(localizer["Movies"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef3305eb116d6f1706376682ac992ee384a5a286132", async() => {
                WriteLiteral("\r\n    <i class=\"bi bi-plus\"></i>\r\n    Add Movie\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"mt-4\">\r\n");
#nullable restore
#line 22 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            <i class=\"bi bi-exclamation-triangle\"></i>\r\n            ");
#nullable restore
#line 26 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
       Write(localizer["No Movies"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 28 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 32 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
             foreach (var movie in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12\">\r\n                    <div class=\"card mb-3\">\r\n                        <div class=\"row g-0\">\r\n                            <div class=\"col-md-2 poster\"");
            BeginWriteAttribute("style", " style=\"", 767, "\"", 855, 3);
            WriteAttributeValue("", 775, "background-image:url(data:image\\/*;base64,", 775, 42, true);
#nullable restore
#line 37 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
WriteAttributeValue("", 817, Convert.ToBase64String(movie.Poster), 817, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 854, ")", 854, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"col-md-10\">\r\n                                <div class=\"card-body\">\r\n                                    <h5 class=\"card-title\">");
#nullable restore
#line 41 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                                                      Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 41 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                                                                    Write(movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n                                    <p class=\"card-text\">\r\n                                        ");
#nullable restore
#line 43 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                                    Write(
                                            movie.Storeline.Length > 300
                                            ? $"{movie.Storeline.Substring(0, 300)}......."
                                            : movie.Storeline
                                         );

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>

                                    <p class=""card-text"">
                                        <i class=""bi bi-star-fill text-warning""></i>
                                        <small class=""text-muted"">");
#nullable restore
#line 52 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                                                             Write(movie.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    </p>\r\n\r\n                                    <div>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef3305eb116d6f1706376682ac992ee384a5a2811245", async() => {
                WriteLiteral("\r\n                                            <i class=\"bi bi-camera-reels\"></i>\r\n                                            ");
#nullable restore
#line 58 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                                       Write(localizer["Details"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                                                                  WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ef3305eb116d6f1706376682ac992ee384a5a2813957", async() => {
                WriteLiteral("\r\n                                            <i class=\"bi bi-pencil\"></i>\r\n                                            ");
#nullable restore
#line 62 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                                       Write(localizer["Edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                                                               WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <a href=\"javascript:;\" class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 64 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                                                                                                    Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                            <i class=\"bi bi-trash\"></i>\r\n                                            ");
#nullable restore
#line 66 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                                       Write(localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 74 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 76 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'.js-delete\').on(\'click\', function () {\r\n                var btn = $(this);\r\n                bootbox.confirm({\r\n                    message: \"");
#nullable restore
#line 86 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                         Write(localizer["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" ,\r\n                    buttons: {\r\n                        confirm: {\r\n                            label: \"");
#nullable restore
#line 89 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                               Write(localizer["Yes"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" ,\r\n                            className: \'btn-danger\'\r\n                        },\r\n                        cancel: {\r\n                            label: \"");
#nullable restore
#line 93 "M:\Portfolio Projects\MoviesApp\MoviesApp\Views\Movies\Index.cshtml"
                               Write(localizer["No"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" ,
                            className: 'btn-outline-secondary'
                        }
                    },
                    callback: function (result) {
                        if (result) {
                            $.ajax({
                                url: '/movies/delete/' + btn.data('id'),
                                success: function () {
                                    var movieContainer = btn.parents('.col-12');
                                    movieContainer.addClass('animate__animated animate__zoomOut');
                                    setTimeout(function () {
                                        movieContainer.remove();
                                    }, 1000);
                                    toastr.success('Movies deleted');
                                },
                                error: function () {
                                    toastr.error('Something went wrong!');
                                }
                 ");
                WriteLiteral("           });\r\n                        }\r\n                    }\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
