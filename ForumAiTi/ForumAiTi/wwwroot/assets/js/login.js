$('#password-field').on('input',function(){
    var pass = $('#password-field').val();
    var confirm = $('#password-field1').val();
    regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;
    if(pass === null || pass === "")
    {
        $('input#password-field').css({'outline':'4px solid red'});
    }
    else if(pass !== null && pass !== ""){
        if(pass === confirm)
        {
            if(regex.test(pass) === true)
            {
                $('input#password-field').css({'outline':'4px solid green'});
                $('input#password-field1').css({'outline':'4px solid green'});
                $('#password-field')[0].setCustomValidity("");
            }
            else{
                $('input#password-field').css({'outline':'4px solid #f4a261'});
                $('#password-field')[0].setCustomValidity("Mật khẩu phải tối thiểu tám ký tự, ít nhất một chữ hoa, một chữ thường, một số và một ký tự đặc biệt");
            }
        }
        else{
            $('input#password-field').css({'outline':'4px solid #f4a261'});
        }
    }
});
$('#password-field1').on('input',function(){
    var pass = $('#password-field').val();
    var confirm = $('#password-field1').val();
    regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$/;
    if(confirm === null || confirm === "")
    {
        $('input#password-field1').css({'outline':'4px solid red'});
    }
    else if(confirm !== null && confirm !== ""){
        if(pass === confirm)
        {
            if(regex.test(confirm) === true)
            {
                $('input#password-field1').css({'outline':'4px solid green'});
                $('input#password-field').css({'outline':'4px solid green'});
                $('#password-field1')[0].setCustomValidity("");
            }
            else{
                $('input#password-field1').css({'outline':'4px solid #f4a261'});
                $('#password-field1')[0].setCustomValidity("Mật khẩu phải tối thiểu tám ký tự, ít nhất một chữ hoa, một chữ thường, một số và một ký tự đặc biệt");
            }
        }
        else{
            $('input#password-field1').css({'outline':'4px solid #f4a261'});
        }
    }
});

// 
(function($) {

	"use strict";

	var fullHeight = function() {

		$('.js-fullheight').css('height', 'auto');
		$(window).resize(function(){
			$('.js-fullheight').css('height', 'auto');
		});

	};
	fullHeight();

	$(".toggle-password").click(function() {

	  $(this).toggleClass("fa-eye fa-eye-slash");
	  var input = $($(this).attr("toggle"));
	  if (input.attr("type") == "password") {
	    input.attr("type", "text");
	  } else {
	    input.attr("type", "password");
	  }
	});

	// 
	$('nav .dropdown').hover(function(){
		var $this = $(this);
		$this.addClass('show');
		$this.find('> a').attr('aria-expanded', true);
		$this.find('.dropdown-menu').addClass('show');
	}, function(){
		var $this = $(this);
			$this.removeClass('show');
			$this.find('> a').attr('aria-expanded', false);
			$this.find('.dropdown-menu').removeClass('show');
	});


})(jQuery);


