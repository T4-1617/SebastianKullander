$(document).ready(function () {

    $(window).bind('scroll', function (e) {
        parallaxScroll();
    });

    function parallaxScroll() {
        var scrolled = $(window).scrollTop();
        $('#parallax1').css('top', (0 - (scrolled * .25)) + 'px');
        $('#parallax2').css('top', (0 - (scrolled * 0.5)) + 'px');
        $('#parallax3').css('top', (0 - (scrolled * 0.75)) + 'px');
        $('#parallax4').css('top', (0 - (scrolled * 2)) + 'px');
        $('#parallax5').css('top', (0 - (scrolled * 4)) + 'px');
    }
}
)