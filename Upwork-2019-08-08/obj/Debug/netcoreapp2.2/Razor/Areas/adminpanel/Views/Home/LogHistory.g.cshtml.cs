#pragma checksum "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\LogHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa22fe2b7446a31243bbabc6ce19e42f44e2350b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_adminpanel_Views_Home_LogHistory), @"mvc.1.0.view", @"/Areas/adminpanel/Views/Home/LogHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/adminpanel/Views/Home/LogHistory.cshtml", typeof(AspNetCore.Areas_adminpanel_Views_Home_LogHistory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa22fe2b7446a31243bbabc6ce19e42f44e2350b", @"/Areas/adminpanel/Views/Home/LogHistory.cshtml")]
    public class Areas_adminpanel_Views_Home_LogHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\tunca\source\repos\Upwork-2019-08-08\Upwork-2019-08-08\Areas\adminpanel\Views\Home\LogHistory.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 1023, true);
            WriteLiteral(@"
<h2>
    Logs <span>
        <!--  <button type=""button""
                  class=""btn "" data-toggle=""modal"" data-target=""#exampleModalCenter"">
              +Add Feedback
          </button>-->
    </span>
</h2>
<table class=""table table-bordered responsive"" style=""width: 100%"">
    <thead class=""tablecolor"">
        <tr>
        <tr>
            <th>id</th>
            <th>clientID</th>
            <th>date</th>
            <th>logStatus</th>

        </tr>
    </thead>
    <tfoot>
        <tr>
            <th>id</th>
            <th>clientID</th>
            <th>date</th>
            <th>logStatus</th>
        </tr>
    </tfoot>
</table>

<script>
    $("".table"").DataTable({
        responsive: true,
        ""processing"": true, // for show progress bar
        ""serverSide"": true, // for process server side
        ""ajax"": {
            ""url"": ""api/Data/Logs"",
            ""type"": ""POST"",
            ""datatype"": ""json""
        },
        

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591