var cookiesController = function () {

    var validUrl = /[-a-zA-Z0-9@:%_\+.~#?&//=]{2,256}\.[a-z]{2,4}\b(\/[-a-zA-Z0-9@:%_\+.~#?&//=]*)?/gi;

    function add(context) {
        templates.get('addCookie')
            .then(function (template) {
                context.$element().html(template());
                $('#btn-add-cookie').on('click', function () {
                    var text = $('#tb-text').val();
                    var category = $('#tb-category').val();
                    var img = $('#tb-img').val();

                    var validURL = validUrl.test(img.toString());

                    if (validURL && typeof text === "string" && typeof  category === "string"
                        && typeof  img === "string"
                        && text.length >= 6 && text.length <= 30
                        && category.length >= 6
                        && category.length <= 30) {
                        data.cookies.add(text, category, img)
                            .then(function () {
                                context.redirect('#/home');
                                toastr.success('Success new cookie shared:)')

                            });
                    }
                    else {
                        toastr.warning('Invalid data for cookie.Text and category and must be valid strings,with length between 6 and 30.Img url must be valid url.Try again.')
                    }
                });
            });
    }
    return {
        add: add
    };
}();