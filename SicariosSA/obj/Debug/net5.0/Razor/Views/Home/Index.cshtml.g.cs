#pragma checksum "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "469e33d4e4a255abbd7aac393eb66d66fc8d2890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\_ViewImports.cshtml"
using SicariosSA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\_ViewImports.cshtml"
using SicariosSA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469e33d4e4a255abbd7aac393eb66d66fc8d2890", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22a540da3b58f357807c20263a351be563ae46c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SicariosSA.ViewModels.TasksABCViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RandomTask", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Strona główna";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
 if (ViewBag.Standard == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <center>\r\n        <h2>Egzamin 8 klasisty - Angielski</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "469e33d4e4a255abbd7aac393eb66d66fc8d28904626", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
             foreach (var task in Model.TaskABC)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"container\">\r\n                    <div class=\"row border\">\r\n                        <div class=\"col-sm-12 border\">\r\n                            <h4><b>Zadanie</b></h4>\r\n                            <h5>");
#nullable restore
#line 17 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"col-sm-4\">\r\n                            <h5><b>A</b></h5>\r\n                            <h6><input type=\"checkbox\" name=\"answer\"");
                BeginWriteAttribute("value", " value=\"", 755, "\"", 776, 1);
#nullable restore
#line 21 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
WriteAttributeValue("", 763, task.Option1, 763, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"MutExChkList(this);\" /> ");
#nullable restore
#line 21 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                                                                                                                       Write(task.Option1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-4\">\r\n                            <h5><b>B</b></h5>\r\n                            <h6><input type=\"checkbox\" name=\"answer\"");
                BeginWriteAttribute("value", " value=\"", 1026, "\"", 1047, 1);
#nullable restore
#line 25 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
WriteAttributeValue("", 1034, task.Option2, 1034, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"MutExChkList(this);\" /> ");
#nullable restore
#line 25 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                                                                                                                       Write(task.Option2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-4\">\r\n                            <h5><b>C</b></h5>\r\n                            <h6><input type=\"checkbox\" name=\"answer\"");
                BeginWriteAttribute("value", " value=\"", 1297, "\"", 1318, 1);
#nullable restore
#line 29 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
WriteAttributeValue("", 1305, task.Option3, 1305, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"MutExChkList(this);\" /> ");
#nullable restore
#line 29 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                                                                                                                       Write(task.Option3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Sprawdź odpowiedź\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </center>\r\n");
#nullable restore
#line 40 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
}
else if (ViewBag.False == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <h2>Egzamin 8 klasisty - Angielski</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "469e33d4e4a255abbd7aac393eb66d66fc8d289010658", async() => {
                WriteLiteral("\r\n        <div class=\"alert alert-danger\" role=\"alert\">\r\n            <b>Zła odpowiedź!</b>\r\n        </div>\r\n");
#nullable restore
#line 49 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
         foreach (var task in Model.TaskABC)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"container\">\r\n                <div class=\"row align-items-start border\">\r\n                    <div class=\"col-sm-12 border\">\r\n                        <h4><b>Zadanie</b></h4>\r\n                        <h5>");
#nullable restore
#line 55 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                       Write(task.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>A</b></h5>\r\n                            <h6>");
#nullable restore
#line 60 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>APL</b></h5>\r\n                            <h6>");
#nullable restore
#line 64 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option1Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>B</b></h5>\r\n                            <h6>");
#nullable restore
#line 68 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>BPL</b></h5>\r\n                            <h6>");
#nullable restore
#line 72 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option2Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>C</b></h5>\r\n                            <h6>");
#nullable restore
#line 76 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>CPL</b></h5>\r\n                            <h6>");
#nullable restore
#line 80 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option3Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-12 border\">\r\n                        <h5><b>Wytłumaczenie</b></h5>\r\n                        <h6>");
#nullable restore
#line 85 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                       Write(task.Explanation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 89 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Kolejne zadanie\" class=\"btn btn-primary\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</center>\r\n");
#nullable restore
#line 96 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
}
else if (ViewBag.Success == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <h2>Egzamin 8 klasisty - Angielski</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "469e33d4e4a255abbd7aac393eb66d66fc8d289016885", async() => {
                WriteLiteral("\r\n        <div class=\"alert alert-success\" role=\"alert\">\r\n            <b>Poprawna odpowiedź!</b>\r\n        </div>\r\n");
#nullable restore
#line 105 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
         foreach (var task in Model.TaskABC)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"container\">\r\n                <div class=\"row align-items-start border\">\r\n                    <div class=\"col-sm-12 border\">\r\n                        <h4><b>Zadanie</b></h4>\r\n                        <h5>");
#nullable restore
#line 111 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                       Write(task.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>A</b></h5>\r\n                            <h6>");
#nullable restore
#line 116 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>APL</b></h5>\r\n                            <h6>");
#nullable restore
#line 120 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option1Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>B</b></h5>\r\n                            <h6>");
#nullable restore
#line 124 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>BPL</b></h5>\r\n                            <h6>");
#nullable restore
#line 128 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option2Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>C</b></h5>\r\n                            <h6>");
#nullable restore
#line 132 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"col-sm-2\">\r\n                            <h5><b>CPL</b></h5>\r\n                            <h6>");
#nullable restore
#line 136 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option3Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-12 border\">\r\n                        <h5><b>Wytłumaczenie</b></h5>\r\n                        <h6>");
#nullable restore
#line 141 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                       Write(task.Explanation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 145 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Kolejne zadanie\" class=\"btn btn-primary\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</center>\r\n");
#nullable restore
#line 152 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    function MutExChkList(chk) {
        var chkList = chk.parentNode.parentNode.parentNode;
        var chks = chkList.getElementsByTagName(""input"");
        for (var i = 0; i < chks.length; i++) {
            if (chks[i] != chk && chk.checked) {
                chks[i].checked = false;
            }
        }
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SicariosSA.ViewModels.TasksABCViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
