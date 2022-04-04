#pragma checksum "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\CreateReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39b9300e4af3ca2f278238afd07d6f1e8635c530"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Report_CreateReport), @"mvc.1.0.view", @"/Views/Containers/Report/CreateReport.cshtml")]
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
#line 1 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\CreateReport.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39b9300e4af3ca2f278238afd07d6f1e8635c530", @"/Views/Containers/Report/CreateReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Report_CreateReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MedicalStore.Models.ReportTicket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("space-y-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\CreateReport.cshtml"
  
    this.ViewData["Title"] = Routers.CreateReport.Title;
    var report = (ReportTicket)this.ViewData["report"];
    var product = (Product)this.ViewData["product"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        ");
#nullable restore
#line 11 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\CreateReport.cshtml"
   Write(await Html.PartialAsync("../../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""content"">
            <div class=""mt-5 intro-y box"">
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">
                    <h2 class=""mr-auto text-base font-medium"">Create Report</h2>
                </div>
                <div class=""border-t border-gray-200 px-4 py-5 sm:p-0"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 807, "\"", 830, 1);
#nullable restore
#line 18 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\CreateReport.cshtml"
WriteAttributeValue("", 813, product.ImageUrl, 813, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 831, "\"", 850, 1);
#nullable restore
#line 18 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\CreateReport.cshtml"
WriteAttributeValue("", 837, product.Name, 837, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300px\" height=\"300px\"/>\r\n                </div>\r\n                <dl class=\"mt-2 divide-y divide-gray-200\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39b9300e4af3ca2f278238afd07d6f1e8635c5306276", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 22 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\CreateReport.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/FormMessage.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                                <dt class=""text-sm font-medium text-gray-500"">Product Name</dt>
                                <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                    <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                           type=""text"" name=""productName"" id=""productName""");
                BeginWriteAttribute("value", " value=\"", 1627, "\"", 1648, 1);
#nullable restore
#line 27 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\CreateReport.cshtml"
WriteAttributeValue("", 1635, product.Name, 1635, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""ProductId"" readonly />
                                </dd>
                            </div>
                            <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                                <dt class=""text-sm font-medium text-gray-500"">Report Information</dt>
                                <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                    <textarea rows=""4"" name=""description"" id=""description"" class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control"" placeholder=""Description""></textarea>
                                    <div id=""DESCRIPTIONERROR"" data-label=""Description"" class=""text-red-500 ""></div>
                                </dd>
                            </div>
                            <input type=""hidden"" name=""productId"" id=""productId""");
                BeginWriteAttribute("value", " value=\"", 2540, "\"", 2566, 1);
#nullable restore
#line 37 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\Report\CreateReport.cshtml"
WriteAttributeValue("", 2548, product.ProductId, 2548, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>   
                            <div>
                                <button type=""submit""
                                        class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                                    Create
                                </button>
                            </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </dl>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MedicalStore.Models.ReportTicket>> Html { get; private set; }
    }
}
#pragma warning restore 1591