#pragma checksum "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_QA\admin_qa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b04eb2ed90a350e86beb1d64bc7ecf8a39e09f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_QA_admin_qa), @"mvc.1.0.view", @"/Views/Admin_QA/admin_qa.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b04eb2ed90a350e86beb1d64bc7ecf8a39e09f", @"/Views/Admin_QA/admin_qa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8686f0c93b9c6c3b09795ba00f50435e4f43845", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_QA_admin_qa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Admin_QA\admin_qa.cshtml"
  
    ViewData["Title"] = "Quản lý hỏi đáp";
	Layout = "~/Views/Shared/_Layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!-- Close Header -->
    <section class=""container-fluid my-2 px-5 bg-submenu p-2"">
        <div class=""container-fluid bg-forum2"">
            <h3 class=""text-forum-orange mb-0 p-2"">
                <oke class=""bg-text-forum p-1"">Management</oke>
                <oke class=""text-forum-submenu"">Forum</oke> / Hỏi đáp
            </h3>
        </div>
    </section>
    <!-- Start Categories of The Month -->
    <section class=""mx-5 my-2 "">
        <div class=""row m-0"">
            <div class=""col-12 p-0 bg-forum2"" id=""admin-left"">
                <div class=""container-fluid mb-2"">
                    <div class=""row p-1"">
                        <div class=""col-6""></div>
                        <div class=""col-6 p-2"">
                            <a href=""add_edit_qa_admin.html"" class=""btn btn-addUser"" id=""addUser-btn"">Thêm mới</a>
                        </div>
                    </div>
                    <table id=""example"" class=""table table-striped table-hover table-success"" style=");
            WriteLiteral(@"""width:100%"">
                        <thead>
                            <tr>
                                <th>Tiêu đề</th>
                                <th>Nội dung</th>
                                <th>Hình ảnh tiêu đề</th>
                                <th>Thời gian đăng</th>
                                <th>Người đăng</th>
                                <th>Trạng thái</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì.
                                    Bằng cách tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có
                                    cơ hội h");
            WriteLiteral("ẹn hò với cô nàng trong mơ của mình!\r\n                                </td>\r\n                                <td><img src=\"assets/img/img3.webp\"");
            BeginWriteAttribute("alt", " alt=\"", 2293, "\"", 2299, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-04-25</td>
                                <td>Boy AiTi</td>
                                <th><button class=""btn btn-show"" id=""btn-show"">Đang hiển thị</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 0?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì.
                                    Bằng cách tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có
                                    cơ hội hẹn hò với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 3218, "\"", 3224, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-04-25</td>
                                <td>Boy AiTi</td>
                                <th><button class=""btn btn-hide"" id=""btn-hide"">Đã ẩn</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 2?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì.
                                    Bằng cách tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có
                                    cơ hội hẹn hò với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 4135, "\"", 4141, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-04-25</td>
                                <td>Boy AiTi</td>
                                <th><button class=""btn btn-hide"" id=""btn-hide"">Đã ẩn</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 1?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì.
                                    Bằng cách tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có
                                    cơ hội hẹn hò với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 5052, "\"", 5058, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-05-25</td>
                                <td>Admin</td>
                                <th><button class=""btn btn-hide"" id=""btn-hide"">Đã ẩn</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 0?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã
                                    từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì. Bằng
                                    cách
                                    tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có cơ hội hẹn
                                    hò
                                    với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 6077, "\"", 6083, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-04-25</td>
                                <td>Boy AiTi</td>
                                <th><button class=""btn btn-show"" id=""btn-show"">Đang hiển thị</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 2?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã
                                    từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì. Bằng
                                    cách
                                    tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có cơ hội hẹn
                                    hò
                                    với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.");
            WriteLiteral("webp\"");
            BeginWriteAttribute("alt", " alt=\"", 7113, "\"", 7119, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-04-25</td>
                                <td>Boy AiTi</td>
                                <th><button class=""btn btn-show"" id=""btn-show"">Đang hiển thị</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 1?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã
                                    từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì. Bằng
                                    cách
                                    tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có cơ hội hẹn
                                    hò
                                    với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.");
            WriteLiteral("webp\"");
            BeginWriteAttribute("alt", " alt=\"", 8149, "\"", 8155, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-05-25</td>
                                <td>Admin</td>
                                <th><button class=""btn btn-show"" id=""btn-show"">Đang hiển thị</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 0?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì.
                                    Bằng cách tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có
                                    cơ hội hẹn hò với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 9071, "\"", 9077, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-04-25</td>
                                <td>Boy AiTi</td>
                                <th><button class=""btn btn-hide"" id=""btn-hide"">Đã ẩn</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 2?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì.
                                    Bằng cách tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có
                                    cơ hội hẹn hò với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 9988, "\"", 9994, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-04-25</td>
                                <td>Boy AiTi</td>
                                <th><button class=""btn btn-hide"" id=""btn-hide"">Đã ẩn</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 1?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì.
                                    Bằng cách tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có
                                    cơ hội hẹn hò với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 10905, "\"", 10911, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-05-25</td>
                                <td>Admin</td>
                                <th><button class=""btn btn-hide"" id=""btn-hide"">Đã ẩn</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 0?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã
                                    từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì. Bằng
                                    cách
                                    tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có cơ hội hẹn
                                    hò
                                    với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 11930, "\"", 11936, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-04-25</td>
                                <td>Boy AiTi</td>
                                <th><button class=""btn btn-hide"" id=""btn-hide"">Đã ẩn</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 2?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã
                                    từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì. Bằng
                                    cách
                                    tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có cơ hội hẹn
                                    hò
                                    với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 12958, "\"", 12964, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-04-25</td>
                                <td>Boy AiTi</td>
                                <th><button class=""btn btn-hide"" id=""btn-hide"">Đã ẩn</button></th>
                            </tr>
                            <tr>
                                <td>Cách để có được một cô nàng xinh đẹp 1?</td>
                                <td>Tán tỉnh cô nàng nào đó là việc vừa hồi hộp vừa thú vị. Cho dù đó là cô gái mà bạn
                                    đã
                                    từng quen biết hay mới gặp, việc tán tỉnh chỉ dễ dàng khi bạn biết nên làm gì. Bằng
                                    cách
                                    tiếp cận cô ấy với sự tự tin, bộc lộ cá tính và tìm hiểu nàng, bạn sẽ có cơ hội hẹn
                                    hò
                                    với cô nàng trong mơ của mình!
                                </td>
                                <td><img src=""assets/img/img3.webp""");
            BeginWriteAttribute("alt", " alt=\"", 13986, "\"", 13992, 0);
            EndWriteAttribute();
            WriteLiteral(@"></td>
                                <td>2011-05-25</td>
                                <td>Admin</td>
                                <th><button class=""btn btn-show"" id=""btn-show"">Đang hiển thị</button></th>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr>
                                <th>Tiêu đề</th>
                                <th>Nội dung</th>
                                <th>Hình ảnh tiêu đề</th>
                                <th>Thời gian đăng</th>
                                <th>Người đăng</th>
                            </tr>
                        </tfoot>
                    </table>
                </div>
            </div>
            <div class=""col-12 col-md-4 col-lg-4"" id=""admin-right"">
                <h2 id=""text-mess-user"" class=""py-4 bg-forum text-center ""><i class=""fa fa-television""
                        aria-hidden=""true""></i> Thêm mới</h2>
                <div c");
            WriteLiteral(@"lass=""row p-2 details bg-question-light"">
                    <h2 class=""details-title"" id=""text-title"">Thành công ở đại học là gì? Bí quyết để thành công?
                    </h2>
                    <p class=""time-posted"">Đã đăng ngày 27 / 01 / 2022 - <a href=""#""><img id=""question-imguser""
                                src=""images/user.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 15369, "\"", 15375, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Boy AiTi</a></p>
                    <p class=""details-list""><a href=""#"">Java</a> <a href=""#"">Python</a> <a href=""#"">C#</a></p>
                    <p class=""details-content"" id=""text-content"">
                        Nhà tuyển dụng sẽ không chỉ quan tâm tới những ứng viên có thành tích học tập cao mà họ
                        còn rất chú trọng đến sự năng động hoạt bát và kĩ năng từ khi còn làm sinh viên của bạn.
                        Bởi vậy mà bên cạnh việc học tập thì bạn nên tích cực tham gia các hoạt động tình
                        nguyện, các câu lạc bộ các hoạt động văn hóa văn nghệ thể thao do nhà trường tổ chức…Các
                        hoạt động này không chỉ giúp bạn có thểm kinh nghiệm làm việc nhóm, tư duy,… mà còn là
                        cách giúp bạn hoàn thiện về mặt cảm xúc, tình cảm. Hơn nữa còn là cách rèn luyện kĩ năng
                        giao tiếp hiệu quả.
                    </p>
                    <div id=""template-mo-zay-hero-carousel"" class=""carousel slid");
            WriteLiteral(@"e"" data-bs-ride=""carousel"">
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
                                            <img id=""image0"" class=""img-fluid"" src=""./assets/img/img2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 17331, "\"", 17337, 0);
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
                                            <img id=""image1"" class=""img-fluid"" src=""./assets/img/img2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 17892, "\"", 17898, 0);
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
                                            <img id=""image2"" class=""img-fluid"" src=""./assets/img/img2.webp""");
            BeginWriteAttribute("alt", " alt=\"", 18453, "\"", 18459, 0);
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
                <section class=""bg-text-forum"">
                    <div style=""border-bottom: 3px solid #2a9d8f;"">
                        <h4");
            BeginWriteAttribute("class", " class=\"", 19439, "\"", 19447, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"padding: 2% 4%;\">Bình luận</h4>\r\n                    </div>\r\n                    <div class=\"row comment\">\r\n                        <div class=\"col-3 col-lg-2 col-md-2 comment-left\">\r\n                            <img src=\"images/user.jfif\"");
            BeginWriteAttribute("alt", " alt=\"", 19695, "\"", 19701, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 20270, "\"", 20276, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 20712, "\"", 20718, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 21154, "\"", 21160, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""col-9 col-lg-10 col-md-10 comment-right"">
                            <p>Bài đăng hay phết. khá hữu ích tôi sẽ ghi nhận</p>
                        </div>
                    </div>
                </section>
                <div class=""m-2 p-2"">
                    <a href=""admin_qa.html"" class=""d-block m-auto btn btn-cancel"" id=""btn-hide-infor"">Ẩn Tab</a>
                    <button class=""btn btn-cancel"" id=""btn-remove-qa"">Xóa câu hỏi</button>
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