var authentication = (function () {
    function setSessionStorage(data) {
        sessionStorage.currentUser = (data.username);
        sessionStorage.sessionToken = (data.sessionToken);
        sessionStorage.userId = (data.objectId);
    }

    function authenticationSuccessForLogin(data) {
        location.href = '#/logged';

        $('#logout').show();

        successLogin();

        setSessionStorage(data);
    }

    function successLogin() {
        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": true,
            "positionClass": "toast-top-center",
            "preventDuplicates": false,
            "onclick": null,
            "showDuration": "200",
            "hideDuration": "3000",
            "timeOut": "2000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        };
        toastr.success('Login Succeeded', 'Welcome :)');
    }

    function errorLogin(message) {
        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": true,
            "positionClass": "toast-top-center",
            "preventDuplicates": false,
            "onclick": null,
            "showDuration": "200",
            "hideDuration": "3000",
            "timeOut": "2000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        };
        toastr.error('Please, try again', (typeof message === 'string') ? message: 'Wrong name or password');
    }

    function errorRegister(message) {
        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": true,
            "positionClass": "toast-top-center",
            "preventDuplicates": false,
            "onclick": null,
            "showDuration": "200",
            "hideDuration": "3000",
            "timeOut": "2000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        };
        toastr.error('Please, try again','Missed something')
    }

    function logOutGreeting(){
        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": true,
            "positionClass": "toast-top-center",
            "preventDuplicates": true,
            "onclick": null,
            "showDuration": "200",
            "hideDuration": "3000",
            "timeOut": "2000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        };

        toastr.info('Goodbuy, See you again !');
    }

    function authenticationFailed(error) {
        errorLogin();
    }

    function errorForRegister(error) {
        errorRegister();
        toastr.warning('Please, try again', (typeof message === 'string') ? message : 'Missed something');
    }

    function authenticationSuccessForRegistering() {
        location.href = '#/successRegister';
    }

    function login() {
        var username = $('#usr').val(),
                password = $('#pwd').val();
        try {
            validator.validateUsername(username);
            validator.validatePassword(password);
        } catch (error) {
            errorLogin(error.message);
            return;
        }
        ajaxRequester.login(username, password, authenticationSuccessForLogin, errorLogin);
    }

    function register() {
        var username = $('#username').val(),
            password = $('#pass').val(),
            confirmationPassword = $('#pass-repeat').val();
        try {
            validator.validateUsername(username);
            validator.validatePassword(password);
            validator.validatePasswordConfirmation(password, confirmationPassword);
        } catch (error) {
            errorRegister(error.message);
            return;
        }
        ajaxRequester.register(username, password, authenticationSuccessForRegistering, errorRegister);
    }

    function logout() {
        delete sessionStorage.currentUser;
        delete sessionStorage.sessionToken;
        delete sessionStorage.userId;
        delete sessionStorage.currentAddedVideo;

        logOutGreeting();
    }
    return {
        login: login,
        register: register,
        logout: logout
    };
}());
