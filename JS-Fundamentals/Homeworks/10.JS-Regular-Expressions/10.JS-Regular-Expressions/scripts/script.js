// Problem 1

function task1() {

    var input = jsConsole.read('#options').split(','),
        result,
        options = {
            name: input[0],
            age: input[1] * 1
        };
    result = 'My name is #{name} and I am #{age}-years-old.'.format(options);

    jsConsole.writeLine('Result : ' + result);
    console.log('Result : ' + result);
    document.getElementById('options').value = '';
}

if (!String.prototype.format) {
    String.prototype.format = function (options) {
        var item,
        placeholder,
        formatedResult = this;

        for (item in options) {
            if (options[item] === '') {
                return 'No arguments';
            }
            placeholder = new RegExp('#{' + item + '}', 'g');
            formatedResult = formatedResult.replace(placeholder, options[item]);
        }
        return formatedResult;
    };
}

// Problem 2

function task2A() {
    var str = '<div data-bind-content="name"></div>';
    var result = str.bind({ name: 'Steven' });
    console.log('Problem 2: ' + result);
    jsConsole.writeLine('Problem 2 (A) : <br>' + result.htmlEscape());
}

function task2B() {
    var str = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></a>';
    var result = str.bind({
        name: 'Elena',
        link: 'http://telerikacademy.com'
    });
    jsConsole.writeLine('Problem 2 (B) : <br> ' + result.htmlEscape());
}

String.prototype.bind = function (obj) {
    var prop,
        reContent,
        reHref,
        reClass,
        result = this;

    for (prop in obj) {
        reContent = new RegExp('(<.*data-bind-content="' + prop + '".*>)(.*)(<.*>)', 'gi'),
            reHref = new RegExp('(<.*data-bind-href="' + prop + '")', 'gi'),
            reClass = new RegExp('(<.*data-bind-class="' + prop + '")', 'gi');

        result = result.replace(reContent, function (none, opening, content, closing) {
            content = obj[prop];
            return opening + content + closing;
        }).replace(reHref, function (none, content) {
            return content + ' href="' + obj[prop] + '"';
        }).replace(reClass, function (none, content) {
            return content + ' class="' + obj[prop] + '"';
        });
    }
    return result;
};

// Method for escaping html tags, without this they can not display on the page
String.prototype.htmlEscape = function () {
    var escapedStr = String(this).replace(/&/g, '&amp;');
    escapedStr = escapedStr.replace(/</g, '&lt;');
    escapedStr = escapedStr.replace(/>/g, '&gt;');
    escapedStr = escapedStr.replace(/"/g, '&quot;');
    escapedStr = escapedStr.replace(/'/g, '&#39');
    return escapedStr;
};