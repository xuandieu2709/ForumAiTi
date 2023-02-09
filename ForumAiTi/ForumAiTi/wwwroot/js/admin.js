
$(document).ready(function () {
    $(document).on('click',"i#hidepass",function () {
        $(this).toggleClass("fa-eye fa-eye-slash");
        var input = $($(this).attr("toggle"));
        // var tag = $('input#Matkhau');
        if (input.attr("type") == "password") {
            input.attr("type", "text");
        } else {
            input.attr("type", "password");
        }
    });
    $('div#admin-left').show();
    $('div#admin-right').hide(); // col-md-8 col-lg-8 
    $('#div-edit-remove').hide();
    $('#div-cancel-confirm').hide();
});
$(document).on('click', 'button#addUser-btn', function () {
    $('div#admin-left').addClass('col-md-8 col-lg-8 ');
    $('div#admin-right').show();
    $('#div-cancel-confirm').show();
    $('#div-edit-remove').hide();
    $('h2#text-mess-user').text('Thêm mới');
    $('input#Taikhoan').removeAttr('readonly');
    Undisabled_Tag();
    EmptyValue();
});
$(document).on('click', 'tbody > tr', function () {
    $('div#admin-left').addClass('col-md-8 col-lg-8 ');
    $('div#admin-right').show();
    $('h2#text-mess-user').text('Thông tin');
    $('#div-edit-remove').show();
    $('#div-cancel-confirm').hide();
    disabled_Tag();
}); //edit-btn
$(document).on('click', 'button#edit-btn', function () {
    $('#div-cancel-confirm').show();
    $('h2#text-mess-user').text('Chỉnh sửa');
    $('input#Taikhoan').attr('readonly', true);
    Undisabled_Tag();

});
function hideTab()
{
//     $('div#admin-right').hide(); 
//     $('div#admin-left').removeClass('col-md-8 col-lg-8 ');
//     $('div#admin-left').addClass('col-md-12 col-lg-12 ');
// 
location.reload();
}
function clickRemoveUser(Tk)
{
    if (confirm('Toàn bộ thông tin của người dùng sẽ bị xóa bạn có thật sự muốn?\nNhấn Oke để đồng ý và Hủy để hủy thao tác.')) {
        // alert("Xóa người dùng thành công!")
        $.ajax({
            type: 'POST',
            url: '/removeUser',
            data: "TaiKhoan="+Tk,
            success: function (result) {
                if(result === true)
                {
                    alert("Xóa thành công!");
                    location.reload();
                }
                if(result === false)
                {
                    alert("Xóa thất bại!");
                }
            },
            error: function (result) {
                alert("Đã xảy ra lỗi!" + result);
            }
        });
        // location.reload();
    }
    else {
        alert("Bạn đã hủy thao tác!")
    }
}
// $(document).on('click', 'button#remove-btn', function () {
    
// });
function EmptyValue()
{
    $('div.edit-infor input').each(function () {
        $(this).attr('value', '');
    });
    $('div.edit-infor select').each(function () {
        $(this).removeAttr('selected');
        // $('option:selected', this).removeAttr('selected');
    });
}
function disabled_Tag() {
    $('div.edit-infor input').each(function () {
        $(this).attr('readonly', true);
    });

    // $('input#TaiKhoan').attr('readonly', true);

    $('div.edit-infor select').each(function () {
        $(this).attr('disabled', true);
    });
}
function Undisabled_Tag() {
    // $('div.edit-infor input').each(function () {
    //     // alert($(this).attr('id') === $('#Taikhoan').attr('id'));
    //     if($(this).attr('id') === $('#TaiKhoan').attr('id'))
    //     {
    //     }else{
    //         $(this).removeAttr('readonly');
    //     }
    // });
    $('input#fullname').removeAttr('readonly');
    $('input#Matkhau').removeAttr('readonly');
    $('input#birthday').removeAttr('readonly');
    $('div.edit-infor select').each(function () {
        $(this).removeAttr('disabled');
    });
}


function changeStatusShowtoHide(mahd,event){
    event.stopPropagation();
    if (confirm("Chuyển trạng thái bài viết thành ĐÃ ẨN. Bạn có muốn không?\nNhấn Oke để đồng ý và Hủy để hủy bỏ thao tác")) {
        // $(this).removeClass('btn-show');
        // $(this).addClass('btn-hide');
        // $(this).attr('id', 'btn-hide');
        // $(this).text("Đã ẩn");
        // alert("Chuyển đổi thành công!\nTrạng thái bài viết hiện tại là ĐANG HIỂN THỊ");
        $.ajax({
            type: 'POST',
            url: '/changeStatusQA',
            data: "status="+false+"&Mahoidap="+Number(mahd),
            success: function (result) {
                if(result === true)
                {
                    alert("Chuyển đổi trạng thái bài viết thành công!\nTrạng thái bài viết hiện tại là ĐÃ ẨN");
                    location.reload();
                }
                if(result === false)
                {
                    alert("Chuyển trạng thái bài viết thất bại!");
                }
            },
            error: function (result) {
                alert("Đã xảy ra lỗi!" + result);
            }
        });
    } else {
        alert("Đã hủy thao tác!");
    }
}
function changeStatusHidetoShow(mahd,event){
    event.stopPropagation();
    if (confirm("Chuyển trạng thái bài viết thành ĐANG HIỂN THỊ. Bạn có muốn không?\nNhấn Oke để đồng ý và Hủy để hủy bỏ thao tác")) {
        // $(this).removeClass('btn-show');
        // $(this).addClass('btn-hide');
        // $(this).attr('id', 'btn-hide');
        // $(this).text("Đã ẩn");
        // alert("Chuyển đổi thành công!\nTrạng thái bài viết hiện tại là ĐANG HIỂN THỊ");
        $.ajax({
            type: 'POST',
            url: '/changeStatusQA',
            data: "status="+true+"&Mahoidap="+Number(mahd),
            success: function (result) {
                if(result === true)
                {
                    alert("Chuyển đổi trạng thái bài viết thành công!\nTrạng thái bài viết hiện tại là ĐANG HIỂN THỊ");
                    location.reload();
                }
                if(result === false)
                {
                    alert("Chuyển trạng thái bài viết thất bại!");
                }
            },
            error: function (result) {
                alert("Đã xảy ra lỗi!" + result);
            }
        });
    } else {
        alert("Đã hủy thao tác!");
    }
}
// $(document).on('click', 'button#btn-hide', function (e) {
//     e.stopPropagation();
//     if (confirm("Chuyển trạng thái bài viết thành ĐANG HIỂN THỊ. Bạn có muốn không?\nNhấn Oke để đồng ý và Hủy để hủy bỏ thao tác")) {
//         $(this).removeClass('btn-hide');
//         $(this).addClass('btn-show');
//         $(this).attr('id', 'btn-show');
//         $(this).text("Đang hiển thị");
//         alert("Chuyển đổi thành công!\nTrạng thái bài viết hiện tại là ĐÃ ẨN");
//     } else {
//         alert("Đã hủy thao tác!");
//     }

// });

// $(document).on('click', 'button#btn-remove-qa', function () {
//     if (confirm('Toàn bộ thông tin về câu hỏi sẽ bị xóa bạn có thật sự muốn?\nNhấn Oke để đồng ý và Hủy để hủy thao tác.')) {
//         alert("Câu hỏi đã được xóa!")
//         location.reload();
//     }
//     else {
//         alert("Bạn đã hủy thao tác!")
//     }
// }); 


$(document).on('click','#confirm-addUser',function(){
    var fullname = String($('input#fullname').val());
    var mk = String($('input#Matkhau').val());
    var birth = String($('input#birthday').val());
    var tk = String($('input#Taikhoan').val());
    var text = String($('h2#text-mess-user').text());
    var loaitk = Number($('input#loaitk').val());
    // alert(Number(loaitk))
    if(((fullname === null || fullname === "") || (mk === null || mk === "") || (birth === null || birth === "")
    || (tk === null || tk === "")))
    {
        if(Number(loaitk) === 1 || loaitk === NaN)
        {
            alert("Vui lòng không bỏ trống các trường thông tin!");
        }
    }else{
        var formData = new FormData();
        formData.append('TaiKhoan',$('input#Taikhoan').val()); // 
    
        formData.append('HoTen', $('input#fullname').val());
        formData.append('MatKhau', $('input#Matkhau').val());
        formData.append('SinhNhat', $('input#birthday').val());
        formData.append('VaiTro', $('#listvaitro :selected').val());
        formData.append('GioiTinh', $('#listgender :selected').val());
        formData.append('NgheNghiep', $('#listjob :selected').val());
        if(text === "Thêm mới")
        {
            $.ajax({
                type: 'POST',
                processData: false,  // tell jQuery not to process the data
                contentType: false,
                url: '/insertUser',
                data: formData,
                success: function (result) {
                    if(String(result) === "1")
                    {
                        alert("Thêm thành công!");
                        location.reload();
                    }
                    if(String(result) === "2")
                    {
                        alert("Thêm thất bại!"+result);
                    }
                    if(String(result) === "0")
                    {
                        $('input#Taikhoan').focus();
                        alert("Tài khoản đã tồn tại.\nVui lòng chọn tài khoản khác.");
                    }
                },
                error: function (result) {
                    alert("Đã xảy ra lỗi!" + result);
                }
            });
        }
        if(text === "Chỉnh sửa"){
            $.ajax({
                type: 'POST',
                processData: false,  // tell jQuery not to process the data
                contentType: false,
                url: '/updateUser',
                data: formData,
                success: function (result) {
                    if(String(result) === "1")
                    {
                        alert("Cập nhật thành công!");
                        location.reload();
                    }
                    if(String(result) === "2")
                    {
                        alert("Cập nhật thất bại!"+result);
                    }
                    // if(String(result) === "0")
                    // {
                    //     $('input#Taikhoan').focus();
                    //     alert("Tài khoản đã tồn tại.\nVui lòng chọn tài khoản khác.");
                    // }
                },
                error: function (result) {
                    alert("Đã xảy ra lỗi!" + result);
                }
            });
        }
        
    }
    
});

// QA
function showDetailsQA(mahd){
    $.ajax({
        type: 'POST',
        url: '/showDetailsQA',
        data: "MaHD="+Number(mahd),
        success: function (result) {
            $('div#div-replace-qa').replaceWith(result);
        },
        error: function (result) {
            alert("Đã xảy ra lỗi!" + result);
        }
    });
}

function removeQA(maqa)
{
    if (confirm('Toàn bộ thông tin về câu hỏi sẽ bị xóa bạn có thật sự muốn?\nNhấn Oke để đồng ý và Hủy để hủy thao tác.')) {
        $.ajax({
            type: 'POST',
            url: '/removeQA',
            data: "Mahoidap="+Number(maqa),
            success: function (result) {
                if(result === true)
                {
                    alert("Bài đăng đã được xóa!");
                    location.reload();
                }
                if(result === false)
                {
                    alert("Xóa thất bại!");
                }
            },
            error: function (result) {
                alert("Đã xảy ra lỗi!" + result);
            }
        });
    }
    else {
        alert("Bạn đã hủy thao tác!")
    }
}
// TT
function showDetailsNews(matt){
    $.ajax({
        type: 'POST',
        url: '/showDetailsNews',
        data: "MaTT="+Number(matt),
        success: function (result) {
            $('div#replaceNewsDetails').replaceWith(result);
        },
        error: function (result) {
            alert("Đã xảy ra lỗi!" + result);
        }
    });
}
function RemoveNews(matt)
{
    if (confirm('Toàn bộ thông tin về tin tức này sẽ bị xóa bạn có thật sự muốn?\nNhấn Oke để đồng ý và Hủy để hủy thao tác.')) {
        // alert("Tin tức đã được xóa!");
        // location.reload();
        $.ajax({
            type: 'POST',
            url: '/removeNews',
            data: "MaTT="+Number(matt),
            success: function (result) {
                if(result === true)
                {
                    alert("Tin tức đã được xóa!");
                    location.reload();
                }
                if(result === false)
                {
                    alert("Xóa thất bại!");
                }
            },
            error: function (result) {
                alert("Đã xảy ra lỗi!" + result);
            }
        });

    }
    else {
        alert("Bạn đã hủy thao tác!")
    }
}