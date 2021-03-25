#pragma checksum "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d606f0e7aa52f24cf897c2224025489ccb609b62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Classification_Details), @"mvc.1.0.view", @"/Views/Classification/Details.cshtml")]
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
#line 1 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\_ViewImports.cshtml"
using bsddHackathon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\_ViewImports.cshtml"
using bsddHackathon.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\_ViewImports.cshtml"
using GraphQL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d606f0e7aa52f24cf897c2224025489ccb609b62", @"/Views/Classification/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8e2e872ee8de43f2d2dfaa1eb3991f1677b713", @"/Views/_ViewImports.cshtml")]
    public class Views_Classification_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GraphQLResponse<DomainType>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
   
    var domain = Model.Data.Domain;
    var classification = Model.Data.Domain.Classification;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 10 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                          Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6 class=\"card-subtitle text-muted mb-2\">");
#nullable restore
#line 11 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                                             Write(classification.NamespaceUri);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
    </div>
    <ul class=""list-group list-group-flush"">
        <li class=""list-group-item"">
            <div class=""d-flex w-100 justify-content-between"">
                <h5 class=""mb-1"">ClassificationType</h5>
            </div>
            <div class=""mb-1"">");
#nullable restore
#line 18 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.ClassificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">Uid</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 24 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.Uid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">Definition</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 30 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.Definition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">Status</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 36 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">ActivationDateUtc</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 42 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.ActivationDateUtc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">RevisionDateUtc</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 48 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.RevisionDateUtc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">VersionDateUtc</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 54 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.VersionDateUtc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">DeActivationDateUtc</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 60 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.DeActivationDateUtc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">VersionNumber</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 66 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.VersionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">RevisionNumber</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 72 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.RevisionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">ReplacedObjectCodes</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 78 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.ReplacedObjectCodes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">ReplacingObjectCodes</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 84 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.ReplacingObjectCodes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">DeprecationExplanation</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 90 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.DeprecationExplanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">CreatorLanguageCode</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 96 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.CreatorLanguageCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">VisualRepresentationUri</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 102 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.VisualRepresentationUri);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">CountriesOfUse</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 108 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.CountriesOfUse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">SubdivisionsOfUse</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 114 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.SubdivisionsOfUse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">CountryOfOrigin</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 120 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.CountryOfOrigin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">DocumentReference</h5>\r\n            </div>\r\n            <div class=\"mb-1\">");
#nullable restore
#line 126 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                         Write(classification.DocumentReference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">Synonyms (");
#nullable restore
#line 130 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                                       Write(classification.Synonyms?.Count ?? 0);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n            </div>\r\n            <div class=\"mb-1\">\r\n");
#nullable restore
#line 133 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                 if (null != classification.Synonyms)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                     foreach (var synonym in classification.Synonyms)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>");
#nullable restore
#line 137 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                        Write(synonym);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 138 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">RelatedIfcEntityNames (");
#nullable restore
#line 144 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                                                    Write(classification.RelatedIfcEntityNames?.Count ?? 0);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n            </div>\r\n            <div class=\"mb-1\">\r\n");
#nullable restore
#line 147 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                 if (null != classification.RelatedIfcEntityNames)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                     foreach (var name in classification.RelatedIfcEntityNames)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>");
#nullable restore
#line 151 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                        Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 152 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </li>
        <li class=""list-group-item"">
            <div class=""d-flex w-100 justify-content-between"">
                <h5 class=""mb-1"">ParentClassificationReference</h5>
            </div>
            <div class=""mb-1"">
");
#nullable restore
#line 161 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                 if (null != classification.ParentClassificationReference)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d606f0e7aa52f24cf897c2224025489ccb609b6218850", async() => {
#nullable restore
#line 163 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                                                                                                      Write(classification.ParentClassificationReference.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-namespaceUri", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 163 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                                   WriteLiteral(classification.ParentClassificationReference.NamespaceUri);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["namespaceUri"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-namespaceUri", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["namespaceUri"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 164 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">ChildClassificationReferences (");
#nullable restore
#line 169 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                                                            Write(classification.Childs?.Count ?? 0);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n            </div>\r\n            <div class=\"mb-1\">\r\n");
#nullable restore
#line 172 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                 if (null != classification.Childs)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                     foreach (var reference in classification.Childs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d606f0e7aa52f24cf897c2224025489ccb609b6222579", async() => {
#nullable restore
#line 176 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                                                                                                                      Write(reference.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-namespaceUri", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 176 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                                                                                      WriteLiteral(reference.NamespaceUri);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["namespaceUri"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-namespaceUri", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["namespaceUri"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 177 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 177 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">ClassificationProperties (");
#nullable restore
#line 183 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                                                       Write(classification.Properties?.Count ?? 0);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n            </div>\r\n            <div class=\"mb-1\">\r\n");
#nullable restore
#line 186 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                 if (null != classification.Properties)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 188 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                     foreach (var property in classification.Properties)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 190 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                                                                                                                                                                   
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </li>\r\n        <li class=\"list-group-item\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">ClassificationRelations (");
#nullable restore
#line 197 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                                                      Write(classification.Relations?.Count ?? 0);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n            </div>\r\n            <div class=\"mb-1\">\r\n");
#nullable restore
#line 200 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                 if (null != classification.Relations)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 202 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                     foreach (var relation in classification.Relations)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>");
#nullable restore
#line 204 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                        Write(relation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 205 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "C:\Users\tl\source\repos\bsddHackathon\bsddHackathon\Views\Classification\Details.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </li>\r\n    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GraphQLResponse<DomainType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
