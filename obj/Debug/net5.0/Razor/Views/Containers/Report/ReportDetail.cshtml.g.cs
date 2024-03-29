#pragma checksum "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e09ad07c7cf95f0899bc850b3b1ff47fe6a0a412"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Report_ReportDetail), @"mvc.1.0.view", @"/Views/Containers/Report/ReportDetail.cshtml")]
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
#line 1 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e09ad07c7cf95f0899bc850b3b1ff47fe6a0a412", @"/Views/Containers/Report/ReportDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Report_ReportDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
  
    this.ViewData["Title"] = Routers.ReportList.Title;
    var listReport = (List<ReportTicket>)this.ViewData["listReportByProductId"];
    var product = (Product)this.ViewData["product"];
    var user = (User)this.ViewData["user"];
    var shop = (User)this.ViewData["shop"];
    var listCustomer = (List<User>)this.ViewData["listCustomer"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        ");
#nullable restore
#line 14 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
   Write(await Html.PartialAsync("../../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""content"">
            <div class=""mt-5 intro-y box"">
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">
                    <h2 class=""mr-auto text-base font-medium"">Report of product ");
#nullable restore
#line 18 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
                                                                           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n                <div class=\"border-t border-gray-200 px-4 py-5 sm:p-0\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 953, "\"", 976, 1);
#nullable restore
#line 21 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
WriteAttributeValue("", 959, product.ImageUrl, 959, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 977, "\"", 996, 1);
#nullable restore
#line 21 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
WriteAttributeValue("", 983, product.Name, 983, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""300px"" height=""300px""/>
                </div>
                <div>
                        <dl class=""mt-2 divide-y divide-gray-200"">
                            <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                                <dt class=""text-sm font-medium text-gray-500"">Product Name</dt>
                                <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 27 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
                                                                                        Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                            </div>
                            <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                                <dt class=""text-sm font-medium text-gray-500"">Shop Name</dt>
                                <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 31 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
                                                                                        Write(shop.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                            </div>
                                <div class=""relative"">
                                    <div class=""absolute inset-0 flex items-center"" aria-hidden=""true"">
                                        <div class=""w-full border-t border-gray-300""></div>
                                    </div>
                                    <div class=""relative flex justify-start"">
                                        <span class=""pr-3 bg-white text-lg font-medium text-gray-900""> Report List </span>
                                    </div>
                            </div>
");
#nullable restore
#line 41 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
                             for(int i = 0; i < @listReport.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6\">\r\n                                    <dt class=\"text-sm font-medium text-gray-500\">Report Number #");
#nullable restore
#line 44 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
                                                                                             Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dt>
                                </div>
                                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                                    <dt class=""text-sm font-medium text-gray-500"">Customer Name</dt>
                                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 48 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
                                                                                            Write(listCustomer[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                                </div>
                                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                                    <dt class=""text-sm font-medium text-gray-500"">Report Description</dt>
                                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 52 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
                                                                                            Write(listReport[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                </div>\r\n");
#nullable restore
#line 54 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </dl>\r\n                </div>\r\n");
#nullable restore
#line 57 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
                 if(user.RoleId == "1"){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""min-h-full flex "">
                    <div class=""flex-1 flex flex-col justify-center py-12 px-4 sm:px-6 lg:flex-none lg:px-20 xl:px-24"">
                        <div class=""mx-auto w-full max-w-sm lg:w-96"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 3900, "\"", 3950, 2);
            WriteAttributeValue("", 3907, "/report/create?productId=", 3907, 25, true);
#nullable restore
#line 61 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
WriteAttributeValue("", 3932, product.ProductId, 3932, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                                   Create new report
                            </a>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 67 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\ReportDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        \r\n        <script src=\"/js/report/create.js\"></script>\r\n    ");
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
