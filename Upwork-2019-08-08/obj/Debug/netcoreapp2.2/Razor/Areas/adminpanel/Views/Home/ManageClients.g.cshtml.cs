#pragma checksum "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47abd4e779d396299d65fef92d4aac19dd3a2d22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_adminpanel_Views_Home_ManageClients), @"mvc.1.0.view", @"/Areas/adminpanel/Views/Home/ManageClients.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/adminpanel/Views/Home/ManageClients.cshtml", typeof(AspNetCore.Areas_adminpanel_Views_Home_ManageClients))]
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
#line 2 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47abd4e779d396299d65fef92d4aac19dd3a2d22", @"/Areas/adminpanel/Views/Home/ManageClients.cshtml")]
    public class Areas_adminpanel_Views_Home_ManageClients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Upwork_2019_08_08.Models.Company>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(158, 28, true);
            WriteLiteral("\r\n<h2>\r\n    Clients <span>\r\n");
            EndContext();
#line 10 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
         if (HttpContextAccessor.HttpContext.Session.GetInt32("isAdmin") == 1)
        {

#line default
#line hidden
            BeginContext(277, 238, true);
            WriteLiteral("            <button type=\"button\"\r\n                    class=\"btn txttype\" data-toggle=\"modal\" data-target=\"#exampleModalCenter\">\r\n                <i style=\"color:#1c536b\" class=\"fas fa-plus-square\"> </i> New Client\r\n            </button>");
            EndContext();
#line 15 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
                     }

#line default
#line hidden
            BeginContext(518, 1120, true);
            WriteLiteral(@"        <button type=""button""
                class=""btn txttype"" data-toggle=""modal"" data-target=""#exampleModalCenterUser"">
            <i style=""color:#1c536b"" class=""fas fa-plus-square""> </i> New User
        </button>

    </span>
</h2>
<table class=""table table-bordered responsive "" style=""width: 100%"">
    <thead class=""tablecolor"">
        <tr>
            <th data-priority=""1"" class=""all"" scope=""col"">#</th>
            <th data-priority=""2"" class=""all"" scope=""col"">Company</th>
            <th scope=""col"">Contact</th>
            <th scope=""col"">Adress</th>
            <th scope=""col"">E-mail</th>
            <th class=""all"" scope=""col"">User #</th>
            <th scope=""col"">Created Date</th>
            <th scope=""col"">Created By</th>
            <th scope=""col"">Activity</th>
            <th scope=""col"" style=""width: 200px;"">Action</th>

            <!-- <th>
                <input class=""form-control searchbox"" type=""text"" placeholder=""Search""
                       aria-label=");
            WriteLiteral("\"Search\">\r\n\r\n            </th>-->\r\n        </tr>\r\n    </thead>\r\n    <tbody class=\"bckwhite\">\r\n\r\n");
            EndContext();
#line 46 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
           int index = 0;

#line default
#line hidden
            BeginContext(1666, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 47 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
         foreach (var item in Model)
        {
            index++;

#line default
#line hidden
            BeginContext(1737, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(1788, 16, false);
#line 51 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
                           Write(index.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1804, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(1832, 9, false);
#line 52 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1841, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1869, 18, false);
#line 53 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
               Write(item.contactperson);

#line default
#line hidden
            EndContext();
            BeginContext(1887, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1915, 12, false);
#line 54 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
               Write(item.address);

#line default
#line hidden
            EndContext();
            BeginContext(1927, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1955, 10, false);
#line 55 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
               Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(1965, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1993, 22, false);
#line 56 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
               Write(item.ClientUsers.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2015, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2043, 53, false);
#line 57 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
               Write(item.createdDate.Value.ToString("MMMM dd yyyy hh:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(2096, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2124, 19, false);
#line 58 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
               Write(item.AdminUser.name);

#line default
#line hidden
            EndContext();
            BeginContext(2143, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 60 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
                     if (item.isActive == true)
                    {

#line default
#line hidden
            BeginContext(2248, 6, true);
            WriteLiteral("Active");
            EndContext();
#line 61 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
                                        }
                else
                {

#line default
#line hidden
            BeginContext(2309, 8, true);
            WriteLiteral("Inactive");
            EndContext();
#line 63 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
                                      }

#line default
#line hidden
            BeginContext(2327, 141, true);
            WriteLiteral("            </td>\r\n            <td class=\"aPadding text-center\">\r\n                <a href=\"#\" data-toggle=\"modal\" data-target=\"#exampleModal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2468, "\"", 2557, 4);
            WriteAttributeValue("", 2478, "getLinkForFrame(\'", 2478, 17, true);
#line 66 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
WriteAttributeValue("", 2495, Url.Action("ViewClient","Home", new { id=item.id }), 2495, 52, false);

#line default
#line hidden
            WriteAttributeValue("", 2547, "\',", 2547, 2, true);
            WriteAttributeValue(" ", 2549, "\'View\')", 2550, 8, true);
            EndWriteAttribute();
            BeginContext(2558, 74, true);
            WriteLiteral(" class=\"maincolor\" title=\"View Client\"><i class=\"fas fa-eye \"></i> </a>|\r\n");
            EndContext();
#line 67 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
                 if (HttpContextAccessor.HttpContext.Session.GetInt32("isAdmin") == 1)
                {
                    

#line default
#line hidden
            BeginContext(2765, 86, true);
            WriteLiteral("\r\n                        <a href=\"# \" data-toggle=\"modal\" data-target=\"#exampleModal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2851, "\"", 2940, 4);
            WriteAttributeValue("", 2861, "getLinkForFrame(\'", 2861, 17, true);
#line 70 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
WriteAttributeValue("", 2878, Url.Action("EditClient","Home", new { id=item.id }), 2878, 52, false);

#line default
#line hidden
            WriteAttributeValue("", 2930, "\',", 2930, 2, true);
            WriteAttributeValue(" ", 2932, "\'Edit\')", 2933, 8, true);
            EndWriteAttribute();
            BeginContext(2941, 111, true);
            WriteLiteral(" class=\"maincolor\" title=\"Edit\"> <i class=\"fas fa-edit\"></i> </a>|\r\n                        <a href=\"#inactive\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3052, "\"", 3102, 6);
            WriteAttributeValue("", 3062, "ChangeActive(", 3062, 13, true);
#line 71 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
WriteAttributeValue("", 3075, item.id, 3075, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3083, ",", 3083, 1, true);
            WriteAttributeValue(" ", 3084, "\'", 3085, 2, true);
#line 71 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
WriteAttributeValue("", 3086, item.isActive, 3086, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 3100, "\')", 3100, 2, true);
            EndWriteAttribute();
            BeginContext(3103, 127, true);
            WriteLiteral(" class=\"maincolor\" title=\"Active/Inactive\"> <i class=\"fas fa-user-lock\"></i> </a>|\r\n\r\n                        <a href=\"#delete\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3230, "\"", 3260, 3);
            WriteAttributeValue("", 3240, "myFunction(", 3240, 11, true);
#line 73 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
WriteAttributeValue("", 3251, item.id, 3251, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3259, ")", 3259, 1, true);
            EndWriteAttribute();
            BeginContext(3261, 95, true);
            WriteLiteral(" class=\"maincolor\" title=\"Delete\"> <i class=\"fas fa-trash-alt\"></i> </a>|\r\n                    ");
            EndContext();
#line 74 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
                           
                }

#line default
#line hidden
            BeginContext(3384, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3402, "\"", 3466, 1);
#line 76 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
WriteAttributeValue("", 3409, Url.Action("ClientsUserPage","Home", new { id=item.id }), 3409, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3467, 138, true);
            WriteLiteral(" class=\"maincolor\" title=\"Users\"> <i class=\"fas fa-users\"></i></a>\r\n\r\n            </td>\r\n            <!-- <td></td> -->\r\n\r\n        </tr>\r\n");
            EndContext();
#line 82 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
    }

#line default
#line hidden
            BeginContext(3612, 1978, true);
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


<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"" style=""max-width: 736px;"">
        <div class=""modal-content"">
            <div class=""finished"">
                <div class=""d-flex justify-content-center vertical-center-text "">
                    <h3>Successfully Sent <i style=""color: green;"" class=""far fa-check-circle""></i></h3>
                </div>
            </div>
            <div class=""modal-header model-header-success"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Add Client</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <form id=""AddClient""");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 5590, "\"", 5630, 1);
#line 129 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
WriteAttributeValue("", 5599, Url.Action("AddClient","Home"), 5599, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5631, 3458, true);
            WriteLiteral(@" method=""post"">

                <div class=""modal-body"">

                    <div class=""container-fluid"">
                        <div class=""row"">
                            <div class=""col-6"">
                                <div class=""semipadding"">
                                    <label for=""name"" style=""font-size: 20px;"">Company Name:</label><br>
                                    <input data-validation=""required"" name=""name"" class=""form-control"" type=""text"" required /> <br />
                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""semipadding"">
                                    <label for=""contact"" style=""font-size: 20px;"">Contact Person Name:</label><br>
                                    <input data-validation=""required"" name=""contact"" class=""form-control"" type=""text"" required /> <br />
                                </div>
                            </div>
    ");
            WriteLiteral(@"                        <div class=""col-6"">
                                <div class=""semipadding"">
                                    <label for=""email"" style=""font-size: 20px;"">Email Address:</label><br>
                                    <input data-validation=""email"" name=""email"" class=""form-control"" type=""text"" required /> <br />
                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""semipadding"">
                                    <label for=""address"" style=""font-size: 20px;"">Address:</label><br>
                                    <input data-validation=""required"" name=""address"" class=""form-control"" type=""text"" required /> <br />
                                </div>
                            </div>


                        </div>
                    </div>


                </div>
                <div class=""modal-footer"">
                    <button type=""submit""");
            WriteLiteral(@" id=""submiting"" class=""btn btn-primary"">Add</button>
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

<div class=""modal fade"" id=""exampleModalCenterUser"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"" style=""max-width: 736px;"">
        <div class=""modal-content"">
            <div class=""finished"">
                <div class=""d-flex justify-content-center vertical-center-text "">
                    <h3>Successfully Sent <i style=""color: green;"" class=""far fa-check-circle""></i></h3>
                </div>
         ");
            WriteLiteral(@"   </div>
            <div class=""modal-header model-header-success"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Add User</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <form id=""AddUser""");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 9089, "\"", 9127, 1);
#line 197 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
WriteAttributeValue("", 9098, Url.Action("AddUser","Home"), 9098, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9128, 2271, true);
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
            WriteLiteral("Client:</label> <br />\r\n                                    <select class=\"js-example-basic js-states form-control\" name=\"users\" required>\r\n                                        <option disabled selected>Select</option>\r\n");
            EndContext();
#line 231 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
            BeginContext(11512, 51, true);
            WriteLiteral("                                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 11563, "\"", 11579, 1);
#line 233 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
WriteAttributeValue("", 11571, item.id, 11571, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(11580, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(11582, 9, false);
#line 233 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
                                                                Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(11591, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 234 "C:\Users\rajesh\Desktop\Upwork-2019-08-08\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\ManageClients.cshtml"
                                        }

#line default
#line hidden
            BeginContext(11645, 4279, true);
            WriteLiteral(@"
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
            WriteLiteral(@"            columns: [ 0, 1, 2, 3, 4, 5 ,6,7,8]
                }
            },
            {
                extend: 'pdfHtml5',
                exportOptions: {
                    columns: [ 0, 1, 2, 3, 4, 5 ,6,7,8]
                }
            },
        ]
    });

    $('.js-example-basic-multiple').select2({
        placeholder: ""Select users""

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


    history.replaceState("""", ""Random"", ""/adminpanel"");


    $(");
            WriteLiteral(@""".loadingModel"").hide();
    $("".finished"").hide();

    var options = {
        success: function (responseText) {

            if (responseText == ""Taken"") {
                alert(""This email is already taken"")
            }


            $('#exampleModalCenter').modal('hide')

            $('#exampleModalCenter').on('hidden.bs.modal', function (e) {
                $(""#manageclientsmenu"").click()
            })

        },
        beforeSubmit: function (arr, $form, options) {

            $(""#submiting"").click(() => $("".loadingModel"").show())
            $(""#submiting2"").click(() => $("".loadingModel"").show())

        }
    };


    var options2 = {
        success: function (responseText) {

            if (responseText == ""Taken"") {
                alert(""This email is already taken"")
            }

            $('#exampleModalCenterUser').modal('hide')
            $('#exampleModalCenterUser').on('hidden.bs.modal', function (e) {
                $(""#manageclientsmenu""");
            WriteLiteral(@").click()
            })
        },
        beforeSubmit: function (arr, $form, options) {

            $(""#submiting"").click(() => $("".loadingModel"").show())
            $(""#submiting2"").click(() => $("".loadingModel"").show())

        }
    };



    $('#AddClient').ajaxForm(options);

    $('#AddUser').ajaxForm(options2);


    function myFunction(id) {

        var r = confirm(""Are you sure to delete the user?"");

        if (r == true) {
            $.get(""/adminpanel/home/deleteclient/"" + id, function () {
                $(""#manageclientsmenu"").click()
                alert(""Done!"")
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
            $.get(""/adminpanel/home/ChangeActi");
            WriteLiteral("vationClient/\" + id, function () {\r\n                alert(\"Done!\")\r\n                window.location.reload();\r\n            })\r\n        }\r\n        else {\r\n\r\n        }\r\n\r\n    }</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Upwork_2019_08_08.Models.Company>> Html { get; private set; }
    }
}
#pragma warning restore 1591
