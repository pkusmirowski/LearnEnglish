#pragma checksum "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87141c095742f33735597fb47f23f442fa20b379"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AudioTaskGaps), @"mvc.1.0.view", @"/Views/Home/AudioTaskGaps.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87141c095742f33735597fb47f23f442fa20b379", @"/Views/Home/AudioTaskGaps.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6116c02119b1dc59406e1b6ee83ae5a85738e4ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AudioTaskGaps : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SicariosSA.ViewModels.AudioTasksGapsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AudioTaskGaps", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
   ViewData["Title"] = "Zadanie audio z wpisywaniem"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
 if (ViewBag.Standard == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\n    <h2>Egzamin 8 klasisty - Angielski</h2>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87141c095742f33735597fb47f23f442fa20b3794719", async() => {
                WriteLiteral("\n");
#nullable restore
#line 10 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
         foreach (var task in Model.AudioTaskGaps)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\n            <div class=\"row border\">\n                <div class=\"col-sm-12 border\">\n                    <h4>");
#nullable restore
#line 15 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.TaskName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n                </div>\n                <div class=\"col-sm-12 border\">\n                    <audio controls=\"controls\">\n                        <source");
                BeginWriteAttribute("src", " src=\"", 619, "\"", 645, 1);
#nullable restore
#line 19 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
WriteAttributeValue("", 625, task.SoundtrackName, 625, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""audio/mp3"" />
                        <p>Twoja przeglądarka nie obsługuje elementu audio HTML 5</p>
                    </audio>
                </div>
                <div class=""col-sm-12 border"">
                    <h5>Wpisz odpowiedzi:</h5>
                </div>
");
#nullable restore
#line 26 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                 for (int i = 1; i <= 4; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-sm-12\">\n                        <p>Luka ");
#nullable restore
#line 29 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                        <input type=\"text\" id=\"answer\" name=\"answer\" />\n                        <br />\n                    </div>\n");
#nullable restore
#line 33 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\n        </div>\n");
#nullable restore
#line 36 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\n        <div class=\"form-group\">\n            <input type=\"submit\" value=\"Sprawdź odpowiedź\" class=\"btn btn-primary\" />\n        </div>\n    ");
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
            WriteLiteral("\n</center> \n");
#nullable restore
#line 43 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
}
else if (ViewBag.False == false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\n    <h2>Egzamin 8 klasisty - Angielski</h2>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87141c095742f33735597fb47f23f442fa20b3799466", async() => {
                WriteLiteral("\n        <div class=\"alert alert-danger\" role=\"alert\">\n            <b>Zła odpowiedź!</b>\n        </div>\n");
#nullable restore
#line 52 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
         foreach (var task in Model.AudioTaskGaps)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\n            <div class=\"row border\">\n                <div class=\"col-sm-12 border\">\n                    <h4>");
#nullable restore
#line 57 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.TaskName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n                </div>\n                <div class=\"col-sm-12 border\">\n                    <audio controls=\"controls\">\n                        <source");
                BeginWriteAttribute("src", " src=\"", 2045, "\"", 2071, 1);
#nullable restore
#line 61 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
WriteAttributeValue("", 2051, task.SoundtrackName, 2051, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""audio/mp3"" />
                        <p>Your browser does not support HTML 5 audio element</p>
                    </audio>
                </div>
                <div class=""col-sm-12 border"">
                    <h5>Wpisz odpowiedzi:</h5>
                </div>
                <div class=""col-sm-12"">
                    <h6>");
#nullable restore
#line 69 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    <h6>");
#nullable restore
#line 70 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer1Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                </div>\n                <div class=\"col-sm-12\">\n                    <h6>");
#nullable restore
#line 73 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    <h6>");
#nullable restore
#line 74 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer2Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                </div>\n                <div class=\"col-sm-12\">\n                    <h6>");
#nullable restore
#line 77 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    <h6>");
#nullable restore
#line 78 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer3Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                </div>\n                <div class=\"col-sm-12\">\n                    <h6>");
#nullable restore
#line 81 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    <h6>");
#nullable restore
#line 82 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer4Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                </div>\n                <div class=\"col-sm-12 border\">\n                    <h5><b>Wytłumaczenie</b></h5>\n                    <h6>");
#nullable restore
#line 86 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Explanation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 90 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
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
#line 97 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
 }
else if (ViewBag.Success == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\n    <h2>Egzamin 8 klasisty - Angielski</h2>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87141c095742f33735597fb47f23f442fa20b37916218", async() => {
                WriteLiteral("\n        <div class=\"alert alert-success\" role=\"alert\">\n            <b>Poprawna odpowiedź!</b>\n        </div>\n");
#nullable restore
#line 106 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
         foreach (var task in Model.AudioTaskGaps)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"container\">\n            <div class=\"row border\">\n                <div class=\"col-sm-12 border\">\n                    <h4>");
#nullable restore
#line 111 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.TaskName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n                </div>\n                <div class=\"col-sm-12 border\">\n                    <audio controls=\"controls\">\n                        <source");
                BeginWriteAttribute("src", " src=\"", 3948, "\"", 3974, 1);
#nullable restore
#line 115 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
WriteAttributeValue("", 3954, task.SoundtrackName, 3954, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""audio/mp3"" />
                        <p>Your browser does not support HTML 5 audio element</p>
                    </audio>
                </div>
                <div class=""col-sm-12 border"">
                    <h5>Wpisz odpowiedzi:</h5>
                </div>
                <div class=""col-sm-12"">
                    <h6>");
#nullable restore
#line 123 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    <h6>");
#nullable restore
#line 124 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer1Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                </div>\n                <div class=\"col-sm-12\">\n                    <h6>");
#nullable restore
#line 127 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    <h6>");
#nullable restore
#line 128 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer2Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                </div>\n                <div class=\"col-sm-12\">\n                    <h6>");
#nullable restore
#line 131 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    <h6>");
#nullable restore
#line 132 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer3Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                </div>\n                <div class=\"col-sm-12\">\n                    <h6>");
#nullable restore
#line 135 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    <h6>");
#nullable restore
#line 136 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Answer4Pl);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                </div>\n                <div class=\"col-sm-12 border\">\n                    <h5><b>Wytłumaczenie</b></h5>\n                    <h6>");
#nullable restore
#line 140 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
                   Write(task.Explanation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 144 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
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
#line 151 "C:\Users\Paweł\source\repos\SicariosSA\SicariosSA\Views\Home\AudioTaskGaps.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SicariosSA.ViewModels.AudioTasksGapsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
