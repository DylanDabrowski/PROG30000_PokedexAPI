#pragma checksum "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ede85dc12e901eb47c89e06966ca61f054ff138"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/_ViewImports.cshtml"
using API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
using API.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ede85dc12e901eb47c89e06966ca61f054ff138", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pokemon>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<html>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ede85dc12e901eb47c89e06966ca61f054ff1383495", async() => {
                WriteLiteral("\n        <title>List Of Users</title>\n    ");
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
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ede85dc12e901eb47c89e06966ca61f054ff1384489", async() => {
                WriteLiteral("\n        \n");
#nullable restore
#line 11 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
          
            int i = 1;
        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Type</th>
                    <th scope=""col"">Description</th>
                    <th scope=""col"">Height</th>
                    <th scope=""col"">Attack</th>
                    <th scope=""col"">Defense</th>
                    <th scope=""col"">Weight</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 29 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
                 foreach (var pokemon in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <th scope=\"row\">");
#nullable restore
#line 32 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n                        <td>");
#nullable restore
#line 33 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
                       Write(pokemon.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 34 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
                       Write(pokemon.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 35 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
                       Write(pokemon.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 36 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
                       Write(pokemon.Height);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 37 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
                       Write(pokemon.Attack);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 38 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
                       Write(pokemon.Defense);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 39 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
                       Write(pokemon.Weight);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 41 "/Users/macowner/Desktop/SemesterSevenFiles/DotnetClass/FinalProject/PROG30000_PokedexAPI/API/Views/Home/Index.cshtml"
                    i = i + 1;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\n        </table>\n");
                WriteLiteral("    ");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pokemon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
