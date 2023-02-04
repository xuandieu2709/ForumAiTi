// var modal = document.getElementById("myModal");

// // Get the image and insert it inside the modal - use its "alt" text as a caption
// var modalImg = document.getElementById("img01");
// var captionText = document.getElementById("caption");

$(document).on('click','img',function(){
    $('#myModal1').show();
    $('#img01').attr('src',this.src);
    // $('#caption').text() = this.alt;
});
$(document).on('click','.close',function(){
    $('#myModal1').hide();
  });