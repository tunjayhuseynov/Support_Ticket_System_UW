#pragma checksum "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb4d17ee4bc0fced314c2077b9554bfd4749bba1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_adminpanel_Views_Home_ViewClient), @"mvc.1.0.view", @"/Areas/adminpanel/Views/Home/ViewClient.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/adminpanel/Views/Home/ViewClient.cshtml", typeof(AspNetCore.Areas_adminpanel_Views_Home_ViewClient))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb4d17ee4bc0fced314c2077b9554bfd4749bba1", @"/Areas/adminpanel/Views/Home/ViewClient.cshtml")]
    public class Areas_adminpanel_Views_Home_ViewClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Upwork_2019_08_08.Models.Company>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
  
    ViewData["Title"] = "ViewClient";
    Layout = "~/Areas/adminpanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 80, true);
            WriteLiteral("\r\n<div class=\"container-fluid viewback\">\r\n    <h2 style=\"color:#1c536b\">Client #");
            EndContext();
            BeginContext(234, 8, false);
#line 9 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
                                 Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(242, 187, true);
            WriteLiteral("</h2> <br />\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Company Name: </h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 429, "\"", 448, 1);
#line 14 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 437, Model.name, 437, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(449, 170, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Address:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 619, "\"", 641, 1);
#line 18 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 627, Model.address, 627, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(642, 186, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n            <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Contact Person Name:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 828, "\"", 856, 1);
#line 22 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 836, Model.contactperson, 836, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(857, 168, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Email:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1025, "\"", 1045, 1);
#line 26 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 1033, Model.email, 1033, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1046, 175, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Created Date:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1221, "\"", 1247, 1);
#line 30 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 1229, Model.createdDate, 1229, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1248, 178, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Active/Inactive:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1426, "\"", 1477, 1);
#line 34 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 1434, Model.isActive==true?"Active":"Inactive", 1434, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1478, 50, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Upwork_2019_08_08.Models.Company> Html { get; private set; }
    }
}
#pragma warning restore 1591