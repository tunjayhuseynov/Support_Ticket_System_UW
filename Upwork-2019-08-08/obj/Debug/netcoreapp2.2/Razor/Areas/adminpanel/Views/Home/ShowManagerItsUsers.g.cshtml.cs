#pragma checksum "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58d016deedd8ef265c346c2fe5ad95610bac355f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_adminpanel_Views_Home_ShowManagerItsUsers), @"mvc.1.0.view", @"/Areas/adminpanel/Views/Home/ShowManagerItsUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/adminpanel/Views/Home/ShowManagerItsUsers.cshtml", typeof(AspNetCore.Areas_adminpanel_Views_Home_ShowManagerItsUsers))]
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
#line 2 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58d016deedd8ef265c346c2fe5ad95610bac355f", @"/Areas/adminpanel/Views/Home/ShowManagerItsUsers.cshtml")]
    public class Areas_adminpanel_Views_Home_ShowManagerItsUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Upwork_2019_08_08.Models.ClientUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
  
    Layout = "~/Areas/adminpanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(205, 969, true);
            WriteLiteral(@"
<h2>
    Users <span>
        <button type=""button""
                class=""btn txttype"" data-toggle=""modal"" data-target=""#exampleModalCenterUser"">
            <i style=""color:#1c536b"" class=""fas fa-plus-square""> </i> New User
        </button>
    </span>
</h2>
<table class=""table table-bordered responsive "" style=""width: 100%"">
    <thead class=""tablecolor"">
        <tr>
            <th data-priority=""1"" class=""all"" scope=""col"">#</th>
            <th data-priority=""2"" class=""all"" scope=""col"">Name</th>
            <th scope=""col"">Surname</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Active/Inactive</th>
            <th data-priority=""3"" class=""all"" scope=""col"">Action</th>

            <!-- <th>
                <input class=""form-control searchbox"" type=""text"" placeholder=""Search""
                       aria-label=""Search"">

            </th>-->
        </tr>
    </thead>
    <tbody class=""bckwhite"">

");
            EndContext();
#line 35 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
           int index = 0;

#line default
#line hidden
            BeginContext(1202, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 36 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
         foreach (var item in Model)
        {
            index++;

#line default
#line hidden
            BeginContext(1273, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(1324, 16, false);
#line 40 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                           Write(index.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1340, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(1368, 9, false);
#line 41 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1377, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1405, 12, false);
#line 42 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
               Write(item.surname);

#line default
#line hidden
            EndContext();
            BeginContext(1417, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1445, 10, false);
#line 43 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
               Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(1455, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 45 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                     if (item.isActive == true)
                    {

#line default
#line hidden
            BeginContext(1554, 20, true);
            WriteLiteral("<span>Active</span> ");
            EndContext();
#line 46 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                                         }
                    else
                    {

#line default
#line hidden
            BeginContext(1624, 22, true);
            WriteLiteral(" <span>Inactive</span>");
            EndContext();
#line 48 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                                           }

#line default
#line hidden
            BeginContext(1649, 105, true);
            WriteLiteral("                </td>\r\n                <td class=\"aPadding text-center\">\r\n                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1754, "\"", 1867, 4);
            WriteAttributeValue("", 1764, "window.open(\'", 1764, 13, true);
#line 51 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
WriteAttributeValue("", 1777, Url.Action("ViewClientUser","Home", new { id=item.id }), 1777, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 1833, "\',\'Pop", 1833, 6, true);
            WriteAttributeValue(" ", 1839, "Up\',\'width=600,height=400\')", 1840, 28, true);
            EndWriteAttribute();
            BeginContext(1868, 67, true);
            WriteLiteral(" class=\"maincolor\" title=\"View\"><i class=\"fas fa-eye \"></i>  </a>\r\n");
            EndContext();
#line 52 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                     if (HttpContextAccessor.HttpContext.Session.GetInt32("isAdmin") == 1)
                    {
                        

#line default
#line hidden
            BeginContext(2080, 49, true);
            WriteLiteral("\r\n                            <a href=\"#inactive\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2129, "\"", 2179, 6);
            WriteAttributeValue("", 2139, "ChangeActive(", 2139, 13, true);
#line 55 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
WriteAttributeValue("", 2152, item.id, 2152, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2160, ",", 2160, 1, true);
            WriteAttributeValue(" ", 2161, "\'", 2162, 2, true);
#line 55 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
WriteAttributeValue("", 2163, item.isActive, 2163, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 2177, "\')", 2177, 2, true);
            EndWriteAttribute();
            BeginContext(2180, 123, true);
            WriteLiteral(" class=\"maincolor\" title=\"Active/Inactive\"> <i class=\"fas fa-user-lock\"></i> </a>\r\n                            |<a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2303, "\"", 2416, 4);
            WriteAttributeValue("", 2313, "window.open(\'", 2313, 13, true);
#line 56 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
WriteAttributeValue("", 2326, Url.Action("EditClientUser","Home", new { id=item.id }), 2326, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 2382, "\',\'Pop", 2382, 6, true);
            WriteAttributeValue(" ", 2388, "Up\',\'width=600,height=400\')", 2389, 28, true);
            EndWriteAttribute();
            BeginContext(2417, 113, true);
            WriteLiteral(" class=\"maincolor\" title=\"Edit\"> <i class=\"fas fa-edit\"></i> </a>|\r\n                            <a href=\"#delete\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2530, "\"", 2560, 3);
            WriteAttributeValue("", 2540, "myFunction(", 2540, 11, true);
#line 57 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
WriteAttributeValue("", 2551, item.id, 2551, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2559, ")", 2559, 1, true);
            EndWriteAttribute();
            BeginContext(2561, 98, true);
            WriteLiteral(" class=\"maincolor\" title=\"Delete\"> <i class=\"fas fa-trash-alt\"></i> </a>\r\n                        ");
            EndContext();
#line 58 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                               
                    }

#line default
#line hidden
            BeginContext(2691, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <!-- <td></td> -->\r\n\r\n            </tr>\r\n");
            EndContext();
#line 65 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
        }

#line default
#line hidden
            BeginContext(2784, 205, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n<script>\r\n        $(\".table\").DataTable({\r\n        responsive: true,\r\n        dom: \'lBfrtip\',\r\n        buttons: [\r\n            \'pdfHtml5\', \'excel\'\r\n        ]\r\n    });\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Upwork_2019_08_08.Models.ClientUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591