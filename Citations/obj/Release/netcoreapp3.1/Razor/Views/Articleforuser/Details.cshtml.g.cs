#pragma checksum "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cab89247c2d92ffaf3cc3baea802b813f0b6296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articleforuser_Details), @"mvc.1.0.view", @"/Views/Articleforuser/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cab89247c2d92ffaf3cc3baea802b813f0b6296", @"/Views/Articleforuser/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f3a45128a0567054a27ce92f916fdb16fa5521", @"/Views/_ViewImports.cshtml")]
    public class Views_Articleforuser_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Citations.Models.Article>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadAttachment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary ml-2 mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "_MainLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mr-0 ml-0"" >
    <div class=""col-sm-12"">

        <div class=""row text-center mb-3 card-body m-2"" style="" background-color: #fff; background-clip: border-box; border: 0 solid rgba(0,0,0,.125); border-radius: .25rem;"">
            <div class=""col-sm-12 text-center"">
                <h4 style=""color:green;text-align:center"">عنوان المقال</h4>
            </div>
            <div class=""col-sm-12  p-2"" style=""color:green"">
                <h5>");
#nullable restore
#line 16 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
               Write(Model.Articletittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n\r\n        </div>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
         if (Model.ArticletittleEn != null && Model.ArticletittleEn != "")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row text-center mb-3 card-body m-2"" style="" background-color: #fff; background-clip: border-box; border: 0 solid rgba(0,0,0,.125); border-radius: .25rem;"">
                <div class=""col-sm-12 text-center"">
                    <h5 style=""color:green;text-align:center"">عنوان المقال باللغة الانجيليزية</h5>
                </div>
                <div class=""col-sm-12  p-2"" style=""color:green"">
                    <p>");
#nullable restore
#line 28 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                  Write(Model.ArticletittleEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
         if (Model.BriefQuote != null && Model.BriefQuote != "")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-primary\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapseExample\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n                النبذه المختصرة\r\n            </button>\r\n");
            WriteLiteral(@"            <div id=""collapseExample"" class=""collapse row mb-3 card-body m-2"" style="" background-color: #080882; background-clip: border-box; border: 0 solid rgba(0,0,0,.125); border-radius: .25rem;"">

                <div class=""col-sm-12  p-2"" style=""color:white"">
                    ");
#nullable restore
#line 43 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
               Write(Model.BriefQuote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 48 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
         if (Model.BriefQuoteEn != null && Model.BriefQuoteEn != "")
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-primary\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapseExample2\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n                النبذه المختصرة باللغة الانجيليزية\r\n            </button>\r\n");
            WriteLiteral(@"            <div id=""collapseExample2"" class=""collapse row mb-3 card-body m-2"" style="" background-color: #080882; background-clip: border-box; border: 0 solid rgba(0,0,0,.125); border-radius: .25rem;"">

                <div class=""col-sm-12  p-2"" style=""color:white"">
                    ");
#nullable restore
#line 61 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
               Write(Model.BriefQuoteEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 66 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mt-2 mr-1 ml-1\">\r\n");
#nullable restore
#line 68 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
             if (Model.ArticleAuthores.Count() != 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""table-responsive col-sm-7 ml-3"" style="" background-color:#048213;  background-clip: border-box; border: 0 solid rgba(0,0,0,.125); border-radius: .25rem;"">
                    <h5 style=""text-align:center; color:white"">المؤلفون</h5>
                    <table class=""table table-bordered table-striped mb-3"" style=""color:white"">

");
#nullable restore
#line 75 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                         foreach (var x in Model.ArticleAuthores)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"mycontainers\">\r\n                                <td style=\"text-align:center\">\r\n                                    ");
#nullable restore
#line 79 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                               Write(x.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"text-align:center\">\r\n                                    ");
#nullable restore
#line 82 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                                Write(Html.Raw(x.MainAuthor ? "المؤلف الرئيسي" : "شارك في التأليف"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 86 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n");
#nullable restore
#line 89 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-4 mr-1 p-2 text-center\" style=\" background-color: #fff; background-clip: border-box; border: 0 solid rgba(0,0,0,.125); border-radius: .25rem;\">\r\n");
#nullable restore
#line 91 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                 if (Model.ScannedArticlePdf != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cab89247c2d92ffaf3cc3baea802b813f0b629613114", async() => {
                WriteLiteral("<i class=\"fas fa-download fa-2x\"></i> تحميل المقال");
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
#line 94 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                                                         WriteLiteral(Model.Articleid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <br />\r\n                    <hr />\r\n");
#nullable restore
#line 97 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"row \">\r\n                    <div class=\"col-sm-6\">\r\n                        <h6>عدد الاستشهادات : ");
#nullable restore
#line 103 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                                         Write(Model.NumberOfCitations);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n\r\n                    <div class=\"col-sm-6\">\r\n                        <h6>عدد المراجع: ");
#nullable restore
#line 107 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                                    Write(Model.NumberOfReferences);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <br />\r\n");
#nullable restore
#line 129 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
         if (Model.ArticleIssue != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""table-responsive"" style="" background-color: #93ff97bd; background-clip: border-box; border: 0 solid rgba(0,0,0,.125); border-radius: .25rem;"">
                <table class=""table table-bordered table-striped mb-0"">
                    <tr>
                        <th style=""text-align:center"">المؤسسة</th>
                        <th style=""text-align:center"">المجله</th>
                        <th style=""text-align:center"">العدد</th>
                        <th style=""text-align:center"">اصدار العدد</th>
                        <th style=""text-align:center"">الصفحة</th>
                    </tr>
                    <tr class=""mycontainers2"" id=""mainrows2"">
                        <td style=""text-align:center"">

                            ");
#nullable restore
#line 143 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                       Write(Model.ArticleIssueNavigation.MagazineIssue.Magazine.Institution.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n                            ");
#nullable restore
#line 147 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                       Write(Model.ArticleIssueNavigation.MagazineIssue.Magazine.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n\r\n                        <td style=\"text-align:center\">\r\n                            ");
#nullable restore
#line 152 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                       Write(Model.ArticleIssueNavigation.MagazineIssue.Issuenumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n\r\n                        <td style=\"text-align:center\">\r\n                            ");
#nullable restore
#line 157 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                       Write(Model.ArticleIssueNavigation.IssuenumberOfIssue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align:center\">\r\n\r\n                            ");
#nullable restore
#line 161 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                       Write(Model.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </td>\r\n\r\n                    </tr>\r\n                </table>\r\n\r\n\r\n");
            WriteLiteral("            </div>\r\n");
            WriteLiteral("            <hr />\r\n");
#nullable restore
#line 175 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 181 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
         if (Model.ArticleReferenceArticles.Count() != 0)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""table-responsive mr-2 ml-2 col-sm-6 mb-5"" style="" background-color:#080766eb;  background-clip: border-box; border: 0 solid rgba(0,0,0,.125); border-radius: .25rem;"">
                <h5 style=""text-align:center; color:white"">المصادر</h5>
                <table class=""table "" style=""color:white;"">

");
#nullable restore
#line 188 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                     foreach (var item in Model.ArticleReferenceArticles)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n");
#nullable restore
#line 191 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                             if (item.Articleref != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 193 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                               Write(item.Articleref.Articletittle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 194 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                             if (item.Book != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 197 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                               Write(item.Book.Booktittle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 198 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 199 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                             if (item.Conference != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 201 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                               Write(item.Conference.Conferencetittle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 202 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tr>\r\n");
#nullable restore
#line 205 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </table>\r\n            </div>\r\n");
#nullable restore
#line 209 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n     \r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 221 "C:\Users\MostafaAli\Pictures\citationuser\citationdesign\Citation2\Citations\Views\Articleforuser\Details.cshtml"
              await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n         \r\n        ");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Citations.Models.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
