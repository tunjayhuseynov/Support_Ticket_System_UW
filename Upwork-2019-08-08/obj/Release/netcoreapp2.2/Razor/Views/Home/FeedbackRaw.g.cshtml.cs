#pragma checksum "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89e798de70bf5b8d1921861649b8554b72d91e80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FeedbackRaw), @"mvc.1.0.view", @"/Views/Home/FeedbackRaw.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/FeedbackRaw.cshtml", typeof(AspNetCore.Views_Home_FeedbackRaw))]
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
#line 1 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\_ViewImports.cshtml"
using Upwork_2019_08_08;

#line default
#line hidden
#line 2 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\_ViewImports.cshtml"
using Upwork_2019_08_08.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e798de70bf5b8d1921861649b8554b72d91e80", @"/Views/Home/FeedbackRaw.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b52714583bd4ce47bb49aada13d557f257da8ed9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FeedbackRaw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Upwork_2019_08_08.Models.Feedback>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addAction"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(75, 738, true);
            WriteLiteral(@"
<h2>
    Feedbacks <span>
        <button type=""button""
                class=""btn txttype"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
            <i style=""color:#1c536b"" class=""fas fa-plus-square""> </i> Feedback
        </button>
    </span>
</h2>
<table class=""table table-bordered responsive"" style=""width: 100%"">
    <thead class=""tablecolor"">
        <tr>
            <th data-priority=""1"" scope=""col"">#</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">E-mail</th>
            <th data-priority=""2"" scope=""col"">Subject</th>
            <th scope=""col"">Date</th>
            <th data-priority=""3"" scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody class=""bckwhite"">
");
            EndContext();
#line 26 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml"
           int index = 0;

#line default
#line hidden
            BeginContext(841, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 27 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml"
         foreach (var item in Model)
        {
            index++;

#line default
#line hidden
            BeginContext(912, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(963, 16, false);
#line 31 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml"
                           Write(index.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(979, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(1007, 9, false);
#line 32 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml"
               Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1016, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1044, 10, false);
#line 33 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml"
               Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(1054, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1082, 12, false);
#line 34 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml"
               Write(item.subject);

#line default
#line hidden
            EndContext();
            BeginContext(1094, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1122, 44, false);
#line 35 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml"
               Write(item.datetime.ToString("MMMM dd yyyy hh:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 80, true);
            WriteLiteral("</td>\r\n                <td class=\"text-center\"><a href=\"#Show\" class=\"maincolor\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1246, "\"", 1276, 3);
            WriteAttributeValue("", 1256, "getMessage(", 1256, 11, true);
#line 36 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml"
WriteAttributeValue("", 1267, item.id, 1267, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1275, ")", 1275, 1, true);
            EndWriteAttribute();
            BeginContext(1277, 142, true);
            WriteLiteral(" data-target=\"#exampleModalCentermessage\" data-toggle=\"modal\" title=\"Show Message\"><i class=\"fas fa-eye \"></i>  </a></td>\r\n            </tr>\r\n");
            EndContext();
#line 38 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml"
        }

#line default
#line hidden
            BeginContext(1430, 1666, true);
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
    </ul>-->

<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"" style=""max-width: 736px"">
        <div class=""mod");
            WriteLiteral(@"al-content"">
            <div id=""finished"">
                <div class=""d-flex justify-content-center vertical-center-text "">
                    <h3>Successfully Sent  <i style=""color: green;"" class=""far fa-check-circle""></i></h3>
                </div>
            </div>
            <div class=""modal-header model-header-success"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Add Feedback</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(3096, 1352, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89e798de70bf5b8d1921861649b8554b72d91e8010357", async() => {
                BeginContext(3174, 1267, true);
                WriteLiteral(@"

                <div class=""modal-body"">
                    <label for=""Name"">Name:</label><br />
                    <input required type=""text"" name=""name"" class=""form-control"" /> <br />
                    <label for=""email"">E-mail:</label><br />
                    <input required type=""email"" name=""email"" class=""form-control"" /> <br />
                    <label for=""subject"">Subject:</label><br />
                    <input required type=""text"" name=""subject"" class=""form-control"" /> <br />
                    <label for=""text"" style=""font-size: 20px;"">Feedback</label><br>
                    <textarea required name=""text"" class=""form-control"" style=""height: 250px;""></textarea>

                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" id=""submiting"" class=""btn btn-primary"">Add</button>
                </div>
                <div id=""loading"" class=""loadingModel"">
                    <div class=""d-flex justify-content-center vertical-c");
                WriteLiteral("enter \">\r\n                        <div class=\"spinner-grow\" role=\"status\">\r\n                            <span class=\"sr-only\">Loading...</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 78 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Home\FeedbackRaw.cshtml"
AddHtmlAttributeValue("", 3125, Url.Action("AddFeedback","Home"), 3125, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4448, 1610, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
</nav>

<div class=""modal fade"" id=""exampleModalCentermessage"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Message</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""messageboddy"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>


<script>


    $("".table"").DataTable(
        {   responsive: true,
            dom: 'lBfrtip',
            buttons");
            WriteLiteral(@": [
                'pdfHtml5', 'excel',
            ]
        });
    history.replaceState("""", ""Random"", ""/"");
    $("".loadingModel"").hide();
    $(""#finished"").hide();

    $('#addAction').ajaxForm(function () {
        $('#exampleModalCenter').modal('hide')
        $('#exampleModalCenter').on('hidden.bs.modal', function (e) {
            $(""#FeedbackPanel"").click()
        })

    });

    var getMessage = function (id) {
        $.get(""/home/getFeedbackMessage/"" + id, function (data) {
            $(""#messageboddy"").html(data)
        })
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Upwork_2019_08_08.Models.Feedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591