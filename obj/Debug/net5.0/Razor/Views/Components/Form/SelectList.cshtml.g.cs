#pragma checksum "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Components\Form\SelectList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bc99b0bef54e3da2e911c91ef1f186259aeddcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_Form_SelectList), @"mvc.1.0.view", @"/Views/Components/Form/SelectList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bc99b0bef54e3da2e911c91ef1f186259aeddcc", @"/Views/Components/Form/SelectList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_Form_SelectList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Components\Form\SelectList.cshtml"
  

    var error = $"{Model.Field.ToUpper()}ERROR";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"space-y-2\">\r\n    <select class=\" form-select form-select-lg\"");
            BeginWriteAttribute("name", " name=\"", 133, "\"", 152, 1);
#nullable restore
#line 7 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Components\Form\SelectList.cshtml"
WriteAttributeValue("", 140, Model.Field, 140, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 153, "\"", 170, 1);
#nullable restore
#line 7 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Components\Form\SelectList.cshtml"
WriteAttributeValue("", 158, Model.Field, 158, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Components\Form\SelectList.cshtml"
         foreach (var item in Model.Values.Items)
        {
            var selected = item.Value == Model.Value ? "selected" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<option value=\"");
#nullable restore
#line 12 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Components\Form\SelectList.cshtml"
                        Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" ");
#nullable restore
#line 12 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Components\Form\SelectList.cshtml"
                                     Write(selected);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Components\Form\SelectList.cshtml"
                                               Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 13 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Components\Form\SelectList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </select>\r\n    <div");
            BeginWriteAttribute("id", " id=\"", 420, "\"", 431, 1);
#nullable restore
#line 16 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Components\Form\SelectList.cshtml"
WriteAttributeValue("", 425, error, 425, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-label=\"");
#nullable restore
#line 16 "C:\Users\huuth\OneDrive\Documents\swp_Tho\presentation\Views\Components\Form\SelectList.cshtml"
                            Write(Model.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-red-500 \"></div>\r\n</div>\r\n");
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
