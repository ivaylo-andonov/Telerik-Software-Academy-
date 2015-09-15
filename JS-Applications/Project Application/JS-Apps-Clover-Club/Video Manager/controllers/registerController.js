var registerController = (function () {
    $('#register-form-btn').click(authentication.register);

    validator.changeNavbar(sessionStorage.currentUser);
})();