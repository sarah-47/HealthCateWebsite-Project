#pragma checksum "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\Home\MedicineList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01251a276194fc4f8caa0550e149ca46b3c6f44e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MedicineList), @"mvc.1.0.view", @"/Views/Home/MedicineList.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\_ViewImports.cshtml"
using HealthCareWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\_ViewImports.cshtml"
using HealthCareWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\_ViewImports.cshtml"
using HealthCareWebsite.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01251a276194fc4f8caa0550e149ca46b3c6f44e", @"/Views/Home/MedicineList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f44c634ad0520bb26b7d174d175a0e6aec1d41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MedicineList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MedicinesModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Meds List</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01251a276194fc4f8caa0550e149ca46b3c6f44e4545", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"conatiner\">\r\n\r\n    <div class=\"row justify-content-around\">\r\n");
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\Home\MedicineList.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\Home\MedicineList.cshtml"
             if (@item.IsAvailable)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card col-lg-3\">\r\n                    <div class=\"card-body\">\r\n\r\n\r\n                        <div class=\"text-center \">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01251a276194fc4f8caa0550e149ca46b3c6f44e6433", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 445, "~/imgs/", 445, 7, true);
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\Home\MedicineList.cshtml"
AddHtmlAttributeValue("", 452, item.MImage, 452, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h5>");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\Home\MedicineList.cshtml"
                           Write(item.MName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <h5>");
#nullable restore
#line 20 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\Home\MedicineList.cshtml"
                           Write(item.CName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <h5>");
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\Home\MedicineList.cshtml"
                           Write(item.MPrice.ToString("#,##0.00 $"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                            <!--<a asp-action=\"AddToCart\">Order</a>-->\r\n\r\n                            <input type=\"button\" name=\"Order\" value=\"Order\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=", 844, "", 873, 3);
            WriteAttributeValue("", 853, "AddToCart(", 853, 10, true);
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\Home\MedicineList.cshtml"
WriteAttributeValue("", 863, item.MId, 863, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 872, ")", 872, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 32 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\Home\MedicineList.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Lenovo\source\repos\HealthCareWebsite\HealthCareWebsite\Views\Home\MedicineList.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<Script type=""text/javascript"">
    function AddToCart(item) {
        var formData = new FormData();
        formData.append(""id"", item);

        $.ajax({
            async: true,
            type: 'POST',
            contentType: false,
            processData: false,
            data: formData,
            url: '/Home/AddToCart',

        });
    }
</Script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MedicinesModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
