$('.thumbnails .zoom').click(function (e) {
    e.preventDefault();

    var photo_fullsize = $(this).find('img').attr('src');

    $('.mainimage img').attr('src', photo_fullsize);

});