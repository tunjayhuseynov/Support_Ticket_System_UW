#pragma checksum "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "547fa6f76074e15c236533df3a9a1a70bdb1667d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_adminpanel_Views_Home_TicketRaw), @"mvc.1.0.view", @"/Areas/adminpanel/Views/Home/TicketRaw.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/adminpanel/Views/Home/TicketRaw.cshtml", typeof(AspNetCore.Areas_adminpanel_Views_Home_TicketRaw))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"547fa6f76074e15c236533df3a9a1a70bdb1667d", @"/Areas/adminpanel/Views/Home/TicketRaw.cshtml")]
    public class Areas_adminpanel_Views_Home_TicketRaw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Upwork_2019_08_08.Models.Ticket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(73, 930, true);
            WriteLiteral(@"
<h2>
    Tickets <span>
        <!-- <button type=""button""
                 class=""btn "" data-toggle=""modal"" data-target=""#exampleModalCenter"">
             +Add Ticket
         </button>-->
    </span>
</h2>
<table class=""table table-bordered responsive "" style=""width: 100%"">
    <thead class=""tablecolor"">
        <tr>
            <th scope=""col"">Reference Num.</th>
            <th scope=""col"">Client Name</th>
            <th scope=""col"">Client User Name</th>
            <th scope=""col"">Subject</th>
            <th scope=""col"" style=""width: 170px;"">Date</th>
            <th scope=""col"">Department</th>
            <th scope=""col"">Status</th>
            <th scope=""col"">Action</th>

            <!-- <th>
        <input class=""form-control searchbox"" type=""text"" placeholder=""Search""
               aria-label=""Search"">

    </th>-->
        </tr>
    </thead>
    <tbody class=""bckwhite"">

");
            EndContext();
#line 35 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(1054, 32, true);
            WriteLiteral("        <tr>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1086, "\"", 1144, 1);
#line 39 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
WriteAttributeValue("", 1093, Url.Action("ViewTicket","Home", new {id=item.id }), 1093, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1145, 2, true);
            WriteLiteral(" >");
            EndContext();
            BeginContext(1148, 20, false);
#line 39 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
                                                                          Write(item.TicketRefNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 27, true);
            WriteLiteral("</a></td>\r\n            <td>");
            EndContext();
            BeginContext(1196, 28, false);
#line 40 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
           Write(item.ClientUser.Company.name);

#line default
#line hidden
            EndContext();
            BeginContext(1224, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1248, 20, false);
#line 41 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
           Write(item.ClientUser.name);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1292, 12, false);
#line 42 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
           Write(item.subject);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1328, 44, false);
#line 43 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
           Write(item.datetime.ToString("MMMM dd yyyy hh:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1396, 20, false);
#line 44 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
           Write(item.Department.name);

#line default
#line hidden
            EndContext();
            BeginContext(1416, 60, true);
            WriteLiteral("</td>\r\n            <td class=\"statuscolor statuspadding \">\r\n");
            EndContext();
#line 46 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
                 switch (item.status)
                {
                    case 'n':

#line default
#line hidden
            BeginContext(1565, 108, true);
            WriteLiteral("                        <div style=\"background-color: red\"><span style=\"font-weight: 700\">New</span></div>\r\n");
            EndContext();
#line 50 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
                        break;
                    case 'p':

#line default
#line hidden
            BeginContext(1736, 132, true);
            WriteLiteral("                        <div class=\"\" style=\"background-color: darkorange\"><span style=\"font-weight: 700\">In Progress</span></div>\r\n");
            EndContext();
#line 53 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
                        break;
                    case 'c':

#line default
#line hidden
            BeginContext(1931, 122, true);
            WriteLiteral("                        <div class=\"\" style=\"background-color: green\"><span style=\"font-weight: 700\">Closed</span></div>\r\n");
            EndContext();
#line 56 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
                        break;
                }

#line default
#line hidden
            BeginContext(2104, 57, true);
            WriteLiteral("            </td>\r\n            <td class=\"text-center\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2161, "\"", 2219, 1);
#line 59 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
WriteAttributeValue("", 2168, Url.Action("ViewTicket","Home", new {id=item.id }), 2168, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2220, 120, true);
            WriteLiteral(" title=\"View\" class=\"maincolor\"><i class=\"fas fa-eye \"></i> </a></td>\r\n            <!-- <td></td> -->\r\n\r\n        </tr>\r\n");
            EndContext();
#line 63 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
        }

#line default
#line hidden
            BeginContext(2351, 1673, true);
            WriteLiteral(@"
    </tbody>
</table>
<!--
<nav aria-label=""..."" id=""pagination"">
    <ul class=""pagination justify-content-center"">
        <li class=""page-item disabled"">
            <span class=""page-link"">Previous</span>
        </li>
        <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
        <li class=""page-item active"" aria-current=""page"">
            <span class=""page-link"" style=""background-color: #1c536b; border-color: #1c536b"">
                2
                <span class=""sr-only"">(current)</span>
            </span>
        </li>
        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
        <li class=""page-item"">
            <a class=""page-link"" href=""#"">Next</a>
        </li>
    </ul>
    -->
<!--
<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
     ");
            WriteLiteral(@"       <div id=""finished"">
                <div class=""d-flex justify-content-center vertical-center-text "">
                    <h3>Successfully Sent <i style=""color: green;"" class=""far fa-check-circle""></i></h3>
                </div>
            </div>
            <div class=""modal-header model-header-success"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Add Ticket</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <form id=""addAction"" action=""");
            EndContext();
            BeginContext(4025, 30, false);
#line 102 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\TicketRaw.cshtml"
                                    Write(Url.Action("AddTicket","Home"));

#line default
#line hidden
            EndContext();
            BeginContext(4055, 2466, true);
            WriteLiteral(@""" method=""post"" enctype=""multipart/form-data"">

                <div class=""modal-body"">

                    <label for=""subject"" style=""font-size: 20px;"">Subject:</label><br>
                    <input name=""subject"" class=""form-control"" type=""text"" /> <br />
                    <label for=""text"" style=""font-size: 20px;"">Message:</label> <br />
                    <textarea name=""text"" class=""form-control"" style=""height: 250px;""></textarea> <br />
                    <label for=""files"" style=""font-size: 20px;"">File:</label> <br />
                    <input type=""file"" id=""file"" accept="".pdf, .doc, .jpeg, .png, .jpg"" class=""form-control-file"" name=""files"" multiple />

                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" id=""submiting"" class=""btn btn-primary"">Add</button>
                </div>
                <div id=""loading"" class=""loadingModel"">
                    <div class=""d-flex justify-content-center vertical-center "">
        ");
            WriteLiteral(@"                <div class=""spinner-grow"" role=""status"">
                            <span class=""sr-only"">Loading...</span>
                        </div>
                    </div>
                </div>

            </form>
        </div>
    </div>
</div>
</nav>-->

<script>

    $("".table"").DataTable({
        responsive: true,
        dom: 'lBfrtip',
        buttons: [
                                    {
                extend: 'excelHtml5',
                exportOptions: {
                    columns: [ 0, 1, 2, 3, 4, 5,6,7 ]
                }
            },
            {
                extend: 'pdfHtml5',
                exportOptions: {
                    columns: [ 0, 1, 2, 3, 4, 5,6,7 ]
                }
            },
        ]
    });
    history.replaceState("""", ""Random"", ""/adminpanel"");
   // var uploadField = document.getElementById(""file"");

  /*  uploadField.onchange = function () {
        if (this.files[0].size > 2048000) {
            alert(""File s");
            WriteLiteral(@"ize must be less than 2MB!"");
            this.value = """";
        };
    };*/

    $("".loadingModel"").hide();
    $(""#finished"").hide();
    $(""#submiting"").click(() => $("".loadingModel"").show())
    $('#addAction').ajaxForm(function () {
        $("".loadingModel"").hide();
        $("".model-header-success"").hide();
        $(""#addAction"").hide()
        $(""#finished"").show()



    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Upwork_2019_08_08.Models.Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
