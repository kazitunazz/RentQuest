#pragma checksum "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f0168d6bf6a8e32c58ac098441e28ab391eb7f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Owner_Views_OwCirc_Index), @"mvc.1.0.view", @"/Areas/Owner/Views/OwCirc/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Owner/Views/OwCirc/Index.cshtml", typeof(AspNetCore.Areas_Owner_Views_OwCirc_Index))]
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
#line 1 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\_ViewImports.cshtml"
using RentQuest;

#line default
#line hidden
#line 1 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
using RentQuest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0168d6bf6a8e32c58ac098441e28ab391eb7f9", @"/Areas/Owner/Views/OwCirc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a83f207944a152b7f6a76b6073a689526cea233", @"/Areas/Owner/Views/_ViewImports.cshtml")]
    public class Areas_Owner_Views_OwCirc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Circulations>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Owner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Owner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReceivedReq", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OwCirc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Unregistered", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Unreg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link ml-lg-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_button2PartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 155, true);
            WriteLiteral("    <nav class=\"navbar navbar-expand-lg navbar-dark ftco_navbar bg-dark ftco-navbar-light\" id=\"ftco-navbar\">\r\n        <div class=\"container\">\r\n            ");
            EndContext();
            BeginContext(256, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0168d6bf6a8e32c58ac098441e28ab391eb7f98743", async() => {
                BeginContext(339, 22, true);
                WriteLiteral("Rent<span>Quest</span>");
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
            BeginContext(365, 422, true);
            WriteLiteral(@"
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#ftco-nav"" aria-controls=""ftco-nav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""oi oi-menu""></span> Menu
            </button>

            <div class=""collapse navbar-collapse"" id=""ftco-nav"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item"">");
            EndContext();
            BeginContext(787, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0168d6bf6a8e32c58ac098441e28ab391eb7f911063", async() => {
                BeginContext(866, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            BeginContext(874, 48, true);
            WriteLiteral("</li>\r\n                    <li class=\"nav-item\">");
            EndContext();
            BeginContext(922, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0168d6bf6a8e32c58ac098441e28ab391eb7f912969", async() => {
                BeginContext(1003, 8, true);
                WriteLiteral("Property");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1015, 48, true);
            WriteLiteral("</li>\r\n                    <li class=\"nav-item\">");
            EndContext();
            BeginContext(1063, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0168d6bf6a8e32c58ac098441e28ab391eb7f914883", async() => {
                BeginContext(1148, 17, true);
                WriteLiteral("Received Requests");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1169, 50, true);
            WriteLiteral("</li>\r\n\r\n                    <li class=\"nav-item\">");
            EndContext();
            BeginContext(1219, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0168d6bf6a8e32c58ac098441e28ab391eb7f916811", async() => {
                BeginContext(1299, 22, true);
                WriteLiteral("Manage your Properties");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
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
            BeginContext(1325, 48, true);
            WriteLiteral("</li>\r\n                    <li class=\"nav-item\">");
            EndContext();
            BeginContext(1373, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0168d6bf6a8e32c58ac098441e28ab391eb7f918740", async() => {
                BeginContext(1453, 16, false);
#line 20 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                                                                                                                   Write(ViewBag.sessionv);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            BeginContext(1473, 56, true);
            WriteLiteral("</li>\r\n\r\n\r\n                    <li class=\"nav-item cta\">");
            EndContext();
            BeginContext(1529, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0168d6bf6a8e32c58ac098441e28ab391eb7f920884", async() => {
                BeginContext(1623, 40, true);
                WriteLiteral("<span class=\"icon-user\"></span> Sign-out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1667, 251, true);
            WriteLiteral("</li>\r\n\r\n\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n<br />\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Circulation List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(1918, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0168d6bf6a8e32c58ac098441e28ab391eb7f923070", async() => {
                BeginContext(1962, 53, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; Add New Circulation");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2019, 53, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(2072, 693, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0168d6bf6a8e32c58ac098441e28ab391eb7f924642", async() => {
                BeginContext(2092, 666, true);
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-3"">
                <label>Rent Low Amount</label>
                <input type=""number"" class=""form-control"" name=""lowamount"" />
            </div>
            <div class=""col-3"">
                <label>Rent High Amount</label>
                <input type=""number"" class=""form-control"" name=""highamount"" />
            </div>
            <div class=""col-3"">
                <label>Custom Search</label>
                <input type=""submit"" class=""form-control"" value=""Search"" class=""btn btn-success"" />
            </div>
            <div class=""col-3"">

            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2765, 201, true);
            WriteLiteral("\r\n\r\n    <br />\r\n    <div>\r\n        <table class=\"table table-striped border\" id=\"new3\">\r\n            <thead>\r\n                <tr class=\"table-info\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2967, 32, false);
#line 68 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(Html.DisplayNameFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2999, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3079, 40, false);
#line 71 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(Html.DisplayNameFor(c => c.Monthly_Rent));

#line default
#line hidden
            EndContext();
            BeginContext(3119, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3199, 36, false);
#line 74 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(Html.DisplayNameFor(c => c.Location));

#line default
#line hidden
            EndContext();
            BeginContext(3235, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3315, 39, false);
#line 77 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(Html.DisplayNameFor(c => c.isAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(3354, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3434, 46, false);
#line 80 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(Html.DisplayNameFor(c => c.CircTypes.CircType));

#line default
#line hidden
            EndContext();
            BeginContext(3480, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3560, 36, false);
#line 83 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(Html.DisplayNameFor(c => c.Cdetails));

#line default
#line hidden
            EndContext();
            BeginContext(3596, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3676, 35, false);
#line 86 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(Html.DisplayNameFor(c => c.Flat_No));

#line default
#line hidden
            EndContext();
            BeginContext(3711, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3791, 36, false);
#line 89 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(Html.DisplayNameFor(c => c.House_No));

#line default
#line hidden
            EndContext();
            BeginContext(3827, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3907, 36, false);
#line 92 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(Html.DisplayNameFor(c => c.SizeSQFT));

#line default
#line hidden
            EndContext();
            BeginContext(3943, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(4023, 36, false);
#line 95 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(Html.DisplayNameFor(c => c.num_bath));

#line default
#line hidden
            EndContext();
            BeginContext(4059, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(4139, 35, false);
#line 98 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(Html.DisplayNameFor(c => c.num_bed));

#line default
#line hidden
            EndContext();
            BeginContext(4174, 159, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n");
            EndContext();
#line 106 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(4398, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(4445, 9, false);
#line 109 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4454, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4486, 17, false);
#line 110 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(item.Monthly_Rent);

#line default
#line hidden
            EndContext();
            BeginContext(4503, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4535, 13, false);
#line 111 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(item.Location);

#line default
#line hidden
            EndContext();
            BeginContext(4548, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4580, 16, false);
#line 112 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(item.isAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(4596, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4628, 23, false);
#line 113 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(item.CircTypes.CircType);

#line default
#line hidden
            EndContext();
            BeginContext(4651, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4683, 13, false);
#line 114 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(item.Cdetails);

#line default
#line hidden
            EndContext();
            BeginContext(4696, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4728, 12, false);
#line 115 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(item.Flat_No);

#line default
#line hidden
            EndContext();
            BeginContext(4740, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4772, 13, false);
#line 116 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(item.House_No);

#line default
#line hidden
            EndContext();
            BeginContext(4785, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4817, 13, false);
#line 117 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(item.SizeSQFT);

#line default
#line hidden
            EndContext();
            BeginContext(4830, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4862, 13, false);
#line 118 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(item.num_bath);

#line default
#line hidden
            EndContext();
            BeginContext(4875, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(4907, 12, false);
#line 119 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                   Write(item.num_bed);

#line default
#line hidden
            EndContext();
            BeginContext(4919, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4976, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f0168d6bf6a8e32c58ac098441e28ab391eb7f936548", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
#line 121 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5031, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 124 "G:\3.2\SDLab\RQ9\RentQuest\RentQuest\Areas\Owner\Views\OwCirc\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(5102, 70, true);
            WriteLiteral("            </tbody>\r\n\r\n\r\n        </table>\r\n    </div>\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5195, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(5297, 131, true);
                WriteLiteral("\r\n        <script type=\"text/javascript\">\r\n\r\n        $(document).ready( function () {\r\n    $(\'#new3\').DataTable();\r\n        });\r\n\r\n");
                EndContext();
                BeginContext(5603, 25, true);
                WriteLiteral("        </script>\r\n\r\n    ");
                EndContext();
            }
            );
            BeginContext(5631, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Circulations>> Html { get; private set; }
    }
}
#pragma warning restore 1591