#pragma checksum "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb5be3b870c5182598015fee97a462db4fbe554d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Product_Product), @"mvc.1.0.view", @"/Views/Containers/Product/Product.cshtml")]
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
#line 1 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\_ViewImports.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb5be3b870c5182598015fee97a462db4fbe554d", @"/Views/Containers/Product/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Product_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
  

    this.ViewData["Title"] = Routers.Product.Title;
    var listProduct = (List<Product>)this.ViewData["listProduct"];
    var user = (User)this.ViewData["user"];
    var listShopName = (List<string>)this.ViewData["listShopName"];
    var total = (int)this.ViewData["total"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        ");
#nullable restore
#line 12 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
   Write(await Html.PartialAsync("../../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""container"">
            <div class=""mt-5 intro-y box"">
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">
                    <h2 class=""mr-auto text-base font-medium"">
                        ");
#nullable restore
#line 17 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                    Write((user.RoleId.Equals("2")) ? ("All Products of shop " + user.Name) : "All Products");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h2>\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb5be3b870c5182598015fee97a462db4fbe554d5370", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
               Write(await Html.PartialAsync("../../Components/Form/FormHidden.cshtml",
                    new { Name = "pageSize", Value = (string)this.Context.Request.Query["pageSize"] ?? "12" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
               Write(await Html.PartialAsync("../../Components/Form/FormHidden.cshtml",
                    new { Name = "pageIndex", Value = (string)this.Context.Request.Query["pageIndex"] ?? "0" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""p-5"" id=""hoverable-table"">
                    <div class=""preview"">
                        <div class=""overflow-x-auto"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">#</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Image</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Product Name
                                        </th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Description
                                        </th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Create Date
                                        </th>");
            WriteLiteral("\r\n                                        <th class=\"border border-b-2 dark:border-dark-5 whitespace-nowrap\">Quantity</th>\r\n");
#nullable restore
#line 41 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                         if (user.RoleId.Equals("0"))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <th class=\"border border-b-2 dark:border-dark-5 whitespace-nowrap\">Shop Name\r\n                                            </th>\r\n");
#nullable restore
#line 45 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Status</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">View Detail
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 52 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                     for (int i = 0; i < listProduct.Count; i++)
                                    {
                                        var item = listProduct[i];
                                        var link = $"{Routers.ProductDetail.Link}?productId={item.ProductId}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"hover:bg-gray-200\">\r\n                                            <td class=\"border\">");
#nullable restore
#line 57 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                                           Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\"><img");
            BeginWriteAttribute("src", " src=\"", 3763, "\"", 3783, 1);
#nullable restore
#line 58 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
WriteAttributeValue("", 3769, item.ImageUrl, 3769, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3784, "\"", 3800, 1);
#nullable restore
#line 58 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
WriteAttributeValue("", 3790, item.Name, 3790, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70px\"\r\n                                                height=\"70px\" /></td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 60 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                                           Write(item.Name.Length >= 20 ? item.Name.Substring(0,20) + " ..."
                                            : item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 62 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                                           Write(item.Description.Length >= 30 ?
                                            item.Description.Substring(0,30) + " ..." : item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 64 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                                          Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 65 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                                          Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 66 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                             if (user.RoleId.Equals("0"))
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td class=\"border\">");
#nullable restore
#line 68 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                                               Write(listShopName.ElementAt<string>(i));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 69 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"border\">\r\n                                                ");
#nullable restore
#line 71 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                           Write(await Html.PartialAsync("../../Components/Table/Status.cshtml", item.Status
                                            == ProductStatus.ACTIVE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"border\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5162, "\"", 5174, 1);
#nullable restore
#line 75 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
WriteAttributeValue("", 5169, link, 5169, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""mb-2 mr-1 btn btn-primary"">
                                                    <i data-feather=""shopping-bag"" class=""w-5 h-5""></i>
                                                </a>
                                            </td>
                                        </tr>
");
#nullable restore
#line 80 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                            ");
#nullable restore
#line 83 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Product\Product.cshtml"
                       Write(await Html.PartialAsync("../../Components/Common/Pagination.cshtml",
                            new
                            {
                            PageIndex = (string)this.Context.Request.Query["pageIndex"] ?? "0",
                            PageSize =
                            (string)
                            this.Context.Request.Query["pageSize"] ?? "12",
                            Total = total
                            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script src=\"/js/product/delete.js\"></script>\r\n<script src=\"/js/pagination.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591