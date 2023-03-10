#pragma checksum "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "792134d9c5caac6d6674e0583a42b472221b3d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QA_ReplacewithDM), @"mvc.1.0.view", @"/Views/QA/ReplacewithDM.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792134d9c5caac6d6674e0583a42b472221b3d26", @"/Views/QA/ReplacewithDM.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8686f0c93b9c6c3b09795ba00f50435e4f43845", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QA_ReplacewithDM : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ForumAiTi.Models.HoiDap>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "qa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "QA", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
  
    ForumAiTiContext _context = new ForumAiTiContext();
    List<DanhMucHoiDap> getListHD()
    {
        return _context.DanhMucHoiDap.ToList();
    }
    string getAvatar(byte[] avataar)
    {
        if (avataar == null) return "/images/noneavatar.jpg";
        string imageBase64Data = Convert.ToBase64String(avataar);
        string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
        return imageDataURL;
    }
    List<CthoiDap> getlistDMByMA(int ma)
    {
        return _context.CthoiDap.Where(x => x.MaHoiDap == ma).ToList();
    }
    DanhMucHoiDap getDMbyMA(int ma)
    {
        return _context.DanhMucHoiDap.Where(x => x.MaDanhMuc == ma).FirstOrDefault();
    }
    NguoiDung getUSER(string taikhoan)
    {
        if (taikhoan == null)
        {
            return new NguoiDung();
        }
        return _context.NguoiDung.Where(x => x.TaiKhoan == taikhoan).FirstOrDefault();
    }
    int CountComment(int MaHoiDap)
    {
        var list = _context.BinhLuan.Where(x => x.MaHoiDap == MaHoiDap).ToList();
        int count = 0;
        count = list.Count();
        return count;
    }
    string getName(string taikhoan){
        string tk = "";
        if(taikhoan == null)
        {
            taikhoan = User.FindFirst("TaiKhoan").Value.Trim();
        }
        var user = _context.NguoiDung.FirstOrDefault(x => x.TaiKhoan == taikhoan);
        if(user.Nickname != null)
        {
            tk = user.Nickname;
        }else if(user.HoTen != null)
        {
            tk = user.HoTen;
        }else if(user.TaiKhoan != null)
        {
            tk = user.TaiKhoan;
        }
        return tk;
    } 
    Pager paper = new Pager();
    int pageNo = 0;
    if (ViewBag.Pager != null)
    {
        paper = ViewBag.Pager;
        pageNo = paper.CurrentPage;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"QA my-2\" id=\"demoqa\">\r\n");
#nullable restore
#line 66 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
     if(Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row bg-forum p-5\">\r\n        <h2 class=\"text-center\">Kh??ng c?? b??i ????ng n??o ph?? h???p.</h2>\r\n        </div>\r\n");
#nullable restore
#line 71 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
    }
    else{
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
         foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"question row\">\r\n            <div class=\"question-body col-12\">\r\n                <p hidden id=\"MaHD\">");
#nullable restore
#line 77 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                               Write(item.MaHoiDap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2354, "\"", 2387, 2);
            WriteAttributeValue("", 2361, "/details_qa/", 2361, 12, true);
#nullable restore
#line 78 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
WriteAttributeValue("", 2373, item.MaHoiDap, 2373, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h4 class=\"question-title\">");
#nullable restore
#line 79 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                                          Write(item.TieuDe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </a>\r\n                <p class=\"time-posted\">???? ????ng ng??y ");
#nullable restore
#line 81 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                                               Write(String.Format("{0:dd/MM/yyyy}", item.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - <a");
            BeginWriteAttribute("href", "\r\n                        href=\"", 2583, "\"", 2640, 2);
            WriteAttributeValue("", 2615, "/personal/", 2615, 10, true);
#nullable restore
#line 82 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
WriteAttributeValue("", 2625, item.NguoiDang, 2625, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img id=\"question-imguser\"");
            BeginWriteAttribute("src", "\r\n                            src=\"", 2668, "\"", 2746, 1);
#nullable restore
#line 83 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
WriteAttributeValue("", 2703, getAvatar(getUSER(item.NguoiDang).HinhAnh), 2703, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2747, "\"", 2753, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 83 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                                                                                 Write(getName(item.NguoiDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                <p class=\"question-list\">\r\n");
#nullable restore
#line 85 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                     foreach (var item1 in @getlistDMByMA(item.MaHoiDap))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\">");
#nullable restore
#line 87 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                               Write(getDMbyMA((int)item1.MaDanhMuc).TenDanhMuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 88 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n                <p class=\"question-content\">");
#nullable restore
#line 90 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                                       Write(item.NoiDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    <pi class=\"question-watch\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 93 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                                                                                       Write(item.LuotXem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" L?????t\r\n                        xem\r\n                    </pi>\r\n                    <pi class=\"question-comment\"><i class=\"fa fa-comment\" aria-hidden=\"true\"></i>\r\n                        ");
#nullable restore
#line 97 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                   Write(CountComment(item.MaHoiDap));

#line default
#line hidden
#nullable disable
            WriteLiteral(" B??nh\r\n                        lu???n\r\n                    </pi>\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 103 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
     if (paper.TotalPages > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <nav aria-label=\"Page navigation example\">\r\n            <ul class=\"pagination\" id=\"clickTaga\">\r\n");
#nullable restore
#line 108 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                 if (paper.CurrentPage > 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "792134d9c5caac6d6674e0583a42b472221b3d2613547", async() => {
                WriteLiteral("Tr?????c");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                         WriteLiteral(paper.CurrentPage -1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 112 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\"><a class=\"page-link disabeled\">Tr?????c</a></li>\r\n");
#nullable restore
#line 116 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                 for (var pagee = paper.StartPage; pagee <= paper.EndPage; pagee++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 4290, "\"", 4353, 2);
            WriteAttributeValue("", 4298, "page-item", 4298, 9, true);
#nullable restore
#line 119 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
WriteAttributeValue(" ", 4307, pagee == paper.CurrentPage ? "active" : "", 4308, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "792134d9c5caac6d6674e0583a42b472221b3d2617486", async() => {
                WriteLiteral(" ");
#nullable restore
#line 120 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                                                                                                     Write(pagee);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                                                                                     WriteLiteral(pagee);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 122 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                 if (paper.CurrentPage < paper.EndPage)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "792134d9c5caac6d6674e0583a42b472221b3d2620922", async() => {
                WriteLiteral("Sau");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                         WriteLiteral(paper.CurrentPage +1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 127 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\"><a class=\"page-link disabeled\">Sau</a></li>\r\n");
#nullable restore
#line 131 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </nav>\r\n");
#nullable restore
#line 134 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\ReplacewithDM.cshtml"
     
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ForumAiTi.Models.HoiDap>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
