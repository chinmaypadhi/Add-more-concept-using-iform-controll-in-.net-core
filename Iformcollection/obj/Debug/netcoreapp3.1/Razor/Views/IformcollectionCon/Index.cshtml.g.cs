#pragma checksum "C:\Users\Asus\OneDrive\Desktop\IForm Collection add more concept\Iformcollection\Views\IformcollectionCon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3df2deefa4b3be3d023593eda5448175462161a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IformcollectionCon_Index), @"mvc.1.0.view", @"/Views/IformcollectionCon/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Asus\OneDrive\Desktop\IForm Collection add more concept\Iformcollection\Views\_ViewImports.cshtml"
using Iformcollection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\OneDrive\Desktop\IForm Collection add more concept\Iformcollection\Views\_ViewImports.cshtml"
using Iformcollection.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3df2deefa4b3be3d023593eda5448175462161a", @"/Views/IformcollectionCon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff6e9e6ea55355d9a14151c1d41b01234ae8a40", @"/Views/_ViewImports.cshtml")]
    public class Views_IformcollectionCon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("IformcollectionCon/add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Asus\OneDrive\Desktop\IForm Collection add more concept\Iformcollection\Views\IformcollectionCon\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<h1>Add more section</h1>
Enter the id:
<input type=""text"" id=""txtId1""  />
<br />
    Enter the Name:
<input type=""text"" id=""txtName1""  />
<br />
    Enter the City:
<input type=""text"" id=""txtCity1"" />
<br />

<button type=""button"" id=""btnAddMore"" onclick=""addMore();"" class=""btn btn-success""><i class=""icon-plus-solid pr-1""></i>Add More</button>


------------------------------------------

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3df2deefa4b3be3d023593eda5448175462161a4822", async() => {
                WriteLiteral(@"
    <table id=""tblAddMore"">
        <thead>
            <tr>
                <th>sl#</th>
                <th>Name</th>
                <th>City</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
    Enter the id: <input type=""text"" id=""txtId"" name=""SinglestudentId"" /><br />
    Enter the Name: <input type=""text"" id=""txtName"" name=""SinglestudentName"" /><br />
    Enter the City: <input type=""text"" id=""txtCity"" name=""SinglestudentCity"" /><br />

    <input type=""submit"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>

    function addMore() {
        debugger;
        var table = document.getElementById(""tblAddMore"").getElementsByTagName('tbody')[0];
        var rowCount = table.rows.length;
        var row = table.insertRow(rowCount);
        //Column 0
        var cell0 = row.insertCell(0);
        cell0.innerHTML = rowCount + 1;
        //Column 1
        var cell1 = row.insertCell(1);
        cell1.innerHTML = $(""#txtId1"").val();
        var ele1 = document.createElement(""input"");
        ele1.type = ""hidden"";
        ele1.name = ""id"";
        ele1.value = $(""#txtId1"").val();
        cell1.appendChild(ele1);
        //Column 2
        var cell2 = row.insertCell(2);
        cell2.innerHTML = $(""#txtName1"").val();
        var ele2 = document.createElement(""input"");
        ele2.type = ""hidden"";
        ele2.name = ""name"";
        ele2.value = $(""#txtName1"").val();
        cell2.appendChild(ele2);
        //Column 3
        var cell3 = row.insertCell(3);
        cell3.innerHTML = ");
            WriteLiteral("$(\"#txtCity1\").val();\r\n        var ele3 = document.createElement(\"input\");\r\n        ele3.type = \"hidden\";\r\n        ele3.name = \"city\";\r\n        ele3.value = $(\"#txtCity1\").val();\r\n        cell3.appendChild(ele3);       \r\n    }\r\n</script>");
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
