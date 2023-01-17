// ########### ADD_NEWS.HTML ##############
// change datetime
$(document).ready(function () {
    $('.js-example-basic-multiple').select2({
        maximumSelectionLength: 3,
        language: "vi"
    });
    $('#input-datetime').val(new Date().toISOString().slice(0, 10));
    $('datetime').text($('#input-datetime').val());
    // change demo
    $('input#input-title').on('input', function () {
        var text = $(this).val();
        $('#text-title').text(text);
    });
    $('#input-datetime').on('change', function () {
        var text = $('#input-datetime').val();
        $('datetime').text(text);
    });
    $('textarea#content').on('keyup', function () {
        var text = $(this).val();
        $('#text-content').text(text);
    });
    $('select#listcategory').on('change', function () {
        var arr = $('select#listcategory :selected').toArray().map(x => $(x).text());
        console.log(arr);
        $('p.details-list').empty();
        for (i = 0; i < arr.length; i++) {
            var text = arr[i];
            console.log(text)
            $('p.details-list').append('<a href="#">' + text + '</a>');
        }
    });

});
// Remove btn
$(document).on('click', '#btn-add', function () {
    var count = 0;
    $('div[id*="divpost"]').each(function () {
        count++;
    });
    var text = '<div class="ask-post row" id="divpost' + count + '">'
        + '<div class="col-12">'
        + '<input type="file" accept="image/*" hidden name="" id="upload' + count + '">'
        + '<label for="upload' + count + '"><i class="fa fa-image" aria-hidden="true"></i></label>'
        + '<textarea name="" id="content-des' + count + '" required></textarea>'
        + '<div class="garelly' + count + '"></div>'
        + '</div>'
        + '<div class="col-6 mt-2 mb-2"><button type="button" class="btn btn-remove' + count + '" id="btn-remove' + count + '">Xóa đoạn văn</button></div>'
        + '</div>'
    $('div.div-paragraph').append(text);
    var text1 = '<div class="news-paragraph p-0" id="paragraph' + count + '">'
        + '<p class="news-paragraph-content" id="content-des' + count + '">'
        + '</p>'
        + '<img id="imagges' + count + '" alt="">'
        + '<p class="paragraph-note-img" id="imagges' + count + '"></p>'
        + '</div>'
    $('#div-image-preview').append(text1)
});
$(document).on('click', 'button[id*="btn-remove"]', function () {
    var id = $(this).attr('id');
    id = id.substring(10, id.length);
    $('#divpost' + id).remove();
    $('#paragraph' + id).remove();
});
// CHNAGE TEXT
$(document).on('input', 'input[id*="imagges"]', function () {
    var id = $(this).attr('id');
    $('p#' + id).text($(this).val());
});
$(document).on('keyup', 'textarea[id*="content-des"]', function () {
    var id = $(this).attr('id');
    $('p#' + id).text($(this).val());
});
// upload file
$(function () {
    // Multiple images preview in browser
    var imagesPreview = function (input, placeToInsertImagePreview, id) {

        if (input.files) {
            var reader = new FileReader();
            reader.onload = function (event) {
                if ($('div.garelly' + id + ' img#imagges' + id + '').length > 0) {
                    // $('div.garelly' + id + ' img#imagges' + id + '').attr('src', event.target.result);
                    $('img#imagges' + id + '').attr('src', event.target.result);
                }
                else {
                    $($.parseHTML('<img id="imagges' + id + '">')).attr('src', event.target.result).appendTo(placeToInsertImagePreview);
                    $('div.garelly' + id + ' img#imagges' + id + '')
                        .after('<i class="fa fa-times" aria-hidden="true" id="imagges' + id + '"></i>'
                            + '<input placeholder="Chú thích hình ảnh rất cần đấy bạn nhé..." type="text" id="imagges' + id + '" />');
                    $('img#imagges' + id).attr('src', event.target.result);
                    // preview
                    var text = '<img src="'+event.target.result+'" id="imagges' + id + '" alt="">'
                        + '<p class="paragraph-note-img" id="imagges' + id + '"></p>';
                        if($('#paragraph' + id + ' img#imagges' + id + '').length <= 0)
                        {
                        $('p#content-des' + id).after(text);
                        }
                }

            }

            reader.readAsDataURL(input.files[0]);
        }
    };
    $(document).on('change', 'input[id*="upload"]', function () {
        var id = $(this).attr('id');
        id = id.substring(6, id.length);
        imagesPreview(this, 'div.garelly' + id, id);
    });
    // remove image
    $(document).on('click', 'i[id*="imagges"]', function () {
        var id = $(this).attr('id');
        id = id.substring(7, id.length);
        $('div.garelly' + id + ' img#imagges' + id + '').remove();
        $(this).remove();
        $('input#imagges' + id).remove();
        $('img#imagges' + id).remove();
        $('p#' + $(this).attr('id')).remove();
    });
});

// img content
$(function () {
    // Multiple images preview in browser
    var imagesPreview = function (input, placeToInsertImagePreview) {
        if (input.files) {
            var reader = new FileReader();
            reader.onload = function (event) {
                    // $('div.garelly' + id + ' img#imagges' + id + '').attr('src', event.target.result);
                    $('img#img-content').attr('src', event.target.result);
            }
            reader.readAsDataURL(input.files[0]);
        }
    };
    $(document).on('change', 'input[id="changeimg"]', function () {
        imagesPreview(this);
    });
});
