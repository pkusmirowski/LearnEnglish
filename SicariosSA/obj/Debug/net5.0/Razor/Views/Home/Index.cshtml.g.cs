#pragma checksum "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da7b53dfa48121e3135d9715370f8ed6cdee3120"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da7b53dfa48121e3135d9715370f8ed6cdee3120", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6116c02119b1dc59406e1b6ee83ae5a85738e4ba", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
 if (ViewBag.Standard == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <center>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da7b53dfa48121e3135d9715370f8ed6cdee31204567", async() => {
                WriteLiteral("\n");
#nullable restore
#line 10 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
             foreach (var task in Model.TaskABC)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"container box-color\">\n                    <div class=\"row border\">\n                        <div class=\"col-sm-12 border\">\n                            <h4><b>Zadanie</b></h4>\n                            <h5>");
#nullable restore
#line 16 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                        </div>\n                        <div class=\"col-sm-4\">\n                            <h5><b>A</b></h5>\n                            <h6><input type=\"checkbox\" name=\"answer\"");
                BeginWriteAttribute("value", " value=\"", 697, "\"", 718, 1);
#nullable restore
#line 20 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
WriteAttributeValue("", 705, task.Option1, 705, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"MutExChkList(this);\" /> ");
#nullable restore
#line 20 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                                                                                                                       Write(task.Option1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-4\">\n                            <h5><b>B</b></h5>\n                            <h6><input type=\"checkbox\" name=\"answer\"");
                BeginWriteAttribute("value", " value=\"", 964, "\"", 985, 1);
#nullable restore
#line 24 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
WriteAttributeValue("", 972, task.Option2, 972, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"MutExChkList(this);\" /> ");
#nullable restore
#line 24 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                                                                                                                       Write(task.Option2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-4\">\n                            <h5><b>C</b></h5>\n                            <h6><input type=\"checkbox\" name=\"answer\"");
                BeginWriteAttribute("value", " value=\"", 1231, "\"", 1252, 1);
#nullable restore
#line 28 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
WriteAttributeValue("", 1239, task.Option3, 1239, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" onclick=\"MutExChkList(this);\" /> ");
#nullable restore
#line 28 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                                                                                                                       Write(task.Option3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 32 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\n            <div class=\"form-group\">\n                <input type=\"submit\" value=\"Sprawdź odpowiedź\" class=\"btn btn-primary\" />\n            </div>\n        ");
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
            WriteLiteral("\n    </center>\n");
#nullable restore
#line 39 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
}
else if (ViewBag.False == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da7b53dfa48121e3135d9715370f8ed6cdee312010496", async() => {
                WriteLiteral("\n        <div class=\"alert alert-danger\" role=\"alert\">\n            <b>Zła odpowiedź!</b>\n        </div>\n");
#nullable restore
#line 47 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
         foreach (var task in Model.TaskABC)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"container box-color\">\n                <div class=\"row align-items-start border\">\n                    <div class=\"col-sm-12 border\">\n                        <h4><b>Zadanie</b></h4>\n                        <h5>");
#nullable restore
#line 53 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                       Write(task.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                    </div>\n                    <div class=\"row\">\n                        <div class=\"col-sm-12\">\n                            <h5><b>A</b></h5>\n                            <h6>");
#nullable restore
#line 58 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-12\">\n                            <h5><b>APL</b></h5>\n                            <h6>");
#nullable restore
#line 62 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option1Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-12\">\n                            <h5><b>B</b></h5>\n                            <h6>");
#nullable restore
#line 66 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-12\">\n                            <h5><b>BPL</b></h5>\n                            <h6>");
#nullable restore
#line 70 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option2Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-12\">\n                            <h5><b>C</b></h5>\n                            <h6>");
#nullable restore
#line 74 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-12\">\n                            <h5><b>CPL</b></h5>\n                            <h6>");
#nullable restore
#line 78 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option3Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                    </div>\n                    <div class=\"col-sm-12 border\">\n                        <h5><b>Wytłumaczenie</b></h5>\n                        <h6>");
#nullable restore
#line 83 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                       Write(task.Explanation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 87 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\n        <div class=\"form-group\">\n            <input type=\"submit\" value=\"Kolejne zadanie\" class=\"btn btn-primary\" />\n        </div>\n    ");
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
            WriteLiteral("\n</center>\n");
#nullable restore
#line 94 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
}
else if (ViewBag.Success == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da7b53dfa48121e3135d9715370f8ed6cdee312016588", async() => {
                WriteLiteral("\n        <div class=\"alert alert-success\" role=\"alert\">\n            <b>Poprawna odpowiedź!</b>\n        </div>\n");
#nullable restore
#line 102 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
         foreach (var task in Model.TaskABC)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"container box-color\">\n                <div class=\"row align-items-start border\">\n                    <div class=\"col-sm-12 border\">\n                        <h4><b>Zadanie</b></h4>\n                        <h5>");
#nullable restore
#line 108 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                       Write(task.Question);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                    </div>\n                    <div class=\"row\">\n                        <div class=\"col-sm-12\">\n                            <h5><b>A</b></h5>\n                            <h6>");
#nullable restore
#line 113 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-12\">\n                            <h5><b>APL</b></h5>\n                            <h6>");
#nullable restore
#line 117 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option1Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-12\">\n                            <h5><b>B</b></h5>\n                            <h6>");
#nullable restore
#line 121 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-12\">\n                            <h5><b>BPL</b></h5>\n                            <h6>");
#nullable restore
#line 125 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option2Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-12\">\n                            <h5><b>C</b></h5>\n                            <h6>");
#nullable restore
#line 129 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                        <div class=\"col-sm-12\">\n                            <h5><b>CPL</b></h5>\n                            <h6>");
#nullable restore
#line 133 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                           Write(task.Option3Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                        </div>\n                    </div>\n                    <div class=\"col-sm-12 border\">\n                        <h5><b>Wytłumaczenie</b></h5>\n                        <h6>");
#nullable restore
#line 138 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
                       Write(task.Explanation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 142 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\n        <div class=\"form-group\">\n            <input type=\"submit\" value=\"Kolejne zadanie\" class=\"btn btn-primary\" />\n        </div>\n    ");
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
            WriteLiteral("\n</center>\n");
#nullable restore
#line 149 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\Index.cshtml"
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
