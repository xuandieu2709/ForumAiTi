 // Follow
 $(document).on('click','#btn-unfollow',function(){
    var user = $('input#userText').val();
    if(confirm("Bạn đang yêu cầu hủy theo dõi thành viên này.\nXin lưu ý: nếu bạn xác nhận toàn bộ thông tin về cuộc trò chuyện giữa bạn và người này cũng sẽ bị xóa.\nNhấn OK để đồng ý và Hủy để hủy bỏ thao tác."))
    {
        $.ajax({
            type: 'POST',
            url: '/unfollow',
            data: "TaiKhoan="+user,
            success: function (result) {
                alert(result)
                if(result === true)
                {
                $('#btn-unfollow').text(" Theo dõi");
                // $('#btn-follow').appendChild('');
                $('#btn-unfollow').attr('id','btn-unfollow');
                $('#btn-follow').prepend("<i class='fa fa-plus-square' aria-hidden='true'></i>");
                alert("Bạn đã bỏ theo dõi người này");
                }else{
                    alert("Đã xảy ra lỗi!\nVui lòng thử lại sau.");
                }
            },
            error: function () {
                alert("Đã xảy ra lỗi!\nVui lòng thử lại sau.");
            }
        });
    }else
    {
    }
});
$(document).on('click','#btn-follow',function(){
    var user = $('input#userText').val();
    $.ajax({
        type: 'POST',
        // processData: false,  // tell jQuery not to process the data
        // contentType: false,
        url: '/follow',
        data: "TaiKhoan="+user,
        success: function (result) {
            // alert(result)
            if(result === true)
            {
            $('#btn-follow').text(" Bỏ theo dõi");
            // $('#btn-follow').appendChild('');
            $('#btn-follow').attr('id','btn-unfollow');
            $('#btn-unfollow').prepend("<i class='fa fa-minus-square' aria-hidden='true'></i>");
            alert("Bạn đang dõi người này");
            }else{
                alert("Đã xảy ra lỗi!\nVui lòng thử lại sau.");
            }
        },
        error: function (result) {
            alert("Đã xảy ra lỗi!\nVui lòng thử lại sau.");
        }
    });
});