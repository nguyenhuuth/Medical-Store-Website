#pragma checksum "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\User\UpdateUserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33d6bd627f8fc7211c6f47124fc35f70735f721b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_User_UpdateUserInfo), @"mvc.1.0.view", @"/Views/Containers/User/UpdateUserInfo.cshtml")]
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
#line 1 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\User\UpdateUserInfo.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d6bd627f8fc7211c6f47124fc35f70735f721b", @"/Views/Containers/User/UpdateUserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_User_UpdateUserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formUpdateUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\User\UpdateUserInfo.cshtml"
  
    this.ViewData["Title"] = Routers.UpdateUserInfo.Title;
    var user = (User)this.ViewData["user"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        ");
#nullable restore
#line 9 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\User\UpdateUserInfo.cshtml"
   Write(await Html.PartialAsync("../../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""content"">
            <div class=""mt-5 intro-y box"">
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">
                    <h2 class=""mr-auto text-base font-medium"">Update Category</h2>
                </div>
                <dl class=""mt-2 divide-y divide-gray-200"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d6bd627f8fc7211c6f47124fc35f70735f721b5286", async() => {
                WriteLiteral(@"
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                            <dt class=""text-sm font-medium text-gray-500"">Name</dt>
                            <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                <input id=""name"" name=""name"" type=""text""");
                BeginWriteAttribute("autoComplete", " autoComplete=\"", 1060, "\"", 1075, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1076, "\"", 1094, 1);
#nullable restore
#line 20 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\User\UpdateUserInfo.cshtml"
WriteAttributeValue("", 1084, user.Name, 1084, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required
                                       class=""appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"" />
                                <div id=""NAMEERROR"" data-label=""Name"" class=""text-red-500 ""></div>
                            </dd>
                        </div>
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                            <dt class=""text-sm font-medium text-gray-500"">Phone</dt>
                            <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                <div class=""mt-1"">
                                    <input id=""phone"" name=""phone"" type=""text""");
                BeginWriteAttribute("autoComplete", " autoComplete=\"", 1903, "\"", 1918, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1919, "\"", 1938, 1);
#nullable restore
#line 29 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\User\UpdateUserInfo.cshtml"
WriteAttributeValue("", 1927, user.Phone, 1927, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required
                                           class=""appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"" />
                                    <div id=""PHONEERROR"" data-label=""Phone"" class=""text-red-500 ""></div>
                                </div>
                            </dd>
                        </div>
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                            <dt class=""text-sm font-medium text-gray-500"">Address</dt>
                            <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                <div class=""mt-1"">
                                    <div class=""mt-1"">
                                        <input id=""address"" name=""address"" type=""text""");
                BeginWriteAttribute("autoComplete", " autoComplete=\"", 2863, "\"", 2878, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2879, "\"", 2900, 1);
#nullable restore
#line 40 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\User\UpdateUserInfo.cshtml"
WriteAttributeValue("", 2887, user.Address, 2887, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required
                                               class=""appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"" />
                                        <div id=""ADDRESSERROR"" data-label=""Address"" class=""text-red-500 ""></div>
                                    </div>
                                </div>
                            </dd>
                        </div>
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                            <dt class=""text-sm font-medium text-gray-500"">Email</dt>
                            <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                <div class=""mt-1"">
                                    <div class=""mt-1"">
                                        <div class=""mt-1"">
                                            <input id=""email"" name=""emai");
                WriteLiteral("l\" type=\"email\" autoComplete=\"email\" required");
                BeginWriteAttribute("value", " value=\"", 3970, "\"", 3989, 1);
#nullable restore
#line 53 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\User\UpdateUserInfo.cshtml"
WriteAttributeValue("", 3978, user.Email, 3978, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                                   class=""appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"" />
                                            <div id=""EMAILERROR"" data-label=""Email"" class=""text-red-500 ""></div>
                                        </div>
                                    </div>
                                </div>
                            </dd>
                        </div>
                        <div>
                            <button type=""submit""");
                BeginWriteAttribute("onclick", " onclick=\"", 4628, "\"", 4708, 12);
                WriteAttributeValue("", 4638, "return", 4638, 6, true);
                WriteAttributeValue(" ", 4644, "confirm(\'Are", 4645, 13, true);
                WriteAttributeValue(" ", 4657, "you", 4658, 4, true);
                WriteAttributeValue(" ", 4661, "sure", 4662, 5, true);
                WriteAttributeValue(" ", 4666, "you", 4667, 4, true);
                WriteAttributeValue(" ", 4670, "want", 4671, 5, true);
                WriteAttributeValue(" ", 4675, "to", 4676, 3, true);
                WriteAttributeValue(" ", 4678, "Update", 4679, 7, true);
                WriteAttributeValue(" ", 4685, "User", 4686, 5, true);
                WriteAttributeValue(" ", 4690, "Info", 4691, 5, true);
#nullable restore
#line 62 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Containers\User\UpdateUserInfo.cshtml"
WriteAttributeValue(" ", 4695, user.Name, 4696, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4706, "\')", 4706, 2, true);
                EndWriteAttribute();
                WriteLiteral(@"
                                    class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                                Update Information
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
            WriteLiteral("\r\n                </dl>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n<script src=\"/js/user/updateinfo.js\"></script>\r\n\r\n");
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
