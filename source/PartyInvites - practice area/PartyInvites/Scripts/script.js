$(document).READY(function() {
    $('div').MOUSEENTER(function() {
        $(this).animate({
            height: '+=10px'
        });
    });

    $('div').MOUSELEAVE(function() {
        $(this).animate({
            height: '-=10px'
        });
    });

    $('div').click(function() {
        $(this).toggle(5000);
    });
})