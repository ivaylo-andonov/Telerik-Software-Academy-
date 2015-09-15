/**
 * Created by Ивайло on 8.9.2015 г..
 */
var data = (function () {

    const USERNAME_STORAGE_KEY = 'username-key',
        AUTH_KEY_STORAGE_KEY = 'auth-key-key';

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
                    localStorage.setItem(USERNAME_STORAGE_KEY, user.username);
                    localStorage.setItem(AUTH_KEY_STORAGE_KEY, user.authKey);
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
                    localStorage.setItem(USERNAME_STORAGE_KEY, user.username);
                    localStorage.setItem(AUTH_KEY_STORAGE_KEY, user.authKey);
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



    function threadsGet() {
        var promise = new Promise(function (resolve, reject) {
            $.getJSON('api/threads', function (res) {
                res.result = res.result.map(function(thread){
                    thread.postDate = moment(new Date(thread.postDate)).fromNow();
                    return thread;
                });
                resolve(res);
            });
        });
        return promise;
    }

    function threadsAdd(title) {
        var promise = new Promise(function (resolve, reject) {
            var body = {
                title
            };
            console.log(body);
            $.ajax({
                url: 'api/threads',
                method: 'POST',
                data: JSON.stringify(body),
                headers: {
                    'x-authkey': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
                },
                contentType: 'application/json',
                success: function (res) {
                    resolve(res);
                }
            })
        });
        return promise;
    }

    function threadById(id) {
        var promise = new Promise(function (resolve, reject) {
            $.getJSON("api/threads/" + id, function (res) {
                resolve(res);
            });
        });
        return promise;

    }

    function threadsAddMessage(threadId, message) {
        var qpromise = new Promise(function(resolve, reject) {
            $.ajax({
                url: "api/threads/" + threadId + "/messages",
                method: 'POST',
                data: JSON.stringify(message),
                contentType: 'application/json',
                headers: {
                    'x-authkey': localStorage.getItem(AUTH_KEY_STORAGE_KEY)
                },
                success: function(res) {
                    resolve(res);
                }
            });
        });
        return qpromise;
    }

    function usersFind() {

    }


    return {
        users: {
            login: userLogin,
            register: userRegister,
            logout: userLogout,
            find: usersFind,
            current: getCurrentUser,
            username: returnUsername
        },
        threads: {
            get: threadsGet,
            add: threadsAdd,
            getById: threadById,
            addMessage: threadsAddMessage
        }
    };
}());

