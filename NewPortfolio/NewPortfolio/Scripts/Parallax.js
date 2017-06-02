$(document).ready(function () {

    $(window).bind('scroll', function (e) {
        parallaxScroll();
    });

    function parallaxScroll() {
        var scrolled = $(window).scrollTop();
        $('#parallax-bg1').css('top', (0 - (scrolled * .25)) + 'px');
        $('#parallax-bg2').css('top', (0 - (scrolled * 0.5)) + 'px');
        $('#parallax-bg3').css('top', (0 - (scrolled * 0.75)) + 'px');
        $('#parallax-bg4').css('top', (0 - (scrolled * 2)) + 'px');
    }
}
)