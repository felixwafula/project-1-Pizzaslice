#pragma checksum "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf3f9ba05a8c2294209d4922dc0116776f69ea2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_CreateUser), @"mvc.1.0.view", @"/Views/Users/CreateUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/CreateUser.cshtml", typeof(AspNetCore.Views_Users_CreateUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf3f9ba05a8c2294209d4922dc0116776f69ea2", @"/Views/Users/CreateUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d26e892c57ed89774bfed8d5f336e6bd31128c67", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_CreateUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pizzaslice.Domain.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
  
    ViewBag.Title = "CreateUser";    

#line default
#line hidden
            BeginContext(87, 21, true);
            WriteLiteral("\r\n<h2>Register</h2>\r\n");
            EndContext();
#line 8 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
 using (Html.BeginForm()) {
    

#line default
#line hidden
            BeginContext(142, 28, false);
#line 9 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(174, 95, true);
            WriteLiteral("    <fieldset>\r\n        <legend>User</legend>\r\n        <div class=\"editor-label\">\r\n            ");
            EndContext();
            BeginContext(270, 39, false);
#line 14 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(309, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
            EndContext();
            BeginContext(376, 40, false);
#line 17 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(416, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(431, 51, false);
#line 18 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(482, 68, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");
            EndContext();
            BeginContext(551, 38, false);
#line 22 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(589, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
            EndContext();
            BeginContext(656, 39, false);
#line 25 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(695, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(710, 50, false);
#line 26 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(760, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
            EndContext();
            BeginContext(827, 39, false);
#line 29 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.LabelFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(866, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
            EndContext();
            BeginContext(933, 40, false);
#line 32 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(973, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(988, 51, false);
#line 33 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
            EndContext();
            BeginContext(1106, 38, false);
#line 36 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.LabelFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
            EndContext();
            BeginContext(1211, 39, false);
#line 39 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1265, 50, false);
#line 40 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
            EndContext();
            BeginContext(1382, 42, false);
#line 43 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.LabelFor(model => model.UserPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1424, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
            EndContext();
            BeginContext(1491, 43, false);
#line 46 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.UserPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1549, 54, false);
#line 47 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");
            EndContext();
            BeginContext(1670, 41, false);
#line 50 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.LabelFor(model => model.UserZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1711, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");
            EndContext();
            BeginContext(1778, 42, false);
#line 53 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.UserZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1820, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1835, 53, false);
#line 54 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1888, 119, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <p>\r\n            <input type=\"submit\" value=\"CreateUser\"/>\r\n        </p>\r\n    </fieldset>\r\n");
            EndContext();
            BeginContext(2009, 23, true);
            WriteLiteral("    <div>\r\n        <h5>");
            EndContext();
            BeginContext(2032, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf3f9ba05a8c2294209d4922dc0116776f69ea212790", async() => {
                BeginContext(2116, 5, true);
                WriteLiteral("Login");
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
            BeginContext(2125, 19, true);
            WriteLiteral("</h5>\r\n    </div>\r\n");
            EndContext();
#line 65 "C:\revature\PizzaSliceApp\Pizzaslice.Client\Views\Users\CreateUser.cshtml"
}

#line default
#line hidden
            BeginContext(2147, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pizzaslice.Domain.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
