
$(document).ready(function () {
    $("i#hidepass").click(function () {

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
    $('h2#text-mess-user').text('Thêm mới');
    Undisabled_Tag();
});
$(document).on('click', 'tbody > tr', function () {
    $('div#admin-left').addClass('col-md-8 col-lg-8 ');
    $('div#admin-right').show();
    // $('h2#text-mess-user').append('<i class="fa fa-television" aria-hidden="true"></i>');
    $('h2#text-mess-user').text('Thông tin');
    $('#div-edit-remove').show();
    $('#div-cancel-confirm').hide();
    disabled_Tag();
}); //edit-btn
$(document).on('click', 'button#edit-btn', function () {
    $('#div-cancel-confirm').show();
    $('h2#text-mess-user').text('Chỉnh sửa');
    Undisabled_Tag();
});
$(document).on('click', 'button#remove-btn', function () {
    if (confirm('Toàn bộ thông tin của người dùng sẽ bị xóa bạn có thật sự muốn?\nNhấn Oke để đồng ý và Hủy để hủy thao tác.')) {
        alert("Xóa người dùng thành công!")
        location.reload();
    }
    else {
        alert("Bạn đã hủy thao tác!")
    }
});
function disabled_Tag() {
    $('div.edit-infor input').each(function () {
        $(this).attr('readonly', true);
    });
    $('div.edit-infor select').each(function () {
        $(this).attr('disabled', true);
    });
}
function Undisabled_Tag() {
    $('div.edit-infor input').each(function () {
        $(this).removeAttr('readonly');
    });
    $('div.edit-infor select').each(function () {
        $(this).removeAttr('disabled');
    });
}

$(document).on('click', 'button#btn-show', function (e) {
    e.stopPropagation();
    if (confirm("Chuyển trạng thái bài viết thành ĐÃ ẨN. Bạn có muốn không?\nNhấn Oke để đồng ý và Hủy để hủy bỏ thao tác")) {
        $(this).removeClass('btn-show');
        $(this).addClass('btn-hide');
        $(this).attr('id', 'btn-hide');
        $(this).text("Đã ẩn");
        alert("Chuyển đổi thành công!\nTrạng thái bài viết hiện tại là ĐANG HIỂN THỊ");
    } else {
        alert("Đã hủy thao tác!");
    }

});
$(document).on('click', 'button#btn-hide', function (e) {
    e.stopPropagation();
    if (confirm("Chuyển trạng thái bài viết thành ĐANG HIỂN THỊ. Bạn có muốn không?\nNhấn Oke để đồng ý và Hủy để hủy bỏ thao tác")) {
        $(this).removeClass('btn-hide');
        $(this).addClass('btn-show');
        $(this).attr('id', 'btn-show');
        $(this).text("Đang hiển thị");
        alert("Chuyển đổi thành công!\nTrạng thái bài viết hiện tại là ĐÃ ẨN");
    } else {
        alert("Đã hủy thao tác!");
    }

});

$(document).on('click', 'button#btn-remove-qa', function () {
    if (confirm('Toàn bộ thông tin về câu hỏi sẽ bị xóa bạn có thật sự muốn?\nNhấn Oke để đồng ý và Hủy để hủy thao tác.')) {
        alert("Câu hỏi đã được xóa!")
        location.reload();
    }
    else {
        alert("Bạn đã hủy thao tác!")
    }
}); 
$(document).on('click', 'button#remove-btn1', function () {
    if (confirm('Toàn bộ thông tin về tin tức này sẽ bị xóa bạn có thật sự muốn?\nNhấn Oke để đồng ý và Hủy để hủy thao tác.')) {
        alert("Tin tức đã được xóa!")
        location.reload();
    }
    else {
        alert("Bạn đã hủy thao tác!")
    }
});