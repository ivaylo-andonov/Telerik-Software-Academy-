var usersController = function() {

    var usernameRegex = /^[a-zA-Z0-9]+$/;

    function register(context) {
        templates.get('register')
            .then(function(template) {
                context.$element().html(template());

                $('#register-form-btn').on('click', function() {
                    var user = {
                        username: $('#username').val(),
                        password: $('#pass').val()
                    };

                    var valid = usernameRegex.test(user.username);

                    if(valid && typeof user.username === "string" && user.username.length >= 6 && user.username.length <= 30){
                        data.users.register(user)
                            .then(function() {
                                context.redirect('#/home');
                                toastr.success('Successed registered.Now you can log in :)');
                            });
                    }
                    else{
                        toastr.warning('Invalid characters for username.Try again.')
                    }

                });
            });
    }
    return {
        register: register
    };
}();