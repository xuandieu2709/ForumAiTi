// var fileTag = document.getElementById("upload"),
//     preview = document.getElementsByClassName("garellyImages");

// fileTag.addEventListener("change", function () {
//     changeImage(this);
// });

// function changeImage(input) {
//     var reader;

//     if (input.files && input.files[0]) {
//         reader = new FileReader();
//         reader.onload = function (e) {
//             if ($('img#img0').length > 0) {
//                 $('img#img0').attr('src', e.target.result);
//             }
//             else {
//                 $('.garellyImages').append('<img id="img0" src="' + e.target.result + '"/><i id="img0" class="fa fa-times" aria-hidden="true"></i>');
//             }
//             //preview.setAttribute('src', e.target.result);
//         }
//         reader.readAsDataURL(input.files[0]);
//     }
// }
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
// function xhrRequest() {
//     console.log(this.status);
//     alert(this.status)
// }
// function getReq(url) {
//     var oReq = new XMLHttpRequest();
//     oReq.addEventListener("load", xhrRequest);
//     oReq.open("POST", "/comment_qa");
//     oReq.send();
// }
// $(document).ready(function () {
//     $("#loadcomment").slice(0, 5).show();

// });
  // $(document).on("button#load-more","click", function(e){
    //   e.preventDefault();
    //   $("div#loadcomment:hidden").slice(0, 5).slideDown();
    //   if($("button#load-more:hidden").length == 0) {
    //     $("button#load-more").text("No Content").addClass("noContent");
    //   }
    // });
// $(document).ready(function () {
//     size_li = $("div#loadcomment .comment").size();
//     x=5;
//     $('#myList li:lt('+x+')').show();
//     $('#loadMore').click(function () {
//         x= (x+5 <= size_li) ? x+5 : size_li;
//         $('#myList li:lt('+x+')').show();
//     });
//     $('#showLess').click(function () {
//         x=(x-5<0) ? 3 : x-5;
//         $('#myList li').not(':lt('+x+')').hide();
//     });
// });

// $(function(){
//     $("div#loadcomment .comment").slice(0, 5).show(); // select the first ten
//     $("button#load-more").click(function(e){ // click event for load more
//         e.preventDefault();
//         $("div#loadcomment .comment:hidden").slice(0, 5).show(); // select next 10 hidden divs and show them
//         if($("div#loadcomment .comment:hidden").length == 0){ // check if any hidden divs still exist
//             alert("No more divs"); // alert if there are none left
//         }
//     });
// });