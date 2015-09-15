var homeController = function () {

    function all(context) {
        var threads;
        data.cookies.all()
            .then(function (resThreads) {
                threads = resThreads.result;
                return templates.get('fortuneCookies');
            })
            .then(function (template) {
                context.$element().html(template(threads));
            });
    }

    return {
        all: all
    };
}();