#pragma checksum "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c34b6e1c8da52aea8e86e0ae51db58f391580bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_News_add_edit_news_admin), @"mvc.1.0.view", @"/Views/Admin_News/add_edit_news_admin.cshtml")]
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
#line 1 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml"
using ForumAiTi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c34b6e1c8da52aea8e86e0ae51db58f391580bb", @"/Views/Admin_News/add_edit_news_admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8686f0c93b9c6c3b09795ba00f50435e4f43845", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_News_add_edit_news_admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/add_news_admin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml"
  
    ViewData["Title"] = "Quản lý tin tức";
    Layout = "~/Views/Shared/_Layout_admin.cshtml";
    ForumAiTiContext _context = new ForumAiTiContext();
    List<ChuDe> getListCD()
    {
        return _context.ChuDe.ToList();
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Close Header -->
<section class=""container-fluid my-2 px-5 bg-submenu p-2"">
    <div class=""container-fluid bg-forum2"">
        <h3 class=""text-forum-orange mb-0 p-2"">
            <oke class=""bg-text-forum p-1"">Management</oke>
            <oke class=""text-forum-submenu"">Forum</oke> / Tin tức
        </h3>
    </div>
</section>
<!-- Start Categories of The Month -->
<section class=""mx-5 my-2 "">
    <div class=""row"">
        <div class=""col-12 col-md-7 col-lg-7"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c34b6e1c8da52aea8e86e0ae51db58f391580bb5543", async() => {
                WriteLiteral(@"
                <div class=""container-fluid bg-forum3"">
                    <h2 class=""py-4""><i class=""fa fa-newspaper-o""></i> Tạo bài viết mới</h2>
                </div>
                <div class=""container-fluid bg-forum p-4"">
                    <h3 class=""mb-2"">Tạo bài viết mới ngay nào!</h3>
                    <p style=""font-style: italic;"">
                        Hãy tạo mới một bài viết thật hay để mọi người cùng nhau nắm bắt tình hình và tin tức ngày
                        mới vừa qua. Cùng nhau đưa tin cùng nhau chia sẻ. Thử ngay nhé!
                    </p>
                    <ul>
                        <li>Tóm tắt nội dung của tin tức trong tiêu đề bài viết.</li>
                        <li>Cố gắng mô tả chi tiết nhất tin tức qua phần tóm tắt tin tức.</li>
                        <li>Mô tả nội dung chi tiết của tin tức thông qua phần nội dung tin tức.</li>
                        <li>Xem lại câu hỏi của bạn và đăng nó lên trang web.</li>
                    </ul>
          ");
                WriteLiteral(@"      </div>
                <div class=""container-fluid bg-forum2 p-4"">
                    <div class=""ask-title"">
                        <h4>Tiêu đề tin tức</h4>
                        <p style=""font-style: italic;"">Hãy cụ thể và suy nghĩ ra một tiêu đề thật hấp dẫn lôi cuốn
                            người xem bạn nhé!.
                        </p>
                        <input type=""text"" name=""TinTuc.TieuDe"" id=""input-title"" required>
                    </div>
                    <div class=""px-3 row ask-two"">
                        <div class=""col-12 col-md-12 col-lg-6 ask-one"">
                            <h4>Thời gian đưa tin</h4>
                            <p style=""font-style: italic;"">
                                Thời gian chính xác là rất cần thiết đối với mỗi tin tức. Hãy cố gắng chọn ngày đưa
                                tin
                                đúng nhất bạn nhé!
                            </p>
                            <input type=""date"" placeholde");
                WriteLiteral(@"r=""dd-mm-yyyy"" class=""input-group"" name=""TinTuc.NgayDang""
                                id=""input-datetime"" required>
                        </div>
                        <div class=""col-12 col-md-12 col-lg-6 ask-one"">
                            <h4>Chủ đề tin tức</h4>
                            <p style=""font-style: italic;"">Chủ đề rất quan trọng vì vậy đừng bỏ lỡ nó nhé(Vui lòng
                                chọn ít nhất 1 chủ đề và tối đa là 3).
                            </p>
                            <select style=""width: 100%;"" aria-placeholder=""Đừng quên chọn danh mục nhé!"" required
                                class=""js-example-basic-multiple"" id=""listcategory"" name=""states[]"" multiple=""multiple"">
");
#nullable restore
#line 67 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml"
                                 foreach (var item in getListCD())
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c34b6e1c8da52aea8e86e0ae51db58f391580bb9090", async() => {
#nullable restore
#line 69 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml"
                                                             Write(item.TenChuDe);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml"
                                       WriteLiteral(item.MaChuDe);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </select>
                        </div>
                    </div>
                    <div class=""ask-title row"">
                        <div class=""col-12 col-md-6 col-lg-6"">
                            <h4>Hình ảnh đại diện cho tin tức</h4>
                            <p style=""font-style: italic;"">Hãy chọn hình ảnh phù hợp để giúp cho người xem có cái
                                nhìn tổng quan nhất về tin tức của bạn
                            </p>

                        </div>
                        <div class=""col-12 col-md-6 col-lg-6 p-0"" id=""div-img"">
                            <img src=""assets/img/img4.jpg"" id=""img-content""");
                BeginWriteAttribute("alt", " alt=\"", 4549, "\"", 4555, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <button type=""button"" id=""btn-img""><input type=""file"" name=""FileND"" required
                                    id=""changeimg""> <label for=""changeimg"">Thay đổi hình ảnh</label></button>
                        </div>
                    </div>
                    <!--  -->
                    <div class=""ask-content"">
                        <h4>Tóm tắt nội dung tin tức</h4>
                        <p style=""font-style: italic;"">Giới thiệu tổng quan ngắn gọn về tin tức.</p>
                        <div class=""ask-post row"">
                            <div class=""col-12"">
                                <textarea name=""TinTuc.NoiDung"" id=""content"" required></textarea>
                            </div>
                        </div>
                    </div>
                    <!--  -->
                    <div class=""ask-content"">
                        <h4>Mô tả chi tiết nội dung tin tức?</h4>
                        <p style=""font-style: italic;"">Giới thi");
                WriteLiteral(@"ệu vấn đề và mở rộng những gì bạn đặt trong tiêu đề.
                            Tối
                            thiểu 20 ký tự.</p>
                        <div class=""div-paragraph"">
                            <div class=""ask-post row"" id=""divpost0"">
                                <div class=""col-12"">
                                    <input type=""number"" value=""0"" hidden name=""TinTuc.FileToForm[0].STT"" id=""chuthich0"">
                                    <input type=""file"" accept=""image/*"" hidden name=""TinTuc.FileToForm[0].File"" id=""upload0"">
                                    <label for=""upload0""><i class=""fa fa-image"" aria-hidden=""true""></i></label>
                                    <textarea name=""TinTuc.NoiDungTinTuc[0].NoiDung"" id=""content-des0"" required></textarea>
                                    <div class=""garelly0""></div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
      ");
                WriteLiteral(@"                      <div class=""col-12 mt-2 mb-2""><button type=""button"" class=""btn btn-addnew"" id=""btn-add"">Thêm
                                    mới đoạn văn</button></div>
                            <div class=""col-12 mt-2 mb-2"">
                                <a href=""admin_news.html"" type=""button"" class=""btn btn-cancel"">Quay lại</a>
                                <button type=""submit"" class=""btn btn-post ml-2"">Đăng
                                    tin</button>
                            </div>
                        </div>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-12 col-md-5 col-lg-5 p-0"">
            <div class=""container-fluid"">
                <h2 class=""py-4 bg-forum text-light text-center new-question""><i class=""fa fa-television""
                        aria-hidden=""true""></i> Bản xem trước</h2>
                <div class=""row p-3 news-details bg-question-light"">
                    <h2 class=""details-title"" id=""text-title"">Thành công ở đại học là gì? Bí quyết để thành công?
                    </h2>
                    <p class=""time-posted"">Đã đăng ngày <datetime></datetime>
                    </p>
                    <p class=""details-list""><a href=""#"">Java</a> <a href=""#"">Python</a> <a href=""#"">C#</a></p>
                    <img class=""details-img"" id=""img-content"" src=""assets/img/img3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 8034, "\"", 8040, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <p class=""details-content"" id=""text-content"">
                        Nhà tuyển dụng sẽ không chỉ quan tâm tới những ứng viên có thành tích học tập cao mà họ
                        còn rất chú trọng đến sự năng động hoạt bát và kĩ năng từ khi còn làm sinh viên của bạn.
                        Bởi vậy mà bên cạnh việc học tập thì bạn nên tích cực tham gia các hoạt động tình
                        nguyện, các câu lạc bộ các hoạt động văn hóa văn nghệ thể thao do nhà trường tổ chức…Các
                        hoạt động này không chỉ giúp bạn có thểm kinh nghiệm làm việc nhóm, tư duy,… mà còn là
                        cách giúp bạn hoàn thiện về mặt cảm xúc, tình cảm. Hơn nữa còn là cách rèn luyện kĩ năng
                        giao tiếp hiệu quả.
                    </p>
                    <div id=""div-image-preview"">
                        <div class=""news-paragraph p-0"" id=""paragraph0"">
                            <p class=""news-paragraph-content"" id=""content-des0"">
   ");
            WriteLiteral(@"                             Nhà tuyển dụng sẽ không chỉ quan tâm tới những ứng viên có thành tích học tập cao mà
                                họ
                                còn rất chú trọng đến sự năng động hoạt bát và kĩ năng từ khi còn làm sinh viên của
                                bạn.
                                Bởi vậy mà bên cạnh việc học tập thì bạn nên tích cực tham gia các hoạt động tình
                                nguyện, các câu lạc bộ các hoạt động văn hóa văn nghệ thể thao do nhà trường tổ
                                chức…Các
                                hoạt động này không chỉ giúp bạn có thểm kinh nghiệm làm việc nhóm, tư duy,… mà còn
                                là
                                cách giúp bạn hoàn thiện về mặt cảm xúc, tình cảm. Hơn nữa còn là cách rèn luyện kĩ
                                năng
                                giao tiếp hiệu quả.
                            </p>
                            <img src=""assets/img/img4");
            WriteLiteral(".jpg\" id=\"imagges0\"");
            BeginWriteAttribute("alt", " alt=\"", 10108, "\"", 10114, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <p class=""paragraph-note-img"" id=""imagges0"">Hình này là hình siêu công nghệ</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<script>
    $(document).ready(function () {
        $('.js-example-basic-multiple').select2({
            maximumSelectionLength: 3,
            language: ""vi""
        });
    });
</script>
");
#nullable restore
#line 181 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml"
 if (ViewBag.MESSSUCCESS != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 183 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml"
         if (ViewBag.MESSSUCCESS.Equals("1"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script type=\"text/javascript\" charset=\"utf-8\">\r\n                window.onload = function () {\r\n                    setTimeout(() => { alert(\"Bạn đã thêm mới một tin tức!.\"); }, 500);\r\n                };\r\n            </script>\r\n");
#nullable restore
#line 190 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml"
        }
        else if (ViewBag.MESSSUCCESS.Equals("2"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script type=\"text/javascript\" charset=\"utf-8\">\r\n                window.onload = function () {\r\n                    setTimeout(() => { alert(\"Đã có lỗi xảy ra!\\nVui lòng thử lại sau.\"); }, 500);\r\n                };\r\n            </script>\r\n");
#nullable restore
#line 198 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 198 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_News\add_edit_news_admin.cshtml"
         
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
