#pragma checksum "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "643f18452963880abe49e30d706cc2fc9baa1882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_adminpanel_Views_Home_ClientsUserPage), @"mvc.1.0.view", @"/Areas/adminpanel/Views/Home/ClientsUserPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/adminpanel/Views/Home/ClientsUserPage.cshtml", typeof(AspNetCore.Areas_adminpanel_Views_Home_ClientsUserPage))]
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
#line 2 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"643f18452963880abe49e30d706cc2fc9baa1882", @"/Areas/adminpanel/Views/Home/ClientsUserPage.cshtml")]
    public class Areas_adminpanel_Views_Home_ClientsUserPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Upwork_2019_08_08.Models.ClientUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
  
    ViewData["Title"] = "ClientsUserPage";
    Layout = "~/Areas/adminpanel/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(249, 21, true);
            WriteLiteral("\r\n<h2>\r\n    Users of ");
            EndContext();
            BeginContext(271, 12, false);
#line 10 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
        Write(ViewBag.name);

#line default
#line hidden
            EndContext();
            BeginContext(283, 952, true);
            WriteLiteral(@" <span>
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
#line 36 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
           int index = 0;

#line default
#line hidden
            BeginContext(1263, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 37 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
         foreach (var item in Model)
        {
            index++;

#line default
#line hidden
            BeginContext(1334, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(1385, 16, false);
#line 41 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
                           Write(index.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1401, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(1429, 9, false);
#line 42 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1438, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1466, 12, false);
#line 43 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
               Write(item.surname);

#line default
#line hidden
            EndContext();
            BeginContext(1478, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1506, 10, false);
#line 44 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
               Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(1516, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 46 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
                     if (item.isActive == true)
                    {

#line default
#line hidden
            BeginContext(1615, 20, true);
            WriteLiteral("<span>Active</span> ");
            EndContext();
#line 47 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
                                         }
                    else
                    {

#line default
#line hidden
            BeginContext(1685, 22, true);
            WriteLiteral(" <span>Inactive</span>");
            EndContext();
#line 49 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
                                           }

#line default
#line hidden
            BeginContext(1710, 141, true);
            WriteLiteral("            </td>\r\n            <td class=\"aPadding text-center\">\r\n                <a href=\"#\" data-toggle=\"modal\" data-target=\"#exampleModal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1851, "\"", 1944, 4);
            WriteAttributeValue("", 1861, "getLinkForFrame(\'", 1861, 17, true);
#line 52 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
WriteAttributeValue("", 1878, Url.Action("ViewClientUser","Home", new { id=item.id }), 1878, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 1934, "\',", 1934, 2, true);
            WriteAttributeValue(" ", 1936, "\'View\')", 1937, 8, true);
            EndWriteAttribute();
            BeginContext(1945, 67, true);
            WriteLiteral(" class=\"maincolor\" title=\"View\"><i class=\"fas fa-eye \"></i>  </a>\r\n");
            EndContext();
#line 53 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetInt32("isAdmin") == 1)
                {

#line default
#line hidden
            BeginContext(2202, 41, true);
            WriteLiteral("\r\n                    <a href=\"#inactive\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2243, "\"", 2293, 6);
            WriteAttributeValue("", 2253, "ChangeActive(", 2253, 13, true);
#line 56 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
WriteAttributeValue("", 2266, item.id, 2266, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2274, ",", 2274, 1, true);
            WriteAttributeValue(" ", 2275, "\'", 2276, 2, true);
#line 56 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
WriteAttributeValue("", 2277, item.isActive, 2277, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 2291, "\')", 2291, 2, true);
            EndWriteAttribute();
            BeginContext(2294, 115, true);
            WriteLiteral(" class=\"maincolor\" title=\"Active/Inactive\"> <i class=\"fas fa-user-lock\"></i> </a>\r\n                    |<a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2409, "\"", 2502, 4);
            WriteAttributeValue("", 2419, "getLinkForFrame(\'", 2419, 17, true);
#line 57 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
WriteAttributeValue("", 2436, Url.Action("EditClientUser","Home", new { id=item.id }), 2436, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 2492, "\',", 2492, 2, true);
            WriteAttributeValue(" ", 2494, "\'Edit\')", 2495, 8, true);
            EndWriteAttribute();
            BeginContext(2503, 153, true);
            WriteLiteral(" class=\"maincolor\" data-toggle=\"modal\" data-target=\"#exampleModal\" title=\"Edit\"> <i class=\"fas fa-edit\"></i> </a>|\r\n                    <a href=\"#delete\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2656, "\"", 2686, 3);
            WriteAttributeValue("", 2666, "myFunction(", 2666, 11, true);
#line 58 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
WriteAttributeValue("", 2677, item.id, 2677, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2685, ")", 2685, 1, true);
            EndWriteAttribute();
            BeginContext(2687, 90, true);
            WriteLiteral(" class=\"maincolor\" title=\"Delete\"> <i class=\"fas fa-trash-alt\"></i> </a>\r\n                ");
            EndContext();
#line 59 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
                       
            }

#line default
#line hidden
            BeginContext(2801, 70, true);
            WriteLiteral("\r\n            </td>\r\n            <!-- <td></td> -->\r\n\r\n        </tr>\r\n");
            EndContext();
#line 66 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
    }

#line default
#line hidden
            BeginContext(2878, 1980, true);
            WriteLiteral(@"
    </tbody>
</table>

<!--Edit View Model-->

<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"" style=""max-width: 603px"">
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
                <iframe id=""MyFrame"" scrolling=""no"" src="""" width=""600"" height=""600"" style=""border: none;""></iframe>


            </div>

        </div>
    </div>
</div>

<!--End of ");
            WriteLiteral(@"the Edit View Modal-->



<div class=""modal fade"" id=""exampleModalCenterUser"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"" style=""max-width: 736px;"">
        <div class=""modal-content"">
            <div class=""finished"">
                <div class=""d-flex justify-content-center vertical-center-text "">
                    <h3>Successfully Sent <i style=""color: green;"" class=""far fa-check-circle""></i></h3>
                </div>
            </div>
            <div class=""modal-header model-header-success"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Add User</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <form id=""AddUser""");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 4858, "\"", 4896, 1);
#line 114 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
WriteAttributeValue("", 4867, Url.Action("AddUser","Home"), 4867, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4897, 2244, true);
            WriteLiteral(@" method=""post"">

                <div class=""modal-body"">
                    <div class=""container-fluid"">
                        <div class=""row"">
                            <div class=""col-6"">
                                <div class=""semipadding"">
                                    <label for=""name"" style=""font-size: 20px;"">Name:</label><br>
                                    <input data-validation=""required"" name=""name"" class=""form-control"" type=""text"" required /> <br />
                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""semipadding"">
                                    <label for=""surname"" style=""font-size: 20px;"">Surname:</label> <br />
                                    <input data-validation=""required"" name=""surname"" class=""form-control"" type=""text"" required /> <br />
                                </div>
                            </div>
                       ");
            WriteLiteral(@"     <div class=""col-6"">
                                <div class=""semipadding"">
                                    <label for=""email"" style=""font-size: 20px;"">Email Address:</label><br>
                                    <input data-validation=""email"" name=""email"" class=""form-control"" type=""text"" required /> <br />
                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""semipadding"">
                                    <label for=""password"" style=""font-size: 20px;"">Password:</label><br>
                                    <input data-validation=""required"" name=""password"" class=""form-control"" type=""password"" required /> <br />
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""semipadding"">
                                    <label for=""users"" style=""font-size: 20px;"">");
            WriteLiteral("Client:</label> <br />\r\n                                    <select class=\"js-example-basic js-states form-control\" name=\"users\" required>\r\n                                        <option selected");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 7141, "\"", 7160, 1);
#line 147 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
WriteAttributeValue("", 7149, ViewBag.id, 7149, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7161, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(7163, 12, false);
#line 147 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ClientsUserPage.cshtml"
                                                                        Write(ViewBag.name);

#line default
#line hidden
            EndContext();
            BeginContext(7175, 3434, true);
            WriteLiteral(@"</option>

                                    </select>
                                </div>
                            </div>


                        </div>
                    </div>





                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" id=""submiting2"" class=""btn btn-primary"">Add</button>
                </div>
                <div class=""loadingModel"">
                    <div class=""d-flex justify-content-center vertical-center "">
                        <div class=""spinner-grow"" role=""status"">
                            <span class=""sr-only"">Loading...</span>
                        </div>
                    </div>
                </div>

            </form>
        </div>
    </div>
</div>
<script>
    $("".table"").DataTable({
        responsive: true,
        dom: 'lBfrtip',
        buttons: [
                 {
                extend: 'excelHtml5',
                exportOptions: {
                  ");
            WriteLiteral(@"  columns: [ 0, 1, 2, 3, 4 ]
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
            $body.find("".mobiletab"").remove()
            $(""#rf"").hide()
        })

    }



    //history.replaceState("""", ""Random"", ""/adminpanel"");


    $("".loadingModel"").hide();
    $("".finished"").hide();


    var options2 = {
        success: function (responseText) {");
            WriteLiteral(@"

            if (responseText == ""Taken"") {
                alert(""This email is already taken"")
            }

            $('#exampleModalCenterUser').modal('hide')
            $('#exampleModalCenterUser').on('hidden.bs.modal', function (e) {
                $(""#manageclientsmenu"").click()
            })
        },
        beforeSubmit: function (arr, $form, options) {


            $(""#submiting2"").click(() => $("".loadingModel"").show())

        }
    };


    $('#AddUser').ajaxForm(options2);


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
            r = confirm(""Are you sure to make inactive the use");
            WriteLiteral(@"r?"");
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

    }</script>
");
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
