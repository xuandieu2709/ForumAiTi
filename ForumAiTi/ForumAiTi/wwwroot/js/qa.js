
$(function () {
    // Multiple images preview in browser
    var imagesPreview = function (input) {
        if (input.files) {
            var reader = new FileReader();
            reader.onload = function (e) {
                if ($('img#img0').length > 0) {
                    $('img#img0').attr('src', e.target.result);
                }
                else {
                    $('.garellyImages').append('<img id="img0" src="' + e.target.result + '"/><i id="img0" class="fa fa-times" aria-hidden="true"></i>');
                }
            }
            reader.readAsDataURL(input.files[0]);
        }
    };
    $(document).on('change', 'input[id="upload"]', function () {
        var id = $(this).attr('id');
        id = id.substring(6, id.length);
        if ($('input#upload' + id)[0].files[0]) {
            imagesPreview(this);
        } else {
            $('.garellyImages').empty();
            $('input#upload').val("");
        }
    });
});
$(document).on('click', 'i#img0', function () {
    $('.garellyImages').empty();
    $('input#upload').val("");
});
$(document).on('click', 'button#btnComment', function (event) {
    event.preventDefault();
    var comment = $('textarea#comment').val();
    if((!comment && !$('input#upload')[0].files[0]))
    {
        alert("Vui lòng nhập bình luận hoặc chọn hình ảnh.")
        // comment was empty string, false, 0, null, undefined, ...
        $('textarea#comment')[0].setCustomValidity("Vui lòng nhập thông tin vào trường bình luận");
    }else{
    $('textarea#comment')[0].setCustomValidity("");
    var ma = Number($('p#MaHD').text());
    var formData = new FormData();
    formData.append('file', $('input#upload')[0].files[0]); // myFile is the input type="file" control
    formData.append('ma', ma);
    formData.append('comment', comment);
    $.ajax({
        type: 'POST',
        processData: false,  // tell jQuery not to process the data
        contentType: false,
        url: '/comment_qa',
        data: formData,
        success: function (result) {
            $('div#section_comment').replaceWith(result);
        },
        error: function (result) {
            // getReq(document.URL);
            if(Number(result.status) === 401)
            {
                window.location.href = "/login?ReturnUrl=%2F";
            }
            else{
            alert("Đã có lỗi xảy ra!");
            }
            // console.log(result + result.status);
        }
    });
    }
});

//
