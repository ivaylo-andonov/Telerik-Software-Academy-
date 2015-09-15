function sammy() {
    var sammyApp = Sammy('#content', function () {

        this.get('#/home', function () {
            $('#content').load('./partials/home.partial.html');
        });

        this.get('#/contacts', function () {
            $('#content').load('./partials/contacts.partial.html');
        });

        this.get('#/login', function () {
            $('#content').load('./partials/login.partial.html');
        });

        this.get('#/register', function () {
            $('#content').load('./partials/register.partial.html');
        });

        this.get('#/logged', function () {
            $('#content').load('./partials/logged.partial.html');

        });

        this.get('#/successRegister', function () {
            $('#content').load('./partials/successRegister.partial.html');
        });
    });

    $(function () {
        sammyApp.run('#/home');
    });
}
sammy();
