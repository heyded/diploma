#pragma checksum "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "205094747901c0041acd3e288507c7111e7b1a87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Categories), @"mvc.1.0.view", @"/Views/Category/Categories.cshtml")]
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
#line 1 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\_ViewImports.cshtml"
using Shop.BusinessLogic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\_ViewImports.cshtml"
using Shop.Presentation.Web.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"205094747901c0041acd3e288507c7111e7b1a87", @"/Views/Category/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a9547b6a675d8708601b38751d6aa14c299e9e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("/Category/Get"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail default-img-size"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height: 18rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Shop.Presentation.Web.ShopTagHelpers.IsDisplayedTagHelper __Shop_Presentation_Web_ShopTagHelpers_IsDisplayedTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"header\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "205094747901c0041acd3e288507c7111e7b1a875072", async() => {
                WriteLiteral("➕");
            }
            );
            __Shop_Presentation_Web_ShopTagHelpers_IsDisplayedTagHelper = CreateTagHelper<global::Shop.Presentation.Web.ShopTagHelpers.IsDisplayedTagHelper>();
            __tagHelperExecutionContext.Add(__Shop_Presentation_Web_ShopTagHelpers_IsDisplayedTagHelper);
#nullable restore
#line 4 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
__Shop_Presentation_Web_ShopTagHelpers_IsDisplayedTagHelper.IsDisplayed = User.IsInRole(Role.Admin.ToString());

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("is-displayed", __Shop_Presentation_Web_ShopTagHelpers_IsDisplayedTagHelper.IsDisplayed, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    <h1>Каталог 📃</h1>\n\n</div>\n<div class=\"grid-items\">\n");
#nullable restore
#line 10 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
      
        foreach (var category in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card border-secondary col-sm-3 mr-1 ml-2 mb-1\" style=\"max-width: 23rem;\">\n                <a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 403, "\"", 453, 2);
            WriteAttributeValue("", 410, "/Product/GetAll?CategoryName=", 410, 29, true);
#nullable restore
#line 14 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
WriteAttributeValue("", 439, category.Name, 439, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "205094747901c0041acd3e288507c7111e7b1a877708", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
                  WriteLiteral(category.ImagePath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
AddHtmlAttributeValue("", 628, category.Name, 628, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#nullable restore
#line 18 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </a>\n\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 22 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
                                      Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n                    <div class=\"edge-pressed\">\n                        <div>\n                            <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 955, "\"", 1005, 2);
            WriteAttributeValue("", 962, "/Product/GetAll?CategoryName=", 962, 29, true);
#nullable restore
#line 26 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
WriteAttributeValue("", 991, category.Name, 991, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Открыть</a>\n                        </div>\n\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "205094747901c0041acd3e288507c7111e7b1a8711515", async() => {
                WriteLiteral("\n                            <a class=\"btn btn-warning\"");
                BeginWriteAttribute("href", " href=\"", 1188, "\"", 1236, 2);
                WriteAttributeValue("", 1195, "/Category/Get?CategoryName=", 1195, 27, true);
#nullable restore
#line 30 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
WriteAttributeValue("", 1222, category.Name, 1222, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">📝</a>\n                            <a class=\"btn btn-danger\"");
                BeginWriteAttribute("href", " href=\"", 1298, "\"", 1345, 2);
                WriteAttributeValue("", 1305, "/Category/Delete?CategoryId=", 1305, 28, true);
#nullable restore
#line 31 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
WriteAttributeValue("", 1333, category.Id, 1333, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">🧺</a>\n                        ");
            }
            );
            __Shop_Presentation_Web_ShopTagHelpers_IsDisplayedTagHelper = CreateTagHelper<global::Shop.Presentation.Web.ShopTagHelpers.IsDisplayedTagHelper>();
            __tagHelperExecutionContext.Add(__Shop_Presentation_Web_ShopTagHelpers_IsDisplayedTagHelper);
#nullable restore
#line 29 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
__Shop_Presentation_Web_ShopTagHelpers_IsDisplayedTagHelper.IsDisplayed = User.IsInRole(Role.Admin.ToString());

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("is-displayed", __Shop_Presentation_Web_ShopTagHelpers_IsDisplayedTagHelper.IsDisplayed, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 36 "C:\Users\ab231\OneDrive\Рабочий стол\диплом\Shop\Shop.Presentation.Web\Views\Category\Categories.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n \n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ShopUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ShopUser> SignInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
