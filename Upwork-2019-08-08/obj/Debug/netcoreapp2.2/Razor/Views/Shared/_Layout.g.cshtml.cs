#pragma checksum "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "729075b6744f88f856971b2a938e584a529e4483"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729075b6744f88f856971b2a938e584a529e4483", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b52714583bd4ce47bb49aada13d557f257da8ed9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/images/logo.webp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 6px; width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/images/designlogo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("75"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 39, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(39, 1146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "729075b6744f88f856971b2a938e584a529e44836440", async() => {
                BeginContext(45, 1045, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">


    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">

    <script src=""https://kit.fontawesome.com/b47f0231f5.js""></script>
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js"" crossorigin=""anonymous"">
    </script>



    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.form/4.2.2/jquery.form.min.js"" integrity=""sha384-FzT3vTVGXqf7wRfy8k4BiyzvbNfeYjK+frTVqZeNDFl8woCbF0CYG6g2fMEFFo/i"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/buttons/1.5.6/css/buttons.dataTables.");
                WriteLiteral("min.css\" />\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(1090, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "729075b6744f88f856971b2a938e584a529e44837949", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1143, 35, true);
                WriteLiteral("\r\n    <title>Company name</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1185, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1189, 7690, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "729075b6744f88f856971b2a938e584a529e448310122", async() => {
                BeginContext(1195, 720, true);
                WriteLiteral(@"
    <div id=""loading"">
        <div class=""d-flex justify-content-center vertical-center "">
            <div class=""spinner-grow"" role=""status"">
                <span class=""sr-only"">Loading...</span>
            </div>
        </div>
    </div>
    <section class=""nav"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""div-12"">
                    <div class=""menunav"">
                        <div class=""container-fluid"">

                            <div class=""row"">
                                <div class=""col-12 text-center"">
                                    <div class=""logo nopadding bckwhite"">
                                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1915, "\"", 1949, 1);
#line 47 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1922, Url.Action("Index","Home"), 1922, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1950, 47, true);
                WriteLiteral(">\r\n                                            ");
                EndContext();
                BeginContext(1997, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "729075b6744f88f856971b2a938e584a529e448311744", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2079, 2995, true);
                WriteLiteral(@"
                                        </a>
                                    </div>

                                </div>

                                <div class=""col-12"">
                                    <ul class=""layout-ul nopadding"">
                                        <li class=""activeRoute"">
                                            <a href=""#Dashboard"" onclick=""getPage('IndexRaw')"">
                                                <div class=""text-center"">
                                                    <i class=""fas fa-home""></i>
                                                    <p>
                                                        Dashboard
                                                    </p>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#Ticket"" on");
                WriteLiteral(@"click=""getPage('TicketRaw')"">
                                                <div class=""text-center"">
                                                    <i class=""fas fa-envelope""></i>
                                                    <p>
                                                        Ticket
                                                    </p>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <a id=""FeedbackPanel"" href=""#feedback"" onclick=""getPage('feedbackRaw')"">
                                                <div class=""text-center"">
                                                    <i class=""fas fa-comment""></i>
                                                    <p>
                                                        Feedback
                                                    </p");
                WriteLiteral(@">
                                                </div>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </section>

    <section class=""main"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""web-navbar nopadding"">
                        <div class=""container-fluid"">
                            <div class=""row"">
                                <div class=""col-6 bckwhite"">
                                    <div class=""logo nopadding "">
                                        <a href=""./index.html"">
                                            ");
                EndContext();
                BeginContext(5074, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "729075b6744f88f856971b2a938e584a529e448316281", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5139, 834, true);
                WriteLiteral(@"
                                        </a>
                                    </div>
                                </div>
                                <div class=""col-6 bckwhite "">
                                    <div class=""float-right"">
                                        <div class=""mycard Relative"">
                                            <i class=""fas fa-user""></i>  <span style=""padding-left: 5px; font-weight: 500"">Tunjay Huseynov</span>
                                        </div>
                                        <div class=""ProfileMenu"">
                                            <ul>
                                                <li>Profile</li>
                                                <li>Reset Password</li>
                                                <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5973, "\"", 6008, 1);
#line 120 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5980, Url.Action("LogOut","Home"), 5980, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6009, 492, true);
                WriteLiteral(@" style=""color: white"">Log Out</a></li>
                                            </ul>
                                        </div>
                                    </div>


                                </div>
                            </div>
                        </div>
                    </div>

                </div>

                <div class=""col-12"">

                    <div class=""BodyPart nopadding"" style=""padding: 20px;"">
                        ");
                EndContext();
                BeginContext(6502, 12, false);
#line 136 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(6514, 1389, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </section>


    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""
            integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous"">
    </script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""
            integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous"">
    </script>



    <script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js  ""></script>


    <script src=""https://cdn.datatables.net/buttons/1.5.6/js/dataTables.buttons.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/1.5.6/js/buttons.flash.min.js""></script>

    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js""></scrip");
                WriteLiteral(@"t>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/buttons/1.5.6/js/buttons.html5.min.js""></script>
    ");
                EndContext();
                BeginContext(7903, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "729075b6744f88f856971b2a938e584a529e448321325", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7948, 18, true);
                WriteLiteral("\r\n\r\n    <script>\r\n");
                EndContext();
#line 166 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Shared\_Layout.cshtml"
         if (ViewBag.url != null)
        {
            

#line default
#line hidden
                BeginContext(8030, 19, true);
                WriteLiteral("\r\n\r\n        $.get(\"");
                EndContext();
                BeginContext(8050, 11, false);
#line 170 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Shared\_Layout.cshtml"
          Write(ViewBag.url);

#line default
#line hidden
                EndContext();
                BeginContext(8061, 148, true);
                WriteLiteral("\", function (data) {\r\n            $(\".BodyPart\").html(function () {\r\n                return data\r\n            })\r\n            }\r\n        )\r\n        ");
                EndContext();
#line 176 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Views\Shared\_Layout.cshtml"
               
        }

#line default
#line hidden
                BeginContext(8229, 643, true);
                WriteLiteral(@"
        var $li = $('.layout-ul li a div').click(function () {
            $li.parent().parent().removeClass('activeRoute');
            $(this).parent().parent().addClass('activeRoute');
        });

        var getPage = function (url) {
            $("".BodyPart"").html("""").html('<div id=""loading""> <div class=""d-flex justify-content-center vertical-center ""> <div class=""spinner-grow"" role=""status""> <span class=""sr-only"">Loading...</span></div></div> </div>');
            $.get(""/home/"" + url, function (data) {


                $("".BodyPart"").html(function () { return data })


            })
        }
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8879, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
