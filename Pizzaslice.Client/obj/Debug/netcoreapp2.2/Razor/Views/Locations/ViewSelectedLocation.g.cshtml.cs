#pragma checksum "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Locations\ViewSelectedLocation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1faac46a85fa8ec4a2bcaa7909b8e938f00dc440"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locations_ViewSelectedLocation), @"mvc.1.0.view", @"/Views/Locations/ViewSelectedLocation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Locations/ViewSelectedLocation.cshtml", typeof(AspNetCore.Views_Locations_ViewSelectedLocation))]
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
#line 1 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\_ViewImports.cshtml"
using Pizzaslice.Client;

#line default
#line hidden
#line 2 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\_ViewImports.cshtml"
using Pizzaslice.Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1faac46a85fa8ec4a2bcaa7909b8e938f00dc440", @"/Views/Locations/ViewSelectedLocation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d26e892c57ed89774bfed8d5f336e6bd31128c67", @"/Views/_ViewImports.cshtml")]
    public class Views_Locations_ViewSelectedLocation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pizzaslice.Domain.Models.Location>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pizzas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePizza", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 59, true);
            WriteLiteral("\r\n\r\n<h2>Welcome to Pizzaslice! You chose this store:</h2>\r\n");
            EndContext();
#line 5 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Locations\ViewSelectedLocation.cshtml"
  
    ViewBag.Title = "ViewSelectedLocation";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(201, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(206, 16, false);
#line 9 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Locations\ViewSelectedLocation.cshtml"
Write(Model.LocationId);

#line default
#line hidden
            EndContext();
            BeginContext(222, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(234, 18, false);
#line 10 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Locations\ViewSelectedLocation.cshtml"
Write(Model.LocationName);

#line default
#line hidden
            EndContext();
            BeginContext(252, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(264, 21, false);
#line 11 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Locations\ViewSelectedLocation.cshtml"
Write(Model.LocationAddress);

#line default
#line hidden
            EndContext();
            BeginContext(285, 11, true);
            WriteLiteral("</h2>\r\n<h2>");
            EndContext();
            BeginContext(297, 21, false);
#line 12 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Locations\ViewSelectedLocation.cshtml"
Write(Model.LocationZipCode);

#line default
#line hidden
            EndContext();
            BeginContext(318, 13, true);
            WriteLiteral("</h2>\r\n\r\n<h2>");
            EndContext();
            BeginContext(331, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1faac46a85fa8ec4a2bcaa7909b8e938f00dc4406346", async() => {
                BeginContext(422, 22, true);
                WriteLiteral("Now Lets Make a Pizza!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(448, 11, true);
            WriteLiteral("</h2>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pizzaslice.Domain.Models.Location> Html { get; private set; }
    }
}
#pragma warning restore 1591
