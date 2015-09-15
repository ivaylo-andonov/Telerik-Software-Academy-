var assert = require("assert");
var validator = require('../usersInputValidator.js')
describe('UsersInputValidator', function () {
    describe('validateUsername()', function () {
        it('should throw error when the username is undefined', function () {
            assert.throws(function () {
                validator.validateUsername(undefined);
            });
        });

        it('should throw error when the username is null', function () {
            assert.throws(function () {
                validator.validateUsername(null);
            });
        });

        it('should throw error when the username is empty string', function () {
            assert.throws(function () {
                validator.validateUsername('');
            });
        });

        it('should throw error when the username contains invalid characters(1)', function () {
            assert.throws(function () {
                validator.validateUsername('asdf@fg');
            });
        });

        it('should throw error when the username contains invalid characters(2)', function () {
            assert.throws(function () {
                validator.validateUsername('!asg');
            });
        });

        it('should throw error when the username contains invalid characters(3)', function () {
            assert.throws(function () {
                validator.validateUsername('asdfg^');
            });
        });

        it('should throw error when the username is too short', function () {
            assert.throws(function () {
                validator.validateUsername('Ab');
            });
        });

        it('should pass successfully(1)', function () {
            assert.equal(undefined, validator.validateUsername('asdfg'));
        });

        it('should pass successfully(2)', function () {
            assert.equal(undefined, validator.validateUsername('asd'));
        });

        it('should pass successfully(3)', function () {
            assert.equal(undefined, validator.validateUsername('asdfghjkl_123ASDF'));
        });
    });

    describe('validatePassword()', function () {
        it('should throw error when the password is undefined', function () {
            assert.throws(function () {
                validator.validatePassword(undefined);
            });
        });

        it('should throw error when the password is null', function () {
            assert.throws(function () {
                validator.validatePassword(null);
            });
        });

        it('should throw error when the password is empty string', function () {
            assert.throws(function () {
                validator.validatePassword('');
            });
        });

        it('should throw error when the username contains invalid characters(1)', function () {
            assert.throws(function () {
                validator.validatePassword('(1234');
            });
        });

        it('should throw error when the username contains invalid characters(2)', function () {
            assert.throws(function () {
                validator.validatePassword('1234+');
            });
        });

        it('should throw error when the username contains invalid characters(3)', function () {
            assert.throws(function () {
                validator.validatePassword('123ь4');
            });
        });

        it('should throw error when the password is too short', function () {
            assert.throws(function () {
                validator.validatePassword('12');
            });
        });

        it('should pass successfully(1)', function () {
            assert.equal(undefined, validator.validatePassword('asdfg'));
        });

        it('should pass successfully(2)', function () {
            assert.equal(undefined, validator.validatePassword('asd'));
        });

        it('should pass successfully(3)', function () {
            assert.equal(undefined, validator.validatePassword('asdfgh!@#$%^&*jkl_123ASDF'));
        });
    });
});