#pragma checksum "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b945b101a23834f8a94027219897ae9862c70a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_adminpanel_Views_Home_Profile), @"mvc.1.0.view", @"/Areas/adminpanel/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/adminpanel/Views/Home/Profile.cshtml", typeof(AspNetCore.Areas_adminpanel_Views_Home_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b945b101a23834f8a94027219897ae9862c70a9", @"/Areas/adminpanel/Views/Home/Profile.cshtml")]
    public class Areas_adminpanel_Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Upwork_2019_08_08.Models.AdminUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\Profile.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/adminpanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 88, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container-fluid viewback\">\r\n    <h2 style=\"color:#1c536b\">Admin User #");
            EndContext();
            BeginContext(239, 8, false);
#line 10 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\Profile.cshtml"
                                     Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(247, 179, true);
            WriteLiteral("</h2> <br />\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Name: </h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 426, "\"", 445, 1);
#line 15 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\Profile.cshtml"
WriteAttributeValue("", 434, Model.name, 434, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(446, 170, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Surname:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 616, "\"", 638, 1);
#line 19 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\Profile.cshtml"
WriteAttributeValue("", 624, Model.surname, 624, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(639, 168, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Email:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 807, "\"", 827, 1);
#line 23 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\Profile.cshtml"
WriteAttributeValue("", 815, Model.email, 815, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(828, 169, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <h3 style=\"color:#1c536b\">Status:</h3>\r\n            <input type=\"text\" class=\"form-control\" disabled");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 997, "\"", 1054, 1);
#line 27 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\Profile.cshtml"
WriteAttributeValue("", 1005, Model.whoIs==1?"Super Admin":"Account Manager", 1005, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1055, 48, true);
            WriteLiteral(" /> <br />\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Upwork_2019_08_08.Models.AdminUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
