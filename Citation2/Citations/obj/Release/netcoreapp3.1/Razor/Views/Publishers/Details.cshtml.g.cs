#pragma checksum "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a402631a067e0d75e7379983ebbfcd949be40e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publishers_Details), @"mvc.1.0.view", @"/Views/Publishers/Details.cshtml")]
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
#line 1 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\_ViewImports.cshtml"
using Citations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\_ViewImports.cshtml"
using Citations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a402631a067e0d75e7379983ebbfcd949be40e2", @"/Views/Publishers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae0511c74ede222dfd406769db377e71b1e86f89", @"/Views/_ViewImports.cshtml")]
    public class Views_Publishers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Citations.Models.Publisher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a402631a067e0d75e7379983ebbfcd949be40e24102", async() => {
                WriteLiteral(@"

    <style>


        body {
            background: #F1F3FA;
        }

        /* Profile container */
        .profile {
        }

        /* Profile sidebar */
        .profile-sidebar {
            background: #fff;
        }

        .profile-userpic img {
            float: none;
            margin: 5% 10% 10% 30%;
            width: 20%;
            height: 160px;
            -webkit-border-radius: 50% !important;
            -moz-border-radius: 50% !important;
            border-radius: 50% !important;
        }

        .profile-usertitle {
            text-align: center;
            margin-top: 20px;
        }

        .profile-usertitle-name {
            color: #5a7391;
            font-size: 16px;
            font-weight: 600;
            margin-bottom: 7px;
        }

        .profile-usertitle-job {
            text-transform: uppercase;
            color: #5b9bd1;
            font-size: 12px;
            font-weight: 600;
            margin-bott");
                WriteLiteral(@"om: 15px;
        }

        .profile-userbuttons {
            text-align: center;
            margin-top: 10px;
        }

            .profile-userbuttons .btn {
                text-transform: uppercase;
                font-size: 11px;
                font-weight: 600;
                padding: 6px 15px;
                margin-right: 5px;
            }

                .profile-userbuttons .btn:last-child {
                    margin-right: 0px;
                }

        .profile-usermenu {
            margin-top: 30px;
        }

            .profile-usermenu ul li {
                border-bottom: 1px solid #f0f4f7;
            }

                .profile-usermenu ul li:last-child {
                    border-bottom: none;
                }

                .profile-usermenu ul li a {
                    color: #93a3b5;
                    font-size: 14px;
                    font-weight: 400;
                }

                    .profile-usermenu ul li a i {
   ");
                WriteLiteral(@"                     margin-right: 8px;
                        font-size: 14px;
                    }

                    .profile-usermenu ul li a:hover {
                        background-color: #fafcfd;
                        color: #5b9bd1;
                    }

                .profile-usermenu ul li.active {
                    border-bottom: none;
                }

                    .profile-usermenu ul li.active a {
                        color: #5b9bd1;
                        background-color: #f6f9fb;
                        border-left: 2px solid #5b9bd1;
                        margin-left: -2px;
                    }

        /* Profile Content */
        .profile-content {
            padding: 20px;
            background: #fff;
            min-height: 460px;
        }
    </style>
");
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
            WriteLiteral(@"


    <div class=""container"">
        <div class=""row profile"">
            <div class=""col-md-10"">
                <div class=""profile-sidebar"">
                    <!-- SIDEBAR USERPIC -->
                  
                    <!-- END SIDEBAR USERPIC -->
                    <!-- SIDEBAR USER TITLE -->
                    <div class=""profile-usertitle"">
                        <div class=""profile-usertitle-name"">
               
                        </div>
              <dl class="" row"">
                            <dt class = ""col-sm-2"">
                                ");
#nullable restore
#line 136 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                          <dd class = \"col-sm-10\">\r\n                                ");
#nullable restore
#line 139 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class = \"col-sm-2\">\r\n                                ");
#nullable restore
#line 142 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                          <dd class = \"col-sm-10\">\r\n                                ");
#nullable restore
#line 145 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n\r\n");
#nullable restore
#line 148 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                             if (Model.TypeOfPublisherNavigation != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dt class = \"col-sm-2\">\r\n                                    ");
#nullable restore
#line 151 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.TypeOfPublisherNavigation.TypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                              <dd class = \"col-sm-10\">\r\n                                    ");
#nullable restore
#line 154 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.TypeOfPublisherNavigation.TypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n");
#nullable restore
#line 156 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                             if (Model.TypeOfPublisherNavigation == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dt class = \"col-sm-2\">\r\n                                    ");
#nullable restore
#line 160 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.TypeOfPublisherNavigation.TypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                              <dd class = \"col-sm-10\">\r\n                                    ");
#nullable restore
#line 163 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                               Write(Html.DisplayName("مؤسسة"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n");
#nullable restore
#line 165 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 166 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                             if (Model.Institution != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <dt class = \"col-sm-2\">\r\n                                    ");
#nullable restore
#line 169 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Institution.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dt>\r\n                              <dd class = \"col-sm-10\">\r\n                                    ");
#nullable restore
#line 172 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Institution.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </dd>\r\n");
#nullable restore
#line 174 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt class = \"col-sm-2\">\r\n                                ");
#nullable restore
#line 176 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                          <dd class = \"col-sm-10\">\r\n                                ");
#nullable restore
#line 179 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class = \"col-sm-2\">\r\n                                ");
#nullable restore
#line 182 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.CountryNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                          <dd class = \"col-sm-10\">\r\n                                ");
#nullable restore
#line 185 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                           Write(Html.DisplayFor(model => model.CountryNavigation.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                        </dl>\r\n                        <div class=\"profile-usertitle-job\">\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <!-- END SIDEBAR USER TITLE -->\r\n                    <!-- SIDEBAR BUTTONS -->\r\n                    <div class=\"profile-userbuttons\">\r\n");
            WriteLiteral(@"                    </div>
                    <!-- END SIDEBAR BUTTONS -->
                    <!-- SIDEBAR MENU -->
                    <div class=""profile-usermenu"">
                        <ul class=""nav"">
                            <li class=""active"">
                                <a href=""#"">
                                    <i class=""glyphicon glyphicon-home""></i>
                                    Overview
                                </a>
                            </li>
                            <li>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a402631a067e0d75e7379983ebbfcd949be40e216866", async() => {
                WriteLiteral("\r\n                                    <i class=\"glyphicon glyphicon-user\"></i>\r\n                                     Settings\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 209 "C:\Users\MostafaAli\Documents\Citations\Citations\Views\Publishers\Details.cshtml"
                                                       WriteLiteral(Model.Publisherid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n\r\n                        </ul>\r\n                    </div>\r\n                    <!-- END MENU -->\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n<div>\r\n   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a402631a067e0d75e7379983ebbfcd949be40e219459", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Citations.Models.Publisher> Html { get; private set; }
    }
}
#pragma warning restore 1591
