#pragma checksum "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c401e9c1f88c924a0ffe5c2f9d32721f8f515fa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Institutionsforuser_Details), @"mvc.1.0.view", @"/Views/Institutionsforuser/Details.cshtml")]
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
#line 1 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\_ViewImports.cshtml"
using Citations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\_ViewImports.cshtml"
using Citations.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\_ViewImports.cshtml"
using Citations.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c401e9c1f88c924a0ffe5c2f9d32721f8f515fa0", @"/Views/Institutionsforuser/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f3a45128a0567054a27ce92f916fdb16fa5521", @"/Views/_ViewImports.cshtml")]
    public class Views_Institutionsforuser_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Citations.Models.Institution>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cover.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MagazineForUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_MainLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://cdn.anychart.com/releases/8.0.0/js/anychart-base.min.js""></script>


<style>
    #container {
        width: 100%;
        height: 100%;
        margin: 0;
        padding: 0;
    }
    .anychart-credits {
        display: none;
    }

    body {
        margin-top: auto;
        background-color: #f1f1f1;
    }

    .border {
        border-bottom: 1px solid #F1F1F1;
        margin-bottom: 10px;
    }

    .main-secction {
        box-shadow: 10px 10px 10px;
    }

    .image-section {
        padding: 0px;
    }

        .image-section img {
            width: 100%;
            height: 250px;
            position: relative;
        }

    .user-image {
        position: absolute;
        margin-top: -50px;
    }

    .user-left-part {
        margin: 0px;
    }

    .user-image img {
        width: 100px;
        height: 100px;
    }

    .user-profil-part {
        padding-bottom: 30px;
        background-color: #FAFAFA;
    }

 ");
            WriteLiteral(@"   .follow {
        margin-top: 70px;
    }

    .user-detail-row {
        margin: 0px;
    }

    .user-detail-section2 p {
        font-size: 12px;
        padding: 0px;
        margin: 0px;
    }

    .user-detail-section2 {
        margin-top: 10px;
    }

        .user-detail-section2 span {
            color: #7CBBC3;
            font-size: 20px;
        }

        .user-detail-section2 small {
            font-size: 12px;
            color: #D3A86A;
        }

    .profile-right-section {
        padding: 20px 0px 10px 15px;
        background-color: #FFFFFF;
    }

    .profile-right-section-row {
        margin: 0px;
    }

    .profile-header-section1 h1 {
        font-size: 25px;
        margin: 0px;
    }

    .profile-header-section1 h5 {
        color: #0062cc;
    }

    .req-btn {
        height: 30px;
        font-size: 12px;
    }

    .profile-tag {
        padding: 10px;
        border: 1px solid #F6F6F6;
    }

        .profile-tag");
            WriteLiteral(@" p {
            font-size: 12px;
            color: black;
        }

        .profile-tag i {
            color: #ADADAD;
            font-size: 20px;
        }

    .image-right-part {
        background-color: #FCFCFC;
        margin: 0px;
        padding: 5px;
    }

    .img-main-rightPart {
        background-color: #FCFCFC;
        margin-top: auto;
    }

    .image-right-detail {
        padding: 0px;
    }

        .image-right-detail p {
            font-size: 12px;
        }

        .image-right-detail a:hover {
            text-decoration: none;
        }

    .image-right img {
        width: 100%;
    }

    .image-right-detail-section2 {
        margin: 0px;
    }

        .image-right-detail-section2 p {
            color: #38ACDF;
            margin: 0px;
        }

        .image-right-detail-section2 span {
            color: #7F7F7F;
        }
</style>

<div class=""container main-secction mt-2"">
    <div class=""row"" style=""background-c");
            WriteLiteral("olor:white\">\r\n        <div class=\"col-md-12 col-sm-12 col-xs-12 image-section\">\r\n");
#nullable restore
#line 173 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
             if (Model.ScannedCoverImage == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c401e9c1f88c924a0ffe5c2f9d32721f8f515fa08990", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 176 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c401e9c1f88c924a0ffe5c2f9d32721f8f515fa010315", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3450, "~/images/", 3450, 9, true);
#nullable restore
#line 179 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
AddHtmlAttributeValue("", 3459, Model.ScannedCoverImage, 3459, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 180 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""row col-sm-12 user-left-part"">
            <div class=""col-md-2 col-sm-2 col-xs-12 user-profil-part pull-left"">
                <div class=""row "">
                    <div class=""col-md-12 col-md-12-sm-12 col-xs-12 user-image text-center"">
");
#nullable restore
#line 186 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                         if (Model.ScannedLogoImage == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c401e9c1f88c924a0ffe5c2f9d32721f8f515fa012730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 189 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c401e9c1f88c924a0ffe5c2f9d32721f8f515fa014104", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4056, "~/images/", 4056, 9, true);
#nullable restore
#line 192 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
AddHtmlAttributeValue("", 4065, Model.ScannedLogoImage, 4065, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 193 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"col-md-12 col-sm-12 col-xs-12 user-detail-section1 text-center\">\r\n                        <h1 class=\"btn btn-success btn-block follow\">");
#nullable restore
#line 196 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

                    </div>
                    <div class=""row user-detail-row"">
                        <div class=""col-md-12 col-sm-12 user-detail-section2 pull-left"">
                            <div class=""border""></div>
                            <h5>عدد المؤلفين</h5>
                            <h5>");
#nullable restore
#line 203 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                           Write(ViewBag.numberofauthor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <h6 class=\"bg-warning p-2\">");
#nullable restore
#line 204 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                                  Write(Model.TypeOfInstitutionNavigation.TypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                        </div>
                    </div>

                </div>
            </div>
            <div class=""col-md-5 col-sm-5 col-xs-12 pull-right profile-right-section"">
                <div class=""row profile-right-section-row"">

                    <div class=""col-md-12"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <ul class=""nav nav-tabs"" role=""tablist"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" href=""#profile"" role=""tab"" data-toggle=""tab""><i class=""fas fa-info-circle"" style=""color:blue;""></i> معلومات عن المؤسسه</a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""#buzz"" role=""tab"" data-toggle=""tab"">  <i class=""fas fa-book"" style=""color:greenyellow;""></i> المجلات</a>
                     ");
            WriteLiteral(@"               </li>
                                </ul>

                                <!-- Tab panes -->
                                <div class=""tab-content"">
                                    <div role=""tabpanel"" class=""tab-pane fade show active"" id=""profile"">
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <p>البلد</p>
                                            </div>
                                            <div class=""col-md-6"">
                                                <p>");
#nullable restore
#line 233 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                              Write(Model.CountryNavigation.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                        <hr />
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <p>المؤشر H</p>
                                            </div>
                                            <div class=""col-md-6"">
                                                <p> ");
#nullable restore
#line 242 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                               Write(ViewBag.PointerH);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                            </div>
                                        </div>
                                        <hr />
                                        
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <p>معامل التأثير العربي</p>
                                            </div>
                                            <div class=""col-md-6"">

                                                <p>");
#nullable restore
#line 253 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                              Write(ViewBag.ImpactFactor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                        <hr />
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <p>متوسط معامل التأثير العربي </p>
                                            </div>
                                            <div class=""col-md-6"">

                                                <p>");
#nullable restore
#line 263 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                              Write(ViewBag.impactfactorrange);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                        <hr />
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label>عدد الاستشهادات</label>
                                            </div>
                                            <div class=""col-md-6"">
                                                <p>   ");
#nullable restore
#line 272 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                                 Write(ViewBag.numberofcitations);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                        <hr />
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <label>عدد المقالات</label>
                                            </div>
                                            <div class=""col-md-6"">
                                                <p>");
#nullable restore
#line 281 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                              Write(ViewBag.numberofarticles);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                                            </div>
                                        </div>


                                    </div>
                                    <div role=""tabpanel"" class=""tab-pane fade text-right"" id=""buzz"">
                                        <div class=""row"">
                                            <div class=""col-md-6"">
                                                <p>عدد المجلات</p>
                                            </div>
                                            <div class=""col-md-6"">
                                                <p>");
#nullable restore
#line 293 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                              Write(Model.Magazines.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n                                        <hr />\r\n");
#nullable restore
#line 297 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                         foreach (var item in Model.Magazines)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"row\">\r\n                                                <div class=\"col-sm-12\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c401e9c1f88c924a0ffe5c2f9d32721f8f515fa025430", async() => {
                WriteLiteral(" <h5> ");
#nullable restore
#line 301 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                                                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 301 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                                                                                               WriteLiteral(item.Magazineid);

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
            WriteLiteral("\r\n                                                </div>\r\n\r\n                                            </div>\r\n");
#nullable restore
#line 305 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>

                                </div>

                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-5 col-sm-5 mt-3  col-xs-12 pull-right profile-right-section"">
                <div id=""container"" ></div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 354 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script>\r\n        anychart.onDocumentReady(function () {\r\n\r\n            // set the data\r\n            var data = {\r\n                header: [\"Name\", \"عدد الاستشهادات\"],\r\n                rows: [\r\n                    [");
#nullable restore
#line 363 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                Write(ViewBag.ciname1);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 363 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                 Write(ViewBag.ci1);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n                    [");
#nullable restore
#line 364 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                Write(ViewBag.ciname2);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 364 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                 Write(ViewBag.ci2);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n                    [");
#nullable restore
#line 365 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                Write(ViewBag.ciname3);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 365 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                 Write(ViewBag.ci3);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n                    [");
#nullable restore
#line 366 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                Write(ViewBag.ciname4);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 366 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                 Write(ViewBag.ci4);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\r\n                    [");
#nullable restore
#line 367 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                Write(ViewBag.ciname5);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 367 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Institutionsforuser\Details.cshtml"
                                 Write(ViewBag.ci5);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"]
              
                ]
            };

            // create the chart
            var chart = anychart.column();

            // add data
            chart.data(data);

            // set the chart title
            chart.title(""عدد الاستشهادات اخر خمس سنوات"");

            // draw
            chart.container(""container"");
            chart.draw();


        });

    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Citations.Models.Institution> Html { get; private set; }
    }
}
#pragma warning restore 1591