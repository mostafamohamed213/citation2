#pragma checksum "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37c509db3e77477d0c1fa3dd80f7439218db5027"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AuthorProfile_Details), @"mvc.1.0.view", @"/Views/AuthorProfile/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37c509db3e77477d0c1fa3dd80f7439218db5027", @"/Views/AuthorProfile/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f3a45128a0567054a27ce92f916fdb16fa5521", @"/Views/_ViewImports.cshtml")]
    public class Views_AuthorProfile_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Citations.Models.AuthorsPositionInstitution>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" float: none; margin: 5% 10% 10% 30%; width: 20%; height: 160px; -webkit-border-radius: 50% !important; -moz-border-radius: 50% !important; border-radius: 50% !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37c509db3e77477d0c1fa3dd80f7439218db50276032", async() => {
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

        .img {
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
            margin-bottom: 15px;
        }

        .profile-userbuttons {
            text-align: center;
            margin-top: 10px;
        }

            .profile-userbuttons .btn {
                text-transform: uppercase;
                font-size: 11px;
                font-weight");
                WriteLiteral(@": 600;
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
                        margin-right: 8px;
                        font-size: 14px;
                    }

                    .profile-usermenu ul li a:hover {
                        background-color: #fafcfd;
                        color: #5b9bd1;
                    }
");
                WriteLiteral(@"
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
            WriteLiteral("\r\n");
#nullable restore
#line 112 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
 foreach (var item in Model.FirstOrDefault().Author.ArticleAuthores)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> ");
#nullable restore
#line 114 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
   Write(item.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 115 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
   
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row profile"">
        <div class=""col-md-10"">
            <div class=""profile-sidebar"">
                <!-- SIDEBAR USERPIC -->
                <div class=""profile-userpic"">

                </div>
                <!-- END SIDEBAR USERPIC -->
                <!-- SIDEBAR USER TITLE -->
                <div class=""profile-usertitle"">

                    <dl class=""row"">

                        <dt class=""col-sm-2"">
                            ");
#nullable restore
#line 133 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                       Write(Html.DisplayName("الصورة"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "37c509db3e77477d0c1fa3dd80f7439218db502711409", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3508, "~/AutherImages/", 3508, 15, true);
#nullable restore
#line 137 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
AddHtmlAttributeValue("", 3523, Model.FirstOrDefault().Author.ScannedAuthorimage, 3523, 49, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 140 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Author.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n\r\n                            ");
#nullable restore
#line 144 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                       Write(Html.DisplayFor(model => model.FirstOrDefault().Author.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 147 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.FirstOrDefault().Author.AuthorBio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 150 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                       Write(Html.DisplayFor(model => model.FirstOrDefault().Author.AuthorBio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 154 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.FirstOrDefault().Author.PointerH));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 157 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                       Write(Html.DisplayFor(model => model.FirstOrDefault().Author.PointerH));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 160 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.FirstOrDefault().Author.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 163 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                       Write(Html.DisplayFor(model => model.FirstOrDefault().Author.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 167 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                       Write(Html.DisplayName("مجالات البحث"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </dt>
                        <dd class=""col-sm-10"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th> الاسم العربي</th>
                                        <th> الاسم الانجليزي</th>
                                    </tr>
                                </thead>
");
#nullable restore
#line 177 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                                 foreach (var item in Model.FirstOrDefault().Author.AuthorResearchFields)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>  ");
#nullable restore
#line 181 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                                         Write(Html.DisplayFor(model => item.Field.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>  ");
#nullable restore
#line 182 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                                         Write(Html.DisplayFor(model => item.Field.NameEn));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 184 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"



                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </table>\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 191 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                       Write(Html.DisplayName("المسمي الوظيفي"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </dt>
                        <dd class=""col-sm-10"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th> المؤسسة التعليمية</th>
                                        <th>الكلية</th>
                                        <th>القسم</th>
                                        <th> المسمى الوظيفي</th>
                                    </tr>

                                </thead>

");
#nullable restore
#line 205 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                                 foreach (var item in Model)
                                {
                                    string id = item.FacultyInstitutionDepartment.FacultyInstitution.Institution.Institutionid + "_" +
                                        item.FacultyInstitutionDepartment.FacultyInstitution.Faculty.Facultyid + "_" +
                                       item.FacultyInstitutionDepartment.Department.Departmentid + "_" +
                                       +item.PositionJob.PositionJobid;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr");
            BeginWriteAttribute("id", " id=\"", 7498, "\"", 7506, 1);
#nullable restore
#line 211 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
WriteAttributeValue("", 7503, id, 7503, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                                        <td>  ");
#nullable restore
#line 214 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                                         Write(Html.DisplayFor(model => item.FacultyInstitutionDepartment.FacultyInstitution.Institution.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>  ");
#nullable restore
#line 215 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                                         Write(Html.DisplayFor(model => item.FacultyInstitutionDepartment.FacultyInstitution.Faculty.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>  ");
#nullable restore
#line 216 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                                         Write(Html.DisplayFor(model => item.FacultyInstitutionDepartment.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>  ");
#nullable restore
#line 217 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                                         Write(Html.DisplayFor(model => item.PositionJob.PositionJob1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 219 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"



                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </table>\r\n                        </dd>\r\n\r\n                    </dl>\r\n\r\n                    <div class=\"profile-usertitle-job\">\r\n");
            WriteLiteral("                    </div>\r\n                </div>\r\n                <!-- END SIDEBAR USER TITLE -->\r\n                <!-- SIDEBAR BUTTONS -->\r\n                <div class=\"profile-userbuttons\">\r\n");
            WriteLiteral(@"                </div>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37c509db3e77477d0c1fa3dd80f7439218db502724152", async() => {
                WriteLiteral("\r\n                                <i class=\"glyphicon glyphicon-user\"></i>\r\n                                Settings\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 250 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\AuthorProfile\Details.cshtml"
                                                   WriteLiteral(Model.FirstOrDefault().Author.Authorid);

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
            WriteLiteral("\r\n                        </li>\r\n\r\n                    </ul>\r\n                </div>\r\n                <!-- END MENU -->\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37c509db3e77477d0c1fa3dd80f7439218db502726744", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<script>
    $(document).ready(function () {

        $.noConflict();



        $('.table').DataTable({
            //""scrollX"": true,
            columnDefs: [
                {
                    //className: ""dt-right"", ""targets"": ""_all"",
                    // className: 'dt-head-right', targets: ""_all"",

                }

            ],
            ""scrollY"": ""200px"",
            ""scrollCollapse"": true,
            ""fixedHeader"": true,
            ""bFilter"": false,
            ""bPaginate"": false,
            ""stateSave"": true,
            ""pagingType"": ""full_numbers"",
            ""bInfo"": false,
            ""oLanguage"": {
                ""sSearch"": ""بحث:""
            }
        });
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Citations.Models.AuthorsPositionInstitution>> Html { get; private set; }
    }
}
#pragma warning restore 1591
