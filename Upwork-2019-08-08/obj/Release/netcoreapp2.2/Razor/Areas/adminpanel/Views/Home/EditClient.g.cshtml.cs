#pragma checksum "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b35b8193cbf5e667fea5147d98a5b8acd83acd9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_adminpanel_Views_Home_EditClient), @"mvc.1.0.view", @"/Areas/adminpanel/Views/Home/EditClient.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/adminpanel/Views/Home/EditClient.cshtml", typeof(AspNetCore.Areas_adminpanel_Views_Home_EditClient))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35b8193cbf5e667fea5147d98a5b8acd83acd9f", @"/Areas/adminpanel/Views/Home/EditClient.cshtml")]
    public class Areas_adminpanel_Views_Home_EditClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Upwork_2019_08_08.Models.Company>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml"
  
    ViewData["Title"] = "EditClient";
    Layout = "~/Areas/adminpanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 94, true);
            WriteLiteral("\r\n<style>\r\n    input {\r\n        margin-bottom: 15px;\r\n    }\r\n</style>\r\n\r\n\r\n<form method=\"post\"");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 247, "\"", 295, 1);
#line 15 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml"
WriteAttributeValue("", 256, Url.Action("EditClientProcess","Home"), 256, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(296, 89, true);
            WriteLiteral(">\r\n    <div class=\"container-fluid viewback\">\r\n        <h2 style=\"color:#1c536b\">Client #");
            EndContext();
            BeginContext(386, 8, false);
#line 17 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml"
                                     Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(394, 73, true);
            WriteLiteral("</h2> <br />\r\n        <div class=\"row\">\r\n            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 467, "\"", 484, 1);
#line 19 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml"
WriteAttributeValue("", 475, Model.id, 475, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(485, 170, true);
            WriteLiteral(" name=\"UserId\" />\r\n            <div class=\"col-6\">\r\n                <h3 style=\"color:#1c536b\">Company Name: </h3>\r\n                <input type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 655, "\"", 674, 1);
#line 22 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml"
WriteAttributeValue("", 663, Model.name, 663, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(675, 188, true);
            WriteLiteral(" name=\"name\" /> <br />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <h3 style=\"color:#1c536b\">Adress:</h3>\r\n                <input type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 863, "\"", 885, 1);
#line 26 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml"
WriteAttributeValue("", 871, Model.address, 871, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(886, 204, true);
            WriteLiteral(" name=\"address\" /> <br />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <h3 style=\"color:#1c536b\">Contact Person Name:</h3>\r\n                <input type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1090, "\"", 1118, 1);
#line 30 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml"
WriteAttributeValue("", 1098, Model.contactperson, 1098, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1119, 196, true);
            WriteLiteral(" name=\"contactperson\" /> <br />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <h3 style=\"color:#1c536b\">Email:</h3>\r\n                <input type=\"text\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1315, "\"", 1335, 1);
#line 34 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml"
WriteAttributeValue("", 1323, Model.email, 1323, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1336, 226, true);
            WriteLiteral(" name=\"email\" /> <br />\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <h3 style=\"color:#1c536b\">Active/Inactive:</h3>\r\n                <select name=\"active\" id=\"status\" required class=\"form-control\">\r\n");
            EndContext();
#line 39 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml"
                     if (Model.isActive == true)
                    {

#line default
#line hidden
            BeginContext(1635, 129, true);
            WriteLiteral("                        <option value=\"1\" selected>Active</option>\r\n                        <option value=\"0\">Inactive</option>\r\n");
            EndContext();
#line 43 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1836, 129, true);
            WriteLiteral("                        <option value=\"1\">Active</option>\r\n                        <option value=\"0\" selected>Inactive</option>\r\n");
            EndContext();
#line 48 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\EditClient.cshtml"

                    }

#line default
#line hidden
            BeginContext(1990, 306, true);
            WriteLiteral(@"

                </select> <br />
            </div>
            <div class=""col-12 text-center"">

                <button style=""background: #1c536b; border: #1c536b; margin-top: 35px;"" type=""submit"" class=""btn btn-primary"">Save</button>
            </div>
        </div>
    </div>
</form>

");
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