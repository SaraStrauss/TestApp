#pragma checksum "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d9a88a3765bda609adebced7e5b8350c25b9680"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\temp\TestApp\TestApp\Views\_ViewImports.cshtml"
using TestApp;

#line default
#line hidden
#line 2 "C:\temp\TestApp\TestApp\Views\_ViewImports.cshtml"
using TestApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d9a88a3765bda609adebced7e5b8350c25b9680", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25db771d30abaf29d3599c25e6deb12289bab6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TestApp.Models.Queue>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
   

#line default
#line hidden
            BeginContext(85, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(122, 276, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d9a88a3765bda609adebced7e5b8350c25b96806367", async() => {
                BeginContext(128, 263, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""//netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css"">
");
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
            BeginContext(398, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(400, 5077, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d9a88a3765bda609adebced7e5b8350c25b96807825", async() => {
                BeginContext(406, 59, true);
                WriteLiteral("\r\n\r\n    <div class=\"box-body\">\r\n\r\n        <p>\r\n            ");
                EndContext();
                BeginContext(465, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d9a88a3765bda609adebced7e5b8350c25b96808274", async() => {
                    BeginContext(486, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(500, 24, true);
                WriteLiteral("\r\n        </p>\r\n        ");
                EndContext();
                BeginContext(524, 563, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d9a88a3765bda609adebced7e5b8350c25b96809762", async() => {
                    BeginContext(562, 144, true);
                    WriteLiteral("\r\n            <div class=\"form-actions no-color\">\r\n                <p>\r\n                    Find by name: <input type=\"text\" name=\"SearchString\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 706, "\"", 740, 1);
#line 27 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 714, ViewData["currentFilter"], 714, 26, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(741, 97, true);
                    WriteLiteral(" />\r\n                    \r\n                    Find by Date: <input type=\"date\" name=\"SearchDate\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 838, "\"", 873, 1);
#line 29 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 846, ViewData["currentFilter2"], 846, 27, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(874, 111, true);
                    WriteLiteral(" />\r\n                    <input type=\"submit\" value=\"Search\" class=\"btn btn-default\" /> |\r\n                    ");
                    EndContext();
                    BeginContext(985, 43, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d9a88a3765bda609adebced7e5b8350c25b968011373", async() => {
                        BeginContext(1007, 17, true);
                        WriteLiteral("Back to Full List");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1028, 52, true);
                    WriteLiteral("\r\n                </p>\r\n            </div>\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1087, 126, true);
                WriteLiteral("\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1213, 130, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d9a88a3765bda609adebced7e5b8350c25b968014675", async() => {
                    BeginContext(1284, 55, false);
#line 39 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                                                                                         Write(Html.DisplayNameFor(model => model[0].user.DisplayName));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 39 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                                                       WriteLiteral(ViewData["NameSortParm"]);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1343, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1423, 49, false);
#line 42 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].user.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1472, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1551, 123, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d9a88a3765bda609adebced7e5b8350c25b968017884", async() => {
                    BeginContext(1622, 48, false);
#line 45 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                                                                                         Write(Html.DisplayNameFor(model => model[0].QueueDate));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 45 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                                                       WriteLiteral(ViewData["DateSortParm"]);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1674, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1754, 49, false);
#line 48 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].InsertDate));

#line default
#line hidden
                EndContext();
                BeginContext(1803, 126, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
                EndContext();
#line 54 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(1994, 86, true);
                WriteLiteral("                    <tr>\r\n\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2081, 51, false);
#line 59 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.user.DisplayName));

#line default
#line hidden
                EndContext();
                BeginContext(2132, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2224, 45, false);
#line 62 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.user.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2269, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2361, 44, false);
#line 65 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.QueueDate));

#line default
#line hidden
                EndContext();
                BeginContext(2405, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2497, 45, false);
#line 68 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.InsertDate));

#line default
#line hidden
                EndContext();
                BeginContext(2542, 65, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n\r\n");
                EndContext();
#line 72 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                             if (item.IsMine)
                            {
                                

#line default
#line hidden
                BeginContext(2718, 44, false);
#line 74 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                           Write(Html.ActionLink("Details", "Details", @item));

#line default
#line hidden
                EndContext();
                BeginContext(2762, 11, true);
                WriteLiteral(" <b>|</b>\r\n");
                EndContext();
                BeginContext(2806, 38, false);
#line 75 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", @item));

#line default
#line hidden
                EndContext();
                BeginContext(2844, 11, true);
                WriteLiteral(" <b>|</b>\r\n");
                EndContext();
                BeginContext(2888, 42, false);
#line 76 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", @item));

#line default
#line hidden
                EndContext();
                BeginContext(2930, 10, true);
                WriteLiteral("<b>|</b>\r\n");
                EndContext();
                BeginContext(2975, 105, false);
#line 78 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                           Write(Html.ActionLink("Details", "Privacy", @item, new { @data_toggle = "modal", @data_target = "#openModal" }));

#line default
#line hidden
                EndContext();
#line 78 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                                                                                                                                          
                            }
                            

#line default
#line hidden
                BeginContext(3629, 60, true);
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 87 "C:\temp\TestApp\TestApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(3708, 337, true);
                WriteLiteral(@"            </tbody>
        </table>
    </div>


    <div id=""privacy"" class=""modal fade"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal modal-header"">
                    <h4 class=""modal-title"">Details</h4>
");
                EndContext();
                BeginContext(4111, 23, true);
                WriteLiteral("                </div> ");
                EndContext();
                BeginContext(4134, 1146, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d9a88a3765bda609adebced7e5b8350c25b968026140", async() => {
                    BeginContext(4166, 50, true);
                    WriteLiteral("\r\n                    <div class=\"modal-body\">\r\n\r\n");
                    EndContext();
                    BeginContext(4656, 157, true);
                    WriteLiteral("\r\n                    </div>\r\n                    <div class=\"modal-footer\">\r\n                        <div style=\"width:100px\">\r\n                            ");
                    EndContext();
                    BeginContext(4813, 94, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d9a88a3765bda609adebced7e5b8350c25b968026894", async() => {
                        BeginContext(4893, 5, true);
                        WriteLiteral("Close");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4907, 149, true);
                    WriteLiteral("\r\n                            <input name=\"__RequestVerificationToken\" type=\"hidden\" value=\"<removed for brevity>\">\r\n                        </div>\r\n");
                    EndContext();
                    BeginContext(5229, 44, true);
                    WriteLiteral("                    </div>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5280, 52, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
                BeginContext(5340, 123, true);
                WriteLiteral("        <script>\r\n            $(function () {\r\n                $(\"#privacy\").modal();\r\n            });\r\n        </script>\r\n");
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
            BeginContext(5477, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TestApp.Models.Queue>> Html { get; private set; }
    }
}
#pragma warning restore 1591
