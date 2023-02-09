$(function () {
    // Multiple images preview in browser
    var imagesPreview = function (input,id) {
        if (input.files) {
            var reader = new FileReader();
            reader.onload = function (e) {
                if ($('img#img'+id).length > 0) {
                    $('img#img'+id).attr('src', e.target.result);
                }
                else {
                    $('.garellyImages'+id).append('<img id="img'+id+'" src="' + e.target.result + '"/><i id="img'+id+'" class="fa fa-times" aria-hidden="true"></i>');
                }
            }
            reader.readAsDataURL(input.files[0]);
        }
    };
    $(document).on('change', 'input[id*="upload"]', function () {
        var id = $(this).attr('id');
        id = id.substring(6, id.length);
        if ($('input#upload' + id)[0].files[0]) {
            imagesPreview(this,id);
        } else {
            $('.garellyImages'+id).empty();
            $('input#upload'+id).val("");
        }
    });
});
$(document).on('click', 'i[id*="img"]', function () {
    var id = $(this).attr('id');
    id = id.substring(3,id.length);
    $('.garellyImages'+id).empty();
    $('input#upload'+id).val("");
});

//
function clickComment(id,event){
    var val = $(this).attr('id');
    var subid = id.substring(10,id.length);
    alert(subid);
    var comment = $('textarea#comment'+subid).val();
    if((!comment && !$('input#upload'+subid)[0].files[0]))
    {
        alert("Vui lòng nhập bình luận hoặc chọn hình ảnh.");
        $('textarea#comment'+subid)[0].setCustomValidity("Vui lòng nhập thông tin vào trường bình luận");
    }else{
    $('textarea#comment'+subid)[0].setCustomValidity("");
    var ma = Number($('p#MaHD'+subid).text());
    var formData = new FormData();
    formData.append('file', $('input#upload'+subid)[0].files[0]); // myFile is the input type="file" control
    formData.append('ma', ma);
    formData.append('comment', comment);
    $.ajax({
        type: 'POST',
        processData: false,  // tell jQuery not to process the data
        contentType: false,
        url: '/comment_qaa',
        data: formData,
        success: function (result) {
            $('div#section_comment'+subid).replaceWith(result);
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
}
$('button[id*="btnComment"]').on('click' , function (event) {
    
});
