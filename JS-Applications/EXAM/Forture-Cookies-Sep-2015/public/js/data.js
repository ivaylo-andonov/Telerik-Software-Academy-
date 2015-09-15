var data = (function () {

    const USERNAME_STORAGE_KEY = 'username-key',
        AUTH_KEY_STORAGE_KEY = 'x-auth-key';

    function userLogin(user) {
        var primi = new Promise(function (resolve, reject) {
            var reqUser = {
                username: user.username,
                passHash: CryptoJS.SHA1(user.password).toString()
            };
            $.ajax({
                url: 'api/auth',
                method: 'PUT',
                contentType: 'application/json',
                data: JSON.stringify(reqUser),
                success: function (user) {
                    localStorage.setItem(USERNAME_STORAGE_KEY, user.result.username);
                    localStorage.setItem(AUTH_KEY_STORAGE_KEY, user.result.authKey);
                    resolve(user);
                }
            });
        });
        return primi;
    }

    function userRegister(user) {
        var prom = new Promise(function (resolve, reject) {
            var reqUser = {
                username: user.username,
                passHash: CryptoJS.SHA1(user.password).toString()
            };
            $.ajax({
                url: 'api/users',
                method: 'POST',
                data: JSON.stringify(reqUser),
                contentType: 'application/json',
                success: function (user) {
                    //localStorage.setItem(USERNAME_STORAGE_KEY, user.result.username);
                    //localStorage.setItem(AUTH_KEY_STORAGE_KEY, user.result.authKey);
                    resolve(user);
                }
            });
        });
        return prom;
    }

    function userLogout() {
        var promis = new Promise(function (resolve, reject) {
            localStorage.removeItem(AUTH_KEY_STORAGE_KEY);
            localStorage.removeItem(USERNAME_STORAGE_KEY);
            resolve();
        });

        return promis;
    }

    function returnUsername() {
        var username = USERNAME_STORAGE_KEY;
        return username;
    }

    function getCurrentUser() {
        var username = localStorage.getItem(USERNAME_STORAGE_KEY);
        if (!username) {
            return null;
        }
        return {
            username
        };
    }

    function allCookies() {
        var promise = new Promise(function (resolve, reject) {
            $.getJSON('api/cookies', function (res) {
                res.result = res.result.map(function (cookie) {
                    cookie.postDate = moment(new Date(cookie.shareDate)).fromNow();
                    return cookie;
                });
                resolve(res);
            });
        });
        return promise;
    }

    function cookiesAdd(ctext, ccategory, cimg) {
        var promise = new Promise(function (resolve, reject) {
            var body = {
                text: ctext,
                category: ccategory,
                img: cimg
            };
            console.log(body);
            $.ajax({
                url: 'api/cookies',
                method: 'POST',
                data: JSON.stringify(body),
                headers: {
                    'x-auth-key': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
                },
                contentType: 'application/json',
                success: function (res) {
                    resolve(res);
                },
                error: function(err){
                    toastr.error("No access!")
                }
            })
        });
        return promise;
    }

    function getMyCookie(){
        var promise = new Promise(function (resolve, reject) {
            $.ajax({
                url: 'api/my-cookie',
                method: 'GET',
                headers: {
                    'x-auth-key': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
                },
                contentType: 'application/json',
                success: function (res) {
                    resolve(res);
                },
                error: function(err){
                    toastr.error("No access!")
                }
            })
        });
        return promise;
    }
    //function getUserById(id) {
    //        var userId = "cd8af0ad-7c89-4b74-8d90-d86999e61434";
    //        var users = $.ajax({
    //            url: 'api/users',
    //            method: 'GET',
    //            headers: {
    //                'x-auth-key': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
    //            },
    //            contentType: 'application/json',
    //            success: function (res) {
    //                resolve(res);
    //            }
    //        });
    //        console.log(users);
    //        var user = _.find(users, function (user) {
    //            return user.id === id;
    //        });
    //}

    return {
        users: {
            login: userLogin,
            register: userRegister,
            logout: userLogout,
            current: getCurrentUser,
            username: returnUsername
        },
        cookies: {
            all: allCookies,
            add: cookiesAdd,
            getMyCookie: getMyCookie
        }
    }
}());
