#pragma checksum "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5e841859a173e4c328379785be5df2020f176bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_DetailsVisit), @"mvc.1.0.view", @"/Views/Patients/DetailsVisit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patients/DetailsVisit.cshtml", typeof(AspNetCore.Views_Patients_DetailsVisit))]
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
#line 1 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\_ViewImports.cshtml"
using ClinicSystem;

#line default
#line hidden
#line 2 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\_ViewImports.cshtml"
using ClinicSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5e841859a173e4c328379785be5df2020f176bb", @"/Views/Patients/DetailsVisit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11d0d4cf5addf39c27211dbcba3106f2ee91eedb", @"/Views/_ViewImports.cshtml")]
    public class Views_Patients_DetailsVisit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicSystem.Models.Visit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditVisit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexVisit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
  
    ViewData["Title"] = "Visit Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Visit</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(252, 42, false);
#line 15 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayNameFor(model => model.SFName));

#line default
#line hidden
            EndContext();
            BeginContext(294, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(338, 38, false);
#line 18 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayFor(model => model.SFName));

#line default
#line hidden
            EndContext();
            BeginContext(376, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(420, 42, false);
#line 21 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayNameFor(model => model.SLName));

#line default
#line hidden
            EndContext();
            BeginContext(462, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(506, 38, false);
#line 24 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayFor(model => model.SLName));

#line default
#line hidden
            EndContext();
            BeginContext(544, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(588, 46, false);
#line 27 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayNameFor(model => model.Specialist));

#line default
#line hidden
            EndContext();
            BeginContext(634, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(678, 42, false);
#line 30 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayFor(model => model.Specialist));

#line default
#line hidden
            EndContext();
            BeginContext(720, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(764, 45, false);
#line 33 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayNameFor(model => model.Complaint));

#line default
#line hidden
            EndContext();
            BeginContext(809, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(853, 41, false);
#line 36 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayFor(model => model.Complaint));

#line default
#line hidden
            EndContext();
            BeginContext(894, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(938, 45, false);
#line 39 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayNameFor(model => model.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(983, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1027, 41, false);
#line 42 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayFor(model => model.Diagnosis));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1112, 45, false);
#line 45 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayNameFor(model => model.VisitDate));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1201, 41, false);
#line 48 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayFor(model => model.VisitDate));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1286, 45, false);
#line 51 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayNameFor(model => model.PatientId));

#line default
#line hidden
            EndContext();
            BeginContext(1331, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1375, 41, false);
#line 54 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
       Write(Html.DisplayFor(model => model.PatientId));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1463, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99820e7b564b48a99599c9c84ed8b1f3", async() => {
                BeginContext(1519, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\d.dosymbek\Google Диск\Обучение\repos\ClinicSystem\ClinicSystem\Views\Patients\DetailsVisit.cshtml"
                                WriteLiteral(Model.VisitId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1527, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1535, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2593bb2f6cf042618e909e87865edcba", async() => {
                BeginContext(1562, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1578, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicSystem.Models.Visit> Html { get; private set; }
    }
}
#pragma warning restore 1591
