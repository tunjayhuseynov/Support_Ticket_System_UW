#pragma checksum "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e353bdf7fc40973df87879b99be5abb7b34a64b"
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
#line 2 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e353bdf7fc40973df87879b99be5abb7b34a64b", @"/Areas/adminpanel/Views/Home/ShowManagerItsUsers.cshtml")]
    public class Areas_adminpanel_Views_Home_ShowManagerItsUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Upwork_2019_08_08.Models.ClientUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
  
    Layout = "~/Areas/adminpanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(205, 1011, true);
            WriteLiteral(@"
    <h2>
        Users
        <!--<span>
        <button type=""button""
                class=""btn txttype"" data-toggle=""modal"" data-target=""#exampleModalCenterUser"">
            <i style=""color:#1c536b"" class=""fas fa-plus-square""> </i> New User
        </button>
    </span>-->
    </h2>
<table class=""table table-bordered responsive "" style=""width: 100%"">
    <thead class=""tablecolor"">
        <tr>
            <th data-priority=""1"" class=""all"" scope=""col"">#</th>
            <th data-priority=""2"" class=""all"" scope=""col"">Name</th>
            <th scope=""col"">Surname</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Activity</th>
            <th data-priority=""3"" class=""all"" scope=""col"" style=""width: 65px;"">Action</th>

            <!-- <th>
                <input class=""form-control searchbox"" type=""text"" placeholder=""Search""
                       aria-label=""Search"">

            </th>-->
        </tr>
    </thead>
    <tbody class=""bckwhite"">

");
            EndContext();
#line 36 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
           int index = 0;

#line default
#line hidden
            BeginContext(1244, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 37 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
         foreach (var item in Model)
        {
            index++;

#line default
#line hidden
            BeginContext(1315, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(1366, 16, false);
#line 41 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                           Write(index.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1382, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(1410, 9, false);
#line 42 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1419, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1447, 12, false);
#line 43 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
               Write(item.surname);

#line default
#line hidden
            EndContext();
            BeginContext(1459, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1487, 10, false);
#line 44 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
               Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(1497, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 46 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                     if (item.isActive == true)
                    {

#line default
#line hidden
            BeginContext(1596, 20, true);
            WriteLiteral("<span>Active</span> ");
            EndContext();
#line 47 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                                         }
                    else
                    {

#line default
#line hidden
            BeginContext(1666, 22, true);
            WriteLiteral(" <span>Inactive</span>");
            EndContext();
#line 49 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                                           }

#line default
#line hidden
            BeginContext(1691, 153, true);
            WriteLiteral("                </td>\r\n                <td class=\"aPadding text-center\">\r\n                    <a href=\"#\" data-toggle=\"modal\" data-target=\"#exampleModal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1844, "\"", 1937, 4);
            WriteAttributeValue("", 1854, "getLinkForFrame(\'", 1854, 17, true);
#line 52 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
WriteAttributeValue("", 1871, Url.Action("ViewClientUser","Home", new { id=item.id }), 1871, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 1927, "\',", 1927, 2, true);
            WriteAttributeValue(" ", 1929, "\'View\')", 1930, 8, true);
            EndWriteAttribute();
            BeginContext(1938, 67, true);
            WriteLiteral(" class=\"maincolor\" title=\"View\"><i class=\"fas fa-eye \"></i>  </a>\r\n");
            EndContext();
#line 53 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                     if (HttpContextAccessor.HttpContext.Session.GetInt32("isAdmin") == 1)
                    {
                        

#line default
#line hidden
            BeginContext(2150, 50, true);
            WriteLiteral("\r\n                            |<a href=\"#inactive\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2200, "\"", 2250, 6);
            WriteAttributeValue("", 2210, "ChangeActive(", 2210, 13, true);
#line 56 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
WriteAttributeValue("", 2223, item.id, 2223, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2231, ",", 2231, 1, true);
            WriteAttributeValue(" ", 2232, "\'", 2233, 2, true);
#line 56 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
WriteAttributeValue("", 2234, item.isActive, 2234, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 2248, "\')", 2248, 2, true);
            EndWriteAttribute();
            BeginContext(2251, 170, true);
            WriteLiteral(" class=\"maincolor\" title=\"Active/Inactive\"> <i class=\"fas fa-user-lock\"></i> </a>\r\n                            <a href=\"#\" data-toggle=\"modal\" data-target=\"#exampleModal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2421, "\"", 2514, 4);
            WriteAttributeValue("", 2431, "getLinkForFrame(\'", 2431, 17, true);
#line 57 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
WriteAttributeValue("", 2448, Url.Action("EditClientUser","Home", new { id=item.id }), 2448, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 2504, "\',", 2504, 2, true);
            WriteAttributeValue(" ", 2506, "\'Edit\')", 2507, 8, true);
            EndWriteAttribute();
            BeginContext(2515, 113, true);
            WriteLiteral(" class=\"maincolor\" title=\"Edit\"> <i class=\"fas fa-edit\"></i> </a>|\r\n                            <a href=\"#delete\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2628, "\"", 2658, 3);
            WriteAttributeValue("", 2638, "myFunction(", 2638, 11, true);
#line 58 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
WriteAttributeValue("", 2649, item.id, 2649, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2657, ")", 2657, 1, true);
            EndWriteAttribute();
            BeginContext(2659, 125, true);
            WriteLiteral(" class=\"maincolor\" title=\"Delete\" style=\"padding-left: 6px;\"> <i class=\"fas fa-trash-alt\"></i> </a>\r\n                        ");
            EndContext();
#line 59 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
                               
                    }

#line default
#line hidden
            BeginContext(2816, 82, true);
            WriteLiteral("\r\n                </td>\r\n                <!-- <td></td> -->\r\n\r\n            </tr>\r\n");
            EndContext();
#line 66 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ShowManagerItsUsers.cshtml"
        }

#line default
#line hidden
            BeginContext(2909, 2987, true);
            WriteLiteral(@"
    </tbody>
</table>



<!--Edit View Model-->

<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"" style=""max-width: 453px"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" style=""margin: -22px -15px;"">
                <div id=""rf"" class=""spinner-grow"" role=""status"">
                    <span class=""sr-only"">Loading...</span>
                </div>
                <iframe id=""MyFrame"" scrolling=""no"" src="""" width=""450"" height=""450"" style=""border: none;""></iframe>


            </div>

        </div>
    </div>
</div>

<!--End");
            WriteLiteral(@" of the Edit View Modal-->

<script>
    $("".table"").DataTable({
        responsive: true,
        dom: 'lBfrtip',
        buttons: [
                                    {
                extend: 'excelHtml5',
                exportOptions: {
                    columns: [ 0, 1, 2, 3, 4 ]
                }
            },
            {
                extend: 'pdfHtml5',
                exportOptions: {
                    columns: [ 0, 1, 2, 3, 4 ]
                }
            },
        ]
    });

    var getIframe = document.getElementById(""MyFrame"");

    function getLinkForFrame(link, type) {
        getIframe.style.visibility = ""hidden""
        $(""#rf"").show();
        $(""#exampleModalLabel"").html(type)
        getIframe.src = link;

        getIframe.addEventListener(""load"", function () {
            getIframe.style.visibility = ""visible""
            var $body = $('#MyFrame').contents().find('body')
            $body.find("".web-navbar"").remove()
            $body.find(");
            WriteLiteral(@""".mobiletab"").remove()
            $(""#rf"").hide()
        })

    }

        function myFunction(id) {

        var r = confirm(""Are you sure to delete the user?"");

        if (r == true) {
            $.get(""/adminpanel/home/deleteclientuser/"" + id, function () {
                alert(""Done!"")
                window.location.reload();
            })
        }
        else {

        }

    }

    function ChangeActive(id, status) {

        var r;

        if (status == ""True"") {
            r = confirm(""Are you sure to make inactive the user?"");
        } else {
            r = confirm(""Are you sure to make active the user?"");

        }

        if (r == true) {
            $.get(""/adminpanel/home/ChangeActivationUser/"" + id, function () {
                alert(""Done!"")
                window.location.reload();
            })
        }
        else {

        }

    }
</script>");
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
