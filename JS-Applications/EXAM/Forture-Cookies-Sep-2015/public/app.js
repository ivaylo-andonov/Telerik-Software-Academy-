(function () {

    var sammyApp = Sammy('#content', function () {
        var $content = $('#content');

        this.get('#/', function(){
            this.redirect('#/home');
        });

        this.get('#/home', homeController.all);
        this.get('#/register', usersController.register);
        this.get('#/cookies/add',cookiesController.add);
        this.get('#/my-cookie', myCookie.get2);

        this.get('#/:category', threadsController.all);

    });

    $(function () {
        sammyApp.run('#/');

        if (data.users.current()) {
            $('#btn-login').hide();
            $('#tb-user').hide();
            $('#tb-pass').hide();
            $('#reg-user').hide();
            $('#username-nav').html(localStorage.getItem('username-key'));
            $('#greeting').html(localStorage.getItem('username-key'));
            $('#btn-logout').on('click', function () {
                data.users.logout()
                    .then(function () {
                        location = '#/';
                        document.location.reload(true);
                        toastr.info('Good Buy');

                    });
            });
        } else {
            $('#btn-logout').hide();
            $('#username-nav').hide();
            $('#btn-login').on('click', function () {
                var user = {
                    username: $('#tb-user').val(),
                    password: $('#tb-pass').val()
                };
                data.users.login(user)
                    .then(function () {
                        location = '#/';
                        document.location.reload(true);
                        toastr.success('Hello');
                    });
            });
        }
    });
}());