#pragma checksum "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea929a06a485f832ee685f3d09870e90b342dacd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\_ViewImports.cshtml"
using Cinema_CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\_ViewImports.cshtml"
using Cinema_CRUD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\_ViewImports.cshtml"
using Cinema_CRUD.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\_ViewImports.cshtml"
using Cinema_CRUD.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\_ViewImports.cshtml"
using Cinema_CRUD.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea929a06a485f832ee685f3d09870e90b342dacd", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2cdffa8eec212bb660d8284b586535c0e7ed53b", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #93B1A6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-xxl-3 col-xl-3 col-lg-3 col-md-4 mt-2 movie-container\">\r\n            <div class=\"card\">\r\n                <div class=\"card-header d-flex justify-content-between\" style=\"background-color: #5C8374; \">\r\n                    <P><b>");
#nullable restore
#line 13 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></P>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea929a06a485f832ee685f3d09870e90b342dacd6959", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movieId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
                                                                WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"d-flex justify-content-center mt-3\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 717, "\"", 780, 2);
            WriteAttributeValue("", 723, "data:image/*;base64,", 723, 20, true);
#nullable restore
#line 17 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
WriteAttributeValue("", 743, Convert.ToBase64String(item.image), 743, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top h-50 w-50\" alt=\"movie\">\r\n                </div>\r\n                <div class=\"card-body\">\r\n\r\n                    <h5 class=\"card-title\">Description</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <ul class=\"list-group list-group-flush\">\r\n                    <li class=\"list-group-item d-flex justify-content-between\"><b>Category</b>     ");
#nullable restore
#line 25 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
                                                                                              Write(item.movieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item d-flex justify-content-between\">\r\n                        <b>Status</b>\r\n");
#nullable restore
#line 28 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
                         if (DateTime.Now >= item.StartDate && DateTime.Now <= item.EndDate)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-success text-white\">Available</span>\r\n");
#nullable restore
#line 31 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
                        }
                        else if (DateTime.Now > item.EndDate)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-danger text-white\">Expired</span>\r\n");
#nullable restore
#line 35 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-primary text-white\">UpComing</span>\r\n");
#nullable restore
#line 39 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </li>\r\n                </ul>\r\n                <div class=\"d-flex justify-content-around card-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea929a06a485f832ee685f3d09870e90b342dacd12498", async() => {
                WriteLiteral("<i class=\"bi bi-info-lg\"></i>  Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movieId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
                                                                                   WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <a href=\"javascript:;\" class=\"btn btn-outline-danger js-delete\" data-id=\"");
#nullable restore
#line 44 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
                                                                                        Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"bi bi-trash\"></i>  Delete</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 48 "C:\Users\ahmed\source\repos\Cinema_CRUD\Cinema_CRUD\Views\Movie\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n<div class=\"d-flex justify-content-end fixed-bottom\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea929a06a485f832ee685f3d09870e90b342dacd15615", async() => {
                WriteLiteral("Add <i class=\"bi bi-plus-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#showDropDown').removeClass('d-none');
            $('#FormSearch').removeClass('d-none');
            $('.js-delete').on('click', function () {
                var btn = $(this);
                var movieContainer = btn.closest('.movie-container');
                //Swal.fire({
                //    title: 'Do you want to delete this movie?',
                //    showCancelButton: true,
                //    confirmButtonText: 'Delete',
                //}).then((result) => {
                //    if (result.isConfirmed) {
                Swal.fire({
                    title: 'Are you sure?',
                    text: ""You won't be able to revert this!"",
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Yes, delete it!'
                }).then((result");
                WriteLiteral(@") => {
                    if (result.isConfirmed) {
                        $.ajax({
                            url: '/api/MovieApi/?movieId=' + btn.data('id'),
                            method: 'DELETE',
                            success: function () {
                                Swal.fire({
                                    position: 'center',
                                    icon: 'success',
                                    title: 'Movie is deleted',
                                    showConfirmButton: false,
                                    timer: 1000
                                })
                                movieContainer.fadeOut(500, function () {
                                    movieContainer.remove();
                                    $.ajax({
                                        url: '/api/MovieApi',
                                        method: 'GET',
                                        success: function (data) {
                    ");
                WriteLiteral(@"                        //$('#categoryDropdown').html('<li><a class=""dropdown-item"" asp-action=""Index"">All</a></li>')
                                            //$('#categoryDropdown').html(data.map(category => `<li><a class=""dropdown-item"" asp-action=""FilterByCategory"" asp-route-MovieCategory=""${category}"">${category}</a></li>`).join(''));
                                            var dropdownHtml = '<li><a class=""dropdown-item"" asp-action=""Index"">All</a></li>';
                                            data.forEach(function (category) {
                                                var categoryUrl = '/Movie/FilterByCategory?MovieCategory=' + encodeURIComponent(category); // Construct the URL manually
                                                dropdownHtml += `<li><a class=""dropdown-item"" href=""${categoryUrl}"">${category}</a></li>`;
                                            });
                                            $('#categoryDropdown').html(dropdownHtml);
                      ");
                WriteLiteral(@"                  },
                                        error: function () {
                                            console.log('Failed to update categories.');
                                        }
                                    });
                                });
                            },
                            error: function () {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Oops...',
                                    text: 'Something went wrong!'
                                });
                            }
                        });
                    }
                });
            });

        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
