#pragma checksum "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34e037eedf3cf6b405eed5f690eaee2fe610cc69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_contact), @"mvc.1.0.view", @"/Views/Contact/contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34e037eedf3cf6b405eed5f690eaee2fe610cc69", @"/Views/Contact/contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8686f0c93b9c6c3b09795ba00f50435e4f43845", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ForumAiTi.Models.GopY>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-10 m-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/sendSupport"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
  
    ViewData["Title"] = "Li??n h???";
    Layout = "~/Views/Shared/_Layout.cshtml";
    ForumAiTiContext _context = new ForumAiTiContext();
    NguoiDung getUserbyAC()
    {
        string tk = null;
        if (User.Identity.IsAuthenticated)
        {
            tk = User.FindFirst("TaiKhoan").Value.Trim();
        }
        if (tk == null) return new NguoiDung();
        return _context.NguoiDung.FirstOrDefault(x => x.TaiKhoan == tk);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Start Content Page -->
<div class=""container-fluid bg-light py-5"">
    <div class=""col-md-6 m-auto text-center"">
        <h1 class=""h1"">Li??n h??? v???i ch??ng t??i</h1>
        <p>
            H??y chia s??? cho ch??ng t??i nh???ng v???n ????? m?? b???n ??ang g???p ph???i v?? nh???ng mong mu???n forum c???n c???i ti???n ????? ph?? h???p
            h??n v???i nhu c???u c???a b???n.
        </p>
    </div>
</div>

<!-- Start Contact -->
<div class=""container mt-2 mb-2 bg-forum2 py-5"">
    <div class=""row py-5 contact"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34e037eedf3cf6b405eed5f690eaee2fe610cc695868", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 mb-4\">\r\n                    <label for=\"inputname\">H??? v?? t??n</label>\r\n                    <input type=\"text\" required class=\"form-control mt-1\"");
                BeginWriteAttribute("value", " value=\"", 1297, "\"", 1325, 1);
#nullable restore
#line 35 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
WriteAttributeValue("", 1305, getUserbyAC().HoTen, 1305, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""name""
                        name=""HoTen"" placeholder=""H??? v?? t??n c???a b???n"">
                </div>
                <div class=""form-group col-md-6 mb-4"">
                    <label for=""inputemail"">Email</label>
                    <input type=""email"" required class=""form-control mt-1""");
                BeginWriteAttribute("value", " value=\"", 1622, "\"", 1650, 1);
#nullable restore
#line 40 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
WriteAttributeValue("", 1630, getUserbyAC().Email, 1630, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""email""
                        name=""Email"" placeholder=""Email c???a b???n"">
                </div>
            </div>
            <div class=""mb-4"">
                <label for=""inputsubject"">Ti??u ?????</label>
                <input type=""text"" required class=""form-control mt-1"" id=""subject"" name=""TieuDe"" placeholder=""Ti??u ?????"">
            </div>
            <div class=""mb-4"">
                <label for=""inputmessage"">N???i dung</label>
                <textarea required class=""form-control mt-1"" id=""message"" name=""NoiDung"" placeholder=""N???i dung""
                    rows=""8""></textarea>
            </div>
            <div class=""row"">
                <div class=""col text-end mt-2"">
");
#nullable restore
#line 55 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
                         if (User.IsInRole("ADMIN") == true)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button type=\"button\" onclick=\"alert(\'Kh??ng th??? g???i g??p ??!\\nH??y ????ng nh???p b???ng t??i kho???n ng?????i d??ng ????? s??? d???ng ch???c n??ng n??y.\')\" class=\"btn btn-success btn-lg px-3\">G??p ??</button>\r\n");
#nullable restore
#line 60 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
                         
                    }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button type=\"submit\" class=\"btn btn-success btn-lg px-3\">G??p ??</button>\r\n");
#nullable restore
#line 63 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 69 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
 if (ViewBag.MessSUcc != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
     if (ViewBag.MessSUcc.Equals("1"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script type=""text/javascript"" charset=""utf-8"">
            window.onload = function () {
                setTimeout(() => { alert(""C???m ??n ?? ki???n ????ng g??p c???a b???n.\nCh??ng t??i s??? c??? g???ng c???i thi???n ????? ph?? h???p nh???t v???i y??u c???u c???a m???i ng?????i.""); }, 500);
            };
        </script>
");
#nullable restore
#line 78 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
    }
    else if (ViewBag.MessSUcc.Equals("2"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script type=\"text/javascript\" charset=\"utf-8\">\r\n            window.onload = function () {\r\n                setTimeout(() => { alert(\"???? c?? l???i x???y ra!\\nVui l??ng th??? l???i sau.\"); }, 500);\r\n            };\r\n        </script>\r\n");
#nullable restore
#line 86 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
    }
    else if (ViewBag.MessSUcc.Equals("3"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <script type=""text/javascript"" charset=""utf-8"">
            window.onload = function () {
                setTimeout(() => { alert(""H??m nay b???n ???? g??p ?? 3 l???n r???i.\n????? d??nh ng??y mai g??p ?? ti???p b???n nh??.\nC??m ??n b???n.""); }, 500);
            };
        </script>
");
#nullable restore
#line 94 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\Dell\OneDrive - hcmunre.edu.vn\Desktop\ForumAiTi\ForumAiTi\ForumAiTi\Views\Contact\contact.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- End Contact -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForumAiTi.Models.GopY> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
