#pragma checksum "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\details_qa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc5475507b3b5e7ade6040e0505fb25842039861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QA_details_qa), @"mvc.1.0.view", @"/Views/QA/details_qa.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5475507b3b5e7ade6040e0505fb25842039861", @"/Views/QA/details_qa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8686f0c93b9c6c3b09795ba00f50435e4f43845", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QA_details_qa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-content modal-body border-0 p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\QA\details_qa.cshtml"
  
    ViewData["Title"] = "Hỏi đáp";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Close Header -->
    <section class=""container-fluid my-2 px-5 bg-submenu p-2"">
        <div class=""container-fluid bg-forum2"">
            <h3 class=""text-forum-orange mb-0 p-2"">
                <oke class=""bg-text-forum p-1"">Forum</oke>
                <oke class=""text-forum-submenu"">AiTi</oke> / Hỏi đáp
            </h3>
        </div>
    </section>
    <!-- Modal -->
    <div class=""modal fade bg-white"" id=""templatemo_search"" tabindex=""-1"" role=""dialog""
        aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""w-100 pt-1 mb-5 text-right"">
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc5475507b3b5e7ade6040e0505fb258420398615461", async() => {
                WriteLiteral(@"
                <div class=""input-group mb-2"">
                    <input type=""text"" class=""form-control"" id=""inputModalSearch"" name=""q"" placeholder=""Tìm kiếm ..."">
                    <button type=""submit"" class=""input-group-text bg-success text-light"">
                        <i class=""fa fa-fw fa-search text-white""></i>
                    </button>
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
    </div>
    <!-- Start Categories of The Month -->
    <section class=""mx-5 my-2 "">
        <div class=""row"">
            <div class=""col-12 col-md-8 col-lg-8"">
                <div class=""container-fluid bg-question-light"">
                    <div class=""row p-2 details"">
                        <h2 class=""details-title"">Thành công ở đại học là gì? Bí quyết để thành công?</h2>
                        <p class=""time-posted"">Đã đăng ngày 27 / 01 / 2022 - <a href=""#""><img id=""question-imguser""
                                    src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 1959, "\"", 1965, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Boy AiTi</a></p>
                        <p class=""details-list""><a href=""#"">Java</a> <a href=""#"">Python</a> <a href=""#"">C#</a></p>
                        <p class=""details-content"">
                            Nhà tuyển dụng sẽ không chỉ quan tâm tới những ứng viên có thành tích học tập cao mà họ
                            còn rất chú trọng đến sự năng động hoạt bát và kĩ năng từ khi còn làm sinh viên của bạn.
                            Bởi vậy mà bên cạnh việc học tập thì bạn nên tích cực tham gia các hoạt động tình
                            nguyện, các câu lạc bộ các hoạt động văn hóa văn nghệ thể thao do nhà trường tổ chức…Các
                            hoạt động này không chỉ giúp bạn có thểm kinh nghiệm làm việc nhóm, tư duy,… mà còn là
                            cách giúp bạn hoàn thiện về mặt cảm xúc, tình cảm. Hơn nữa còn là cách rèn luyện kĩ năng
                            giao tiếp hiệu quả.
                        </p>
                        <div id=""template-mo-zay-hero-caro");
            WriteLiteral(@"usel"" class=""carousel slide"" data-bs-ride=""carousel"">
                            <ol class=""carousel-indicators"">
                                <li data-bs-target=""#template-mo-zay-hero-carousel"" data-bs-slide-to=""0"" class=""active"">
                                </li>
                                <li data-bs-target=""#template-mo-zay-hero-carousel"" data-bs-slide-to=""1""></li>
                                <li data-bs-target=""#template-mo-zay-hero-carousel"" data-bs-slide-to=""2""></li>
                            </ol>
                            <div class=""carousel-inner"">
                                <div class=""carousel-item active"">
                                    <div class=""container-fluid"">
                                        <div class=""row p-5"">
                                            <div class=""mx-auto col-md-12 col-lg-12 order-lg-last"">
                                                <img class=""img-fluid"" src=""./assets/img/img2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 3983, "\"", 3989, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""carousel-item"">
                                    <div class=""container-fluid"">
                                        <div class=""row p-5"">
                                            <div class=""mx-auto col-md-12 col-lg-12 order-lg-last"">
                                                <img class=""img-fluid"" src=""./assets/img/img2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 4568, "\"", 4574, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""carousel-item"">
                                    <div class=""container-fluid"">
                                        <div class=""row p-5"">
                                            <div class=""mx-auto col-md-12 col-lg-12 order-lg-last"">
                                                <img class=""img-fluid"" src=""./assets/img/img2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 5153, "\"", 5159, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <a class=""carousel-control-prev text-decoration-none w-auto ps-3""
                                href=""#template-mo-zay-hero-carousel"" role=""button"" data-bs-slide=""prev"">
                                <i class=""fas fa-chevron-left""></i>
                            </a>
                            <a class=""carousel-control-next text-decoration-none w-auto pe-3""
                                href=""#template-mo-zay-hero-carousel"" role=""button"" data-bs-slide=""next"">
                                <i class=""fas fa-chevron-right""></i>
                            </a>
                        </div>
                    </div>
                </div>
                <section class=""bg-text-forum"">
                    <div style=""border-bottom: 3px solid ");
            WriteLiteral("#2a9d8f;\">\r\n                        <h4");
            BeginWriteAttribute("class", " class=\"", 6223, "\"", 6231, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"padding: 2% 4%;\">Bình luận</h4>\r\n                    </div>\r\n                    <div class=\"row comment\">\r\n                        <div class=\"col-3 col-lg-2 col-md-2 comment-left\">\r\n                            <img src=\"images/user.jfif\"");
            BeginWriteAttribute("alt", " alt=\"", 6479, "\"", 6485, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""col-9 col-lg-10 col-md-10 comment-right"">
                            <p>Bài đăng hay phết. khá hữu ích tôi sẽ ghi nhận.Nếu như có thể
                                tôi muốn nó hay hơn nữa bạn nên sửa chỗ này lại một tí
                            </p>
                        </div>
                    </div>
                    <div class=""row comment"">
                        <div class=""col-3 col-lg-2 col-md-2 comment-left"">
                            <img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 7054, "\"", 7060, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""col-9 col-lg-10 col-md-10 comment-right"">
                            <p>Bài đăng hay phết. khá hữu ích tôi sẽ ghi nhận</p>
                        </div>
                    </div>
                    <div class=""row comment"">
                        <div class=""col-3 col-lg-2 col-md-2 comment-left"">
                            <img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 7496, "\"", 7502, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""col-9 col-lg-10 col-md-10 comment-right"">
                            <p>Bài đăng hay phết. khá hữu ích tôi sẽ ghi nhận</p>
                        </div>
                    </div>
                    <div class=""row comment"">
                        <div class=""col-3 col-lg-2 col-md-2 comment-left"">
                            <img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 7938, "\"", 7944, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""col-9 col-lg-10 col-md-10 comment-right"">
                            <p>Bài đăng hay phết. khá hữu ích tôi sẽ ghi nhận</p>
                        </div>
                    </div>
                    <div class=""m-2 p-2"">
                        <button class=""d-block m-auto"" id=""load-more""><i class=""fa fa-spinner""
                                aria-hidden=""true""></i></button>
                    </div>
                </section>
                <section class=""bg-text-forum m-0 p-2 mb-2"">
                    <div class=""anwser row m-0 p-2"">
                        <div class=""col-4 col-lg-2 col-md-2 anwser-left"">
                            <img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 8709, "\"", 8715, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"col-8 col-lg-10 col-md-10 anwser-right\">\r\n                            <input type=\"file\" hidden");
            BeginWriteAttribute("name", " name=\"", 8882, "\"", 8889, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"upload\">\r\n                            <label for=\"upload\"><i class=\"fa fa-image\" aria-hidden=\"true\"></i></label>\r\n                            <input type=\"file\" hidden");
            BeginWriteAttribute("name", " name=\"", 9062, "\"", 9069, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"upload1\">\r\n                            <label for=\"upload1\"><i class=\"fa fa-file-archive\" aria-hidden=\"true\"></i></label>\r\n                            <textarea");
            BeginWriteAttribute("name", " name=\"", 9235, "\"", 9242, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 9243, "\"", 9248, 0);
            EndWriteAttribute();
            WriteLiteral(@"></textarea>
                            <div class=""garelly""></div>
                            <script>
                                var fileTag = document.getElementById(""upload""),
                                    preview = document.getElementsByClassName(""garelly"");

                                fileTag.addEventListener(""change"", function () {
                                    changeImage(this);
                                });

                                function changeImage(input) {
                                    var reader;

                                    if (input.files && input.files[0]) {
                                        reader = new FileReader();

                                        reader.onload = function (e) {
                                            if ($('img#img0').length > 0) {
                                                $('img#img0').attr('src', e.target.result);
                                            }
                ");
            WriteLiteral(@"                            else {
                                                $('.garelly').append('<img id=""img0"" src=""' + e.target.result + '""/><i id=""img0"" class=""fa fa-times"" aria-hidden=""true""></i>');
                                            }
                                            // preview.setAttribute('src', e.target.result);
                                        }

                                        reader.readAsDataURL(input.files[0]);
                                    }
                                }
                                $(document).on('click','i#img0',function () {
                                        $('.garelly').empty();
                                        $('input#upload').val("""");
                                });
                            </script>
                            <button class=""btn btn-send"">Bình luận</button>
                        </div>
                    </div>
                </section>
            </div>
");
            WriteLiteral(@"            <div class=""col-12 col-md-4 col-lg-4 p-0"">
                <div class=""container-fluid"">
                    <a href=""#"" class=""ask-question"">
                        <h2 class=""py-4 bg-submenu-1 text-center"">Đặt câu hỏi</h2>
                    </a>
                </div>
                <div class=""container-fluid"">
                    <h2 class=""py-4 bg-forum text-light text-center new-question"">Câu hỏi mới nhất</h2>
                    <div class=""question-div"">
                        <div class=""question-sub"">
                            <a href=""#"">
                                <h4 class=""question-sub-title"">Cách để bỏ code vô bộ não của coder</h4>
                            </a>
                            <p class=""question-sub-time-posted"">Đăng ngày 20 / 01 / 2022</p>
                            <a href=""#"">
                                <p class=""question-sub-imguser""><img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 12249, "\"", 12255, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Boy AiTi</p>
                            </a>
                        </div>
                        <div class=""question-sub"">
                            <a href=""#"">
                                <h4 class=""question-sub-title"">Cách để bỏ code vô bộ não của coder</h4>
                            </a>
                            <p class=""question-sub-time-posted"">Đăng ngày 20 / 01 / 2022</p>
                            <a href=""#"">
                                <p class=""question-sub-imguser""><img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 12798, "\"", 12804, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Boy AiTi</p>
                            </a>
                        </div>
                        <div class=""question-sub"">
                            <a href=""#"">
                                <h4 class=""question-sub-title"">Cách để bỏ code vô bộ não của coder</h4>
                            </a>
                            <p class=""question-sub-time-posted"">Đăng ngày 20 / 01 / 2022</p>
                            <a href=""#"">
                                <p class=""question-sub-imguser""><img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 13347, "\"", 13353, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Boy AiTi</p>
                            </a>
                        </div>
                        <div class=""question-sub"">
                            <a href=""#"">
                                <h4 class=""question-sub-title"">Cách để bỏ code vô bộ não của coder</h4>
                            </a>
                            <p class=""question-sub-time-posted"">Đăng ngày 20 / 01 / 2022</p>
                            <a href=""#"">
                                <p class=""question-sub-imguser""><img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 13896, "\"", 13902, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Boy AiTi</p>
                            </a>
                        </div>
                        <div class=""question-sub"">
                            <a href=""#"">
                                <h4 class=""question-sub-title"">Cách để bỏ code vô bộ não của coder</h4>
                            </a>
                            <p class=""question-sub-time-posted"">Đăng ngày 20 / 01 / 2022</p>
                            <a href=""#"">
                                <p class=""question-sub-imguser""><img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 14445, "\"", 14451, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Boy AiTi</p>
                            </a>
                        </div>
                    </div>
                </div>
                <div class=""container-fluid"">
                    <h2 class=""py-4 bg-forum text-light text-center new-question"">Thành viên ưu tú</h2>
                    <div class=""listTopMember"">
                        <div class=""row member"">
                            <div class=""col-4 col-sm-6 member-left"">
                                <img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 14966, "\"", 14972, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-8 col-sm-6 member-right"">
                                <h4>Boy AiTi</h4>
                                <p>Ngày 27 Tháng 09 năm 2001</p>
                            </div>
                        </div>
                        <div class=""row member"">
                            <div class=""col-4 col-sm-6 member-left"">
                                <img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 15447, "\"", 15453, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-8 col-sm-6 member-right"">
                                <h4>Boy AiTi</h4>
                                <p>Ngày 27 Tháng 09 năm 2001</p>
                            </div>
                        </div>
                        <div class=""row member"">
                            <div class=""col-4 col-sm-6 member-left"">
                                <img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 15928, "\"", 15934, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-8 col-sm-6 member-right"">
                                <h4>Boy AiTi</h4>
                                <p>Ngày 27 Tháng 09 năm 2001</p>
                            </div>
                        </div>
                        <div class=""row member"">
                            <div class=""col-4 col-sm-6 member-left"">
                                <img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 16409, "\"", 16415, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-8 col-sm-6 member-right"">
                                <h4>Boy AiTi</h4>
                                <p>Ngày 27 Tháng 09 năm 2001</p>
                            </div>
                        </div>
                        <div class=""row member"">
                            <div class=""col-4 col-sm-6 member-left"">
                                <img src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 16890, "\"", 16896, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                            <div class=""col-8 col-sm-6 member-right"">
                                <h4>Boy AiTi</h4>
                                <p>Ngày 27 Tháng 09 năm 2001</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>");
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
