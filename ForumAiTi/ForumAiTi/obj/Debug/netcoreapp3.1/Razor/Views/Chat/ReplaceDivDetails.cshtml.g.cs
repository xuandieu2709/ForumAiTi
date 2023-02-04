#pragma checksum "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba57618eb99d4f872ff68893f79cf8e864adaacc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_ReplaceDivDetails), @"mvc.1.0.view", @"/Views/Chat/ReplaceDivDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba57618eb99d4f872ff68893f79cf8e864adaacc", @"/Views/Chat/ReplaceDivDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8686f0c93b9c6c3b09795ba00f50435e4f43845", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Chat_ReplaceDivDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
  
    ForumAiTiContext _context = new ForumAiTiContext();
    List<CttroChuyen> getListTCbyMa(int ma)
    {
        return _context.CttroChuyen.Where(x => x.MaTroChuyen == ma).ToList();
    }
    CttroChuyen getLastMess(int ma)
    {
        return _context.CttroChuyen.OrderByDescending(x => x.ThoiGianGui).FirstOrDefault(x => x.MaTroChuyen == ma);
    }
    CttroChuyen getFinalMess(string taikhoan)
        {
            CttroChuyen final = _context.CttroChuyen.OrderByDescending(x =>x.ThoiGianGui).FirstOrDefault(x => x.NguoiGui == taikhoan || x.NguoiGui == User.FindFirst("TaiKhoan").Value.Trim());
            return final;
        }
    NguoiDung getUSERByTK(string tk)
    {
        return _context.NguoiDung.Where(x => x.TaiKhoan == tk).FirstOrDefault();
    }
    string getAvatar(byte[] avataar)
    {
        if (avataar == null) return "/images/noneavatar.jpg";
        string imageBase64Data = Convert.ToBase64String(avataar);
        string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
        return imageDataURL;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-6 col-lg-7 col-xl-8 bg-light\" id=\"repalceblockChat\">\r\n");
#nullable restore
#line 29 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                             if (ViewBag.ListChat == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""d-block m-auto p-5"">
                                    <h1 class=""text-center"">Hãy theo dõi các thành viên trong Forum để trò chuyện với nhau
                                        bạn nhé!</h1>
                                </div>
");
#nullable restore
#line 35 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                 if(User.FindFirst("TaiKhoan").Value.Trim() == ViewBag.ListChat.ThanhVien1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"py-3 m-0 bg-forum row\">\r\n                                    <div class=\"col-4 col-lg-2 col-md-3\">\r\n                                        <img id=\"avatar-chat\"");
            BeginWriteAttribute("src", " src=\"", 2003, "\"", 2069, 1);
#nullable restore
#line 42 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
WriteAttributeValue("", 2009, getAvatar(getUSERByTK(ViewBag.ListChat.ThanhVien2).HinhAnh), 2009, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2070, "\"", 2076, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <input type=\"text\" hidden");
            BeginWriteAttribute("name", " name=\"", 2149, "\"", 2156, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"user2\"");
            BeginWriteAttribute("value", " value=\"", 2168, "\"", 2226, 1);
#nullable restore
#line 43 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
WriteAttributeValue("", 2176, getUSERByTK(ViewBag.ListChat.ThanhVien2).TaiKhoan, 2176, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"col-6 col-lg-8 col-md-7 m-auto\">\r\n                                        <h4 id=\"name-chat\">");
#nullable restore
#line 46 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                                      Write(getUSERByTK(ViewBag.ListChat.ThanhVien2).HoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                    </div>
                                    <div class=""col-1 ml-auto m-auto dropdown1"">
                                        <i class=""fa fa-ellipsis-v dropbtn1"" aria-hidden=""true""></i>
                                        <div class=""dropdown-content1"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 2816, "\"", 2883, 2);
            WriteAttributeValue("", 2823, "/personal/", 2823, 10, true);
#nullable restore
#line 51 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
WriteAttributeValue("", 2833, getUSERByTK(ViewBag.ListChat.ThanhVien2).TaiKhoan, 2833, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-info-circle""></i> Thông tin</a>
                                            <a href=""#""><i class=""fa fa-minus-circle"" aria-hidden=""true""></i> Bỏ theo dõi
                                            </a>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 57 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                    }else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"py-3 m-0 bg-forum row\">\r\n                                    <div class=\"col-4 col-lg-2 col-md-3\">\r\n                                        <img id=\"avatar-chat\"");
            BeginWriteAttribute("src", " src=\"", 3534, "\"", 3600, 1);
#nullable restore
#line 61 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
WriteAttributeValue("", 3540, getAvatar(getUSERByTK(ViewBag.ListChat.ThanhVien1).HinhAnh), 3540, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3601, "\"", 3607, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <input type=\"text\" hidden");
            BeginWriteAttribute("name", " name=\"", 3676, "\"", 3683, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"user2\"");
            BeginWriteAttribute("value", " value=\"", 3695, "\"", 3753, 1);
#nullable restore
#line 62 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
WriteAttributeValue("", 3703, getUSERByTK(ViewBag.ListChat.ThanhVien1).TaiKhoan, 3703, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"col-6 col-lg-8 col-md-7 m-auto\">\r\n                                        <h4 id=\"name-chat\">");
#nullable restore
#line 65 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                                      Write(getUSERByTK(ViewBag.ListChat.ThanhVien1).HoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                        
                                    </div>
                                    <div class=""col-1 ml-auto m-auto dropdown1"">
                                        <i class=""fa fa-ellipsis-v dropbtn1"" aria-hidden=""true""></i>
                                        <div class=""dropdown-content1"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 4385, "\"", 4452, 2);
            WriteAttributeValue("", 4392, "/personal/", 4392, 10, true);
#nullable restore
#line 71 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
WriteAttributeValue("", 4402, getUSERByTK(ViewBag.ListChat.ThanhVien1).TaiKhoan, 4402, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-info-circle""></i> Thông tin</a>
                                            <a href=""#""><i class=""fa fa-minus-circle"" aria-hidden=""true""></i> Bỏ theo dõi
                                            </a>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 77 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"text\" hidden id=\"MaChat\"");
            BeginWriteAttribute("value", " value=\"", 4916, "\"", 4955, 1);
#nullable restore
#line 78 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
WriteAttributeValue("", 4924, ViewBag.ListChat.MaTroChuyen, 4924, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div id=\"details-chat\" class=\"pt-3 pe-3\" data-mdb-perfect-scrollbar=\"true\"\r\n                                    style=\"position: relative; height: 400px\">\r\n");
#nullable restore
#line 81 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                     if(getListTCbyMa(ViewBag.ListChat.MaTroChuyen).Count() == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"m-auto p-auto\">\r\n                                        <h2 class=\"text-center text-midle\">Hãy bắt đầu cuộc trò chuyện ngay nào.</h2>\r\n                                        </div>\r\n");
#nullable restore
#line 86 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                    }
                                    else{
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                         foreach (var item in getListTCbyMa(ViewBag.ListChat.MaTroChuyen))
                                        {
                                         

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                          if(item.NguoiGui == User.FindFirst("TaiKhoan").Value.Trim())
                                         {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""d-flex flex-row justify-content-end"">
                                                <div>
                                                    <p class=""small p-2 me-3 mb-1 text-white rounded-3 bg-primary"">
                                                        ");
#nullable restore
#line 95 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                                   Write(item.NoiDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"small me-3 mb-3 rounded-3 text-muted\">");
#nullable restore
#line 96 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                                                                               Write(String.Format("{0:HH:mm:ss dd/MM/yyyy}", item.ThoiGianGui));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 99 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                            
                                         }  
                                         else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""d-flex flex-row justify-content-start"">
                                        <div>
                                            <p class=""small p-2 ms-3 mb-1 rounded-3"" style=""background-color: #f5f6f7;"">
                                                ");
#nullable restore
#line 105 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                           Write(item.NoiDung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <p class=\"small ms-3 mb-3 rounded-3 text-muted float-end\">");
#nullable restore
#line 106 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                                                                                 Write(String.Format("{0:HH:mm:ss dd/MM/yyyy}", item.ThoiGianGui));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 110 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                           
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                    <div class=""row m-0"">
                                        <div id=""div-send-chat""
                                            class=""col-12 row m-0 d-flex justify-content-start align-items-center pt-1 mt-2"">
                                            <div class=""col-2 col-lg-1 float-right"" id=""div-left"">
                                                <img");
            BeginWriteAttribute("src", " src=\"", 7859, "\"", 7937, 1);
#nullable restore
#line 119 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
WriteAttributeValue("", 7865, getAvatar(getUSERByTK(User.FindFirst("TaiKhoan").Value.Trim()).HinhAnh), 7865, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                                    alt=""avatar 3"" id=""avatarSendChat"">
                                            </div>
                                            <div class=""col-9 col-lg-10"" id=""div-right"">
                                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 8237, "\"", 8285, 1);
#nullable restore
#line 123 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
WriteAttributeValue("", 8245, User.FindFirst("TaiKhoan").Value.Trim(), 8245, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                                    id=\"username\" hidden>\r\n                                                <a class=\"ms-1\"><input hidden type=\"file\"");
            BeginWriteAttribute("name", " name=\"", 8452, "\"", 8459, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""upfilechat""><label
                                                        for=""upfilechat""><i class=""fa fa-paperclip""></i></label></a>
                                                <a class=""ms-lg-3""><i class=""fa fa-smile""></i></a>
                                                <textarea type=""text"" class=""form-control form-control-lg m-1""
                                                    id=""exampleFormControlInput2"" placeholder=""Soạn tin...""></textarea>
                                            </div>
                                            <div class=""col-1 m-auto float-left"">
                                                <button type=""button"" class=""bg-forum2"" id=""btn-submid-send""><i
                                                        class=""fa fa-paper-plane""></i></button>
                                            </div>
                                            <div class=""col-1""></div>
                                            <div class=""col-11 float-right mt-1""");
            WriteLiteral(@" id=""div-img-chat"">
                                            </div>
                                            <script>
                                                $(function () {
                                                    // Multiple images preview in browser
                                                    var imagesPreview = function (input, placeToInsertImagePreview, id) {
                                                        if (input.files) {
                                                            var reader = new FileReader();
                                                            reader.onload = function (event) {
                                                                if ($('div#div-img-chat' + id + ' img#imagges' + id + '').length > 0) {
                                                                    // $('div.garelly' + id + ' img#imagges' + id + '').attr('src', event.target.result);
                                                              ");
            WriteLiteral(@"      $('img#imagges' + id + '').attr('src', event.target.result);
                                                                }
                                                                else {
                                                                    $($.parseHTML('<img id=""imagges' + id + '"">')).attr('src', event.target.result).appendTo(placeToInsertImagePreview);
                                                                    $('div#div-img-chat' + id + ' img#imagges' + id + '')
                                                                        .after('<i class=""fa fa-times"" aria-hidden=""true"" id=""imagges' + id + '""></i>');
                                                                }
                                                            }
                                                            reader.readAsDataURL(input.files[0]);
                                                        }
                                                    };
          ");
            WriteLiteral(@"                                          $(document).on('change', 'input[id*=""upfilechat""]', function () {
                                                        var id = $(this).attr('id');
                                                        id = id.substring(10, id.length);
                                                        imagesPreview(this, 'div#div-img-chat' + id, id);
                                                    });
                                                    // remove image
                                                    $(document).on('click', 'i[id*=""imagges""]', function () {
                                                        var id = $(this).attr('id');
                                                        id = id.substring(7, id.length);
                                                        $('div#div-img-chat' + id + ' img#imagges' + id + '').remove();
                                                        $('input#upfilechat' + id + '').val("""");
            WriteLiteral(@"
                                                    });
                                                });
                                            </script>
                                        </div>
                                    </div>
");
#nullable restore
#line 174 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Chat\ReplaceDivDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n            <script>\r\n                $(\'#details-chat\').scrollTop($(\'#details-chat\')[0].scrollHeight);\r\n            </script>");
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