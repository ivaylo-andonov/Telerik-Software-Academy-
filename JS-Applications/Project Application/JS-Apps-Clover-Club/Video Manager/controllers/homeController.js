var homeController = (function() {
    $('#logout').on('click', authentication.logout);
    
    validator.changeNavbar(sessionStorage.currentUser);
})();