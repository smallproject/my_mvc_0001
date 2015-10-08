$(document).ready(function() {
    $('div').mouseenter(function() {
        $(this).animate({
            height: '+=10px'
        });
    });

    $('div').mouseleave(function() {
        $(this).animate({
            height: '-=10px'
        });
    });

    $().mouseenter();
    $().mouseleave();

    $("#red").mouseenter(function () {
        $(this).fadeOut(1000);
    });
    $("#red").mouseleave(function() {
        $(this).fadeIn(1000);
    });

    $("#blue").mouseenter(function() {
        $(this).slideUp("slow");
    });
    $("#blue").mouseleave(function() {
        $(this).slideDown("slow");
    });
});