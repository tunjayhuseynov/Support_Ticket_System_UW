#pragma checksum "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "393fccf12d31cd0895df7e3484aa5e9bca5e544e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_adminpanel_Views_Home_ViewUser), @"mvc.1.0.view", @"/Areas/adminpanel/Views/Home/ViewUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/adminpanel/Views/Home/ViewUser.cshtml", typeof(AspNetCore.Areas_adminpanel_Views_Home_ViewUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"393fccf12d31cd0895df7e3484aa5e9bca5e544e", @"/Areas/adminpanel/Views/Home/ViewUser.cshtml")]
    public class Areas_adminpanel_Views_Home_ViewUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Upwork_2019_08_08.Models.Admin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewUser.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/adminpanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 96, true);
            WriteLiteral("\r\n\r\n\r\n    <div class=\"container-fluid viewback\">\r\n        <h2 style=\"color:#1c536b\">Admin User #");
            EndContext();
            BeginContext(243, 8, false);
#line 10 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewUser.cshtml"
                                         Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(251, 195, true);
            WriteLiteral("</h2> <br />\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-6\">\r\n                <h3 style=\"color:#1c536b\">Name: </h3>\r\n                <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 446, "\"", 465, 1);
#line 15 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewUser.cshtml"
WriteAttributeValue("", 454, Model.name, 454, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(466, 186, true);
            WriteLiteral(" /> <br />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <h3 style=\"color:#1c536b\">Surname:</h3>\r\n                <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 652, "\"", 674, 1);
#line 19 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewUser.cshtml"
WriteAttributeValue("", 660, Model.surname, 660, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(675, 184, true);
            WriteLiteral(" /> <br />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <h3 style=\"color:#1c536b\">Email:</h3>\r\n                <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 859, "\"", 879, 1);
#line 23 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewUser.cshtml"
WriteAttributeValue("", 867, Model.email, 867, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(880, 185, true);
            WriteLiteral(" /> <br />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <h3 style=\"color:#1c536b\">Status:</h3>\r\n                <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1065, "\"", 1127, 1);
#line 27 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ViewUser.cshtml"
WriteAttributeValue("", 1073, Model.isAdmin==true?"Super Admin":"Account Manager", 1073, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1128, 60, true);
            WriteLiteral(" /> <br />\r\n            </div>\r\n\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Upwork_2019_08_08.Models.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591