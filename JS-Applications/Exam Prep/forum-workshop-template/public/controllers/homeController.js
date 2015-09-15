/**
 * Created by Ивайло on 8.9.2015 г..
 */
var homeController = function () {

    function all(context) {
        templates.get('home')
            .then(function (template) {
                context.$element().html(template());
            });
    }

    return {
        all: all
    };
}();

