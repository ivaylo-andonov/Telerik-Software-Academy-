var myCookie = function () {

    function getMyCookie(context){
        var cookie;
        data.cookies.getMyCookie()
            .then(function (resThreads) {
                cookie = resThreads.result;
                return templates.get('myCookie');
            })
            .then(function (template) {
                context.$element().html(template(cookie));
                console.log(cookie);
            });
    }
    return {
        get2:getMyCookie
    };
}();