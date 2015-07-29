(function ($) {
    // Menu Functions
    $(document).ready(function () {
        $('#menuToggle').click(function (e) {
            var $parent = $(this).parent('nav');
            $parent.toggleClass("open");
            var navState = $parent.hasClass('open') ? "hide" : "show";
            $(this).attr("title", navState + " navigation");
            // Set the timeout to the animation length in the CSS.
            setTimeout(function () {
                $('#menuToggle > span').toggleClass("navClosed").toggleClass("navOpen");
            }, 100);
            e.preventDefault();
        });

        $('nav a').click(function(){
            if (!$(this).is('#menuToggle')) {
                $('.selected').removeClass('selected');
                $(this).addClass('selected');
            }
        });
    });
})(jQuery);