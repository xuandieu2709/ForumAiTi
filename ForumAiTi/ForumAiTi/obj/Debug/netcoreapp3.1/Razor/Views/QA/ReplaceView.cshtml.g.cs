#pragma checksum "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "327dab2b2e01b82a4e10bb85d98b94092948448b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QA_ReplaceView), @"mvc.1.0.view", @"/Views/QA/ReplaceView.cshtml")]
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
#line 1 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\_ViewImports.cshtml"
using ForumAiTi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\_ViewImports.cshtml"
using ForumAiTi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"327dab2b2e01b82a4e10bb85d98b94092948448b", @"/Views/QA/ReplaceView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8686f0c93b9c6c3b09795ba00f50435e4f43845", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QA_ReplaceView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ForumAiTi.Models.HoiDap>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/qa.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/comment_qa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
  
    Layout = null;
    ForumAiTiContext _context = new ForumAiTiContext();
    NguoiDung getUSERbyTK(string tk)
    {
        return _context.NguoiDung.Where(x => x.TaiKhoan == tk).FirstOrDefault();
    }
    List<BinhLuan> getListBLByMa(int MaHD)
    {
        var list = _context.BinhLuan.Where(x => x.MaHoiDap == MaHD).ToList();
        return list;
    }
    string getAvatar(byte[] avataar)
    {
        if (avataar == null) return "/images/noneavatar.jpg";
        string imageBase64Data = Convert.ToBase64String(avataar);
        string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
        return imageDataURL;
    }
    NguoiDung getUSER(string taikhoan)
    {
        return _context.NguoiDung.Where(x => x.TaiKhoan == taikhoan).FirstOrDefault();
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"section_comment\">\r\n");
#nullable restore
#line 27 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
     if (getListBLByMa(ViewBag.HD.MaHoiDap).Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <section class=\"bg-text-forum\" id=\"section_comment\">\r\n            <div style=\"border-bottom: 3px solid #2a9d8f;\">\r\n                <h4");
            BeginWriteAttribute("class", " class=\"", 1091, "\"", 1099, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"padding: 2% 4%;\">Bình luận</h4>\r\n            </div>\r\n            <h4 class=\"text-center p-2\">Chưa có bình luận nào. Hãy trở thành người bình luận đầu tiên</h4>\r\n        </section>\r\n");
#nullable restore
#line 35 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <section class=\"bg-text-forum\" id=\"section_comment\">\r\n            <div style=\"border-bottom: 3px solid #2a9d8f;\">\r\n                <h4");
            BeginWriteAttribute("class", " class=\"", 1455, "\"", 1463, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"padding: 2% 4%;\">Bình luận</h4>\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
             foreach (var item in getListBLByMa((int)ViewBag.HD.MaHoiDap))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row comment\" id=\"loadcomment\">\r\n                    <div class=\"col-3 col-lg-2 col-md-2 comment-left\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1776, "\"", 1824, 1);
#nullable restore
#line 46 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
WriteAttributeValue("", 1782, getAvatar(getUSER(item.TaiKhoan).HinhAnh), 1782, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1825, "\"", 1831, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col-9 col-lg-10 col-md-10 comment-right\">\r\n                        <p>");
#nullable restore
#line 49 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
                      Write(item.NoiDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 50 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
                         if(item.File != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img class=\"img img-fluid rounded\"");
            BeginWriteAttribute("src", " src=\"", 2117, "\"", 2144, 1);
#nullable restore
#line 52 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
WriteAttributeValue("", 2123, getAvatar(item.File), 2123, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2145, "\"", 2151, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 53 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 56 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"m-2 p-2\">\r\n                <button class=\"d-block m-auto\" id=\"load-more\"><i class=\"fa fa-spinner\" aria-hidden=\"true\"></i></button>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 61 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "327dab2b2e01b82a4e10bb85d98b94092948448b10545", async() => {
                WriteLiteral("\r\n                <section class=\"bg-text-forum m-0 p-2 mb-2\">\r\n                    <div class=\"anwser row m-0 p-2\">\r\n                        <div class=\"col-4 col-lg-2 col-md-2 anwser-left\">\r\n");
#nullable restore
#line 66 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
                             if(!User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <img");
                BeginWriteAttribute("src", " src=\"", 2852, "\"", 2874, 1);
#nullable restore
#line 68 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
WriteAttributeValue("", 2858, getAvatar(null), 2858, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2875, "\"", 2881, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 69 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <img");
                BeginWriteAttribute("class", " class=\"", 3019, "\"", 3027, 0);
                EndWriteAttribute();
                BeginWriteAttribute("src", " src=\"", 3028, "\"", 3106, 1);
#nullable restore
#line 73 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
WriteAttributeValue("", 3034, getAvatar(getUSERbyTK(User.FindFirst("TaiKhoan").Value.Trim()).HinhAnh), 3034, 72, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3107, "\"", 3113, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 74 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplaceView.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <div class=""col-8 col-lg-10 col-md-10 anwser-right"">
                            <input type=""file"" hidden name=""file"" id=""upload"">
                            <label for=""upload""><i class=""fa fa-image"" aria-hidden=""true""></i></label>
                            <input type=""file"" hidden");
                BeginWriteAttribute("name", " name=\"", 3495, "\"", 3502, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""upload1"">
                            <label for=""upload1""><i class=""fa fa-file-archive"" aria-hidden=""true""></i></label>
                            <textarea name=""comment"" id=""comment""></textarea>
                            <div class=""garellyImages""></div>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "327dab2b2e01b82a4e10bb85d98b94092948448b14020", async() => {
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
                WriteLiteral("\r\n                            <button id=\"btnComment\" class=\"btn btn-send\">Bình luận</button>\r\n                        </div>\r\n                    </div>\r\n                </section>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForumAiTi.Models.HoiDap> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
