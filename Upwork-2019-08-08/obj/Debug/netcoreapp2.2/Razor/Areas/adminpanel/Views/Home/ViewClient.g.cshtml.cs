#pragma checksum "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66b4070e5cf9a60d9de5cbc1d777f09b146372ee"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b4070e5cf9a60d9de5cbc1d777f09b146372ee", @"/Areas/adminpanel/Views/Home/ViewClient.cshtml")]
    public class Areas_adminpanel_Views_Home_ViewClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Upwork_2019_08_08.Models.Company>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
  
    ViewData["Title"] = "ViewClient";
    Layout = "~/Areas/adminpanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 80, true);
            WriteLiteral("\r\n<div class=\"container-fluid viewback\">\r\n    <h2 style=\"color:#1c536b\">Client #");
            EndContext();
            BeginContext(234, 8, false);
#line 9 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
                                 Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(242, 187, true);
            WriteLiteral("</h2> <br />\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Company Name: </h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 429, "\"", 448, 1);
#line 14 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 437, Model.name, 437, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(449, 170, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Address:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 619, "\"", 641, 1);
#line 18 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 627, Model.address, 627, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(642, 179, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n            <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Contact Name:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 821, "\"", 849, 1);
#line 22 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 829, Model.contactperson, 829, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(850, 168, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Email:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1018, "\"", 1038, 1);
#line 26 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 1026, Model.email, 1026, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1039, 175, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Created Date:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1214, "\"", 1240, 1);
#line 30 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 1222, Model.createdDate, 1222, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1241, 178, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Active/Inactive:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1419, "\"", 1470, 1);
#line 34 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewClient.cshtml"
WriteAttributeValue("", 1427, Model.isActive==true?"Active":"Inactive", 1427, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1471, 50, true);
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
