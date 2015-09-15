var loginController = (function () {
    $('#login-btn').click(authentication.login);

    validator.changeNavbar(sessionStorage.currentUser);
})();