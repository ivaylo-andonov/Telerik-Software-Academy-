(function () {

    var sammyApp = Sammy('#content', function () {
        var $content = $('#content');

        this.get('#/', function(){
                this.redirect('#/home');
            });

        this.get('#/home', homeController.all);
        this.get('#/register', usersController.register);
        this.get('#/threads', threadsController.all);
        this.get('#/threads/add', threadsController.add);
        this.get('#/threads/:id', threadsController.details);
        this.get('#/threads/:id/messages/add', threadsController.addMessage);

        this.get('#/users', usersController.all);
        this.get('#/users/:id', usersController.register);
        this.get('#/notifications', notificationsController.all);
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
