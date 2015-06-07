// Problem 1

function task1() {
    var input = jsConsole.read('#string1'),
        length = input.length;

    var reversedArray = '';
    for (var i = 0; i < length; i += 1) {
        reversedArray += input[input.length - i - 1];
    }
    jsConsole.writeLine(new Array(45).join('-'));
    jsConsole.writeLine('normal = ' + input);
    jsConsole.writeLine('reversed = ' + reversedArray);


    document.getElementById('string1').value = '';
}

// Problem 2

function task2() {
    var input = jsConsole.read('#string2'),
        count = 0,
        len = input.length,
        i;

    document.getElementById('string2').value = '';
    jsConsole.writeLine(new Array(45).join('-'));

    if (input === '') {
        jsConsole.writeLine('Empty input');
        return;
    }
    if ((input.indexOf('(') === -1) && (input.indexOf(')') === -1)) {
        jsConsole.writeLine('No brackets');
        return 'No brackets';
    }
    for (i = 0; i < len; i += 1) {

        if (input[i] === '(') {
            count += 1;
        }
        else if (input[i] === ')') {
            count -= 1;
        }
        if (count < 0) {
            jsConsole.writeLine('Incorrect!');
            return 'Is not correct';
        }
    }
    count === 0 ? jsConsole.writeLine('Correct!') : jsConsole.writeLine('Incorrect!');
    return count === 0 ? 'correct' : 'incorrect';

}

// Problem 3

function task3() {

    var text = 'We are living in an yellow submarine. We don\'t have anything else.Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.';
    jsConsole.writeLine(new Array(45).join('-'));
    jsConsole.writeLine('Text: <br>' + text);

    // You can change the substring
    var foundsCounter = findSubstring(text, 'in');
    jsConsole.writeLine('--> The substring "in" is founded ' + foundsCounter + ' times in text.');
    return foundsCounter;
}

function findSubstring(text, word) {
    var regex = new RegExp(word, 'gi');
    return (text.match(regex)).length;
}

// Problem 4

function task4() {
    var result = '',
        text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>ANYTHING</lowcase> else.',
        len = text.length,
        i;

    jsConsole.writeLine(new Array(45).join('-'));
    jsConsole.writeLine('- Full input text with tags :<br>' + text.htmlEscape());
    console.log('Full input text with tags : ' + text);

    for (i = 0; i < len; i += 1) {

        if (text[i] === '<') {
            if (text[i + 1] === 'u') {
                i += 8;
                while (text[i] !== '<') {
                    result += text[i].toUpperCase();
                    i += 1;
                }
                i += 8;
            }
            else if (text[i + 1] === 'm') {
                i += 9;
                while (text[i] !== '<') {
                    if (i % 2 === 0) {
                        result += text[i].toUpperCase();
                    } else {
                        result += text[i].toLowerCase();
                    }
                    i += 1;
                }
                i += 9;
            }
            else if (text[i + 1] === 'l') {
                i += 9;
                while (text[i] !== '<') {
                    result += text[i].toLowerCase();
                    i += 1;
                }
                i += 9;
            }
        } else {
            result += text[i];
        }
    }
    jsConsole.writeLine('- Your result formated by tags: <br>' + result);
}

// Method for escaping html tags, without this they can not display on the page
String.prototype.htmlEscape = function () {
    var escapedStr = String(this).replace(/&/g, '&amp;');
    escapedStr = escapedStr.replace(/</g, '&lt;');
    escapedStr = escapedStr.replace(/>/g, '&gt;');
    escapedStr = escapedStr.replace(/"/g, '&quot;');
    escapedStr = escapedStr.replace(/'/g, '&#39');
    return escapedStr;
};


// Problem 5
function task5() {
    var input = jsConsole.read('#text5'),
        text = '';

    jsConsole.writeLine(new Array(45).join('-'));
    document.getElementById('text5').value = '';
    jsConsole.writeLine('Text: <br>' + input);

    text = replaceAll(input, ' ', '&nbsp;');
    jsConsole.writeLine('Result: <br>' + text);
    console.log(text);
}

function replaceAll(text, item, newItem) {
    var regex = new RegExp(item, 'gi');
    return text.replace(regex, newItem);
}

// Probem 6

function task6() {
    var htmlText = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body </body></html>';
    jsConsole.writeLine(new Array(45).join('-'));

    jsConsole.writeLine('- HTML text : <br>' + htmlText.htmlEscape());
    console.log('HTML is : ' + htmlText);

    var resultText = extractText(htmlText);

    console.log('- Result is <br>: ' + resultText);
    jsConsole.writeLine('- Result: <br>' + resultText);
}

function extractText(text) {
    var i,
        inTag = false,
        result = '';
    for (i = 0; i < text.length; i += 1) {
        if (text[i] === '<') {
            inTag = true;
        } else if (text[i] === '>') {
            inTag = false;
        } else if (!inTag) {
            result += text[i];
        }
    }
    return result;
}

// Problem 7

function task7() {
    var urlAddress = 'http://telerikacademy.com/Courses/Courses/Details/239',
        resultObj = {},
        formatedResult = '',
        firstSlash = urlAddress.indexOf('/'),
        secondSlash = urlAddress.indexOf('/', firstSlash + 1),
        thirdSlash = urlAddress.indexOf('/', secondSlash + 1);

    resultObj.protocol = urlAddress.substring(0, urlAddress.indexOf(':'));
    resultObj.server = urlAddress.substring(secondSlash + 1, thirdSlash);
    resultObj.resource = urlAddress.substring(thirdSlash);

    jsConsole.writeLine(new Array(45).join('-'));
    for (var prop in resultObj) {
        formatedResult += prop + ': ' + resultObj[prop] + '; <br>';
    }
    jsConsole.writeLine('- URL Adress: <br>' + urlAddress + '<br> - Result: <br>' + formatedResult);
}

// Problem 8

function task8() {
    var input = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

    jsConsole.writeLine(new Array(45).join('-'));
    jsConsole.writeLine('- HTML text: <br>' + input.htmlEscape());
    while (input.indexOf('<a href') >= 0) {
        input = input.replace('<a href="', '[URL=').
        replace('">', ']').
        replace('</a>', '[/URL]');
    }
    jsConsole.writeLine('<br>- HTML text,replaced tags "a href" with [URL]: <br>' + input.htmlEscape());
    return input;
}

// Problem 9
function task9() {
    var text = 'ivaylo.andonov@gmail.com, "PenkaPenka" , <Aleksandar_92@abv.bg>, "Frenski Kon.bg" , <Opaaa@gmal.com>, ' +
    '"Ko kaza Ko?" , <julien_92@abv.bg>, "stefi.a.d@hotmail.com" ,  <spagetti>';

    console.log(getEmails(text).join('<br>'));
    jsConsole.writeLine(new Array(45).join('-'));
    jsConsole.writeLine('Extracted emails: <br> ' + getEmails(text).join('<br>'));
}
function getEmails(text) {
    return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
}

// Problem 10

function task10() {
    var text = jsConsole.read('#text10'),
        wordsArray = text.split(' '),
        result = [],
        i;

    for (i = 0; i < wordsArray.length; i++) {
        if (wordsArray[i] === reverseString(wordsArray[i])) {
            result.push(wordsArray[i]);
        }
    }

    jsConsole.writeLine(new Array(45).join('-') + '<br> Palindromes from your text are:');
    result.length > 0 ? jsConsole.writeLine(result.join(', ')) : jsConsole.writeLine('No palindromes');
    document.getElementById('text10').value = '';
    return result;
}

function reverseString(s) {
    var o = '';
    for (var i = s.length - 1; i >= 0; i--)
        o += s[i];
    return o;
}

// Problem 11

function task11() {
    var parameters = jsConsole.read('#arguments11').split(','),
    format = '{0} is so {1} with {2} sky, {1} nature and house next to the {2} pacific ocean...';
    var len = parameters.length;

	jsConsole.writeLine(new Array(45).join('-'));
    if (parameters[0] === '') {
        jsConsole.writeLine('I wait you for the arguments...');
        return;
    }
    jsConsole.writeLine(stringFormat(format, parameters[0], parameters[1], parameters[2]));
    document.getElementById('arguments11').value = '';
    return stringFormat(format, parameters[0], parameters[1], parameters[2]);
}

function stringFormat() {
    var args = arguments,
		format = args[0],
		placeholder,
        index;

    for (index = 1; index < args.length; index++) {
        placeholder = '{' + (index - 1) + '}';
        while (format.indexOf(placeholder) > -1) {
            format = format.replace(placeholder, args[index]);
        }
    }
    return format;
}

// Problem 12

function task12() {
    var people = [{ name: 'Ivo', age: 23 }, { name: 'Penka', age: 11 }, { name: 'Chefo', age: 29 }];
    var tmpl = document.getElementById('list-item').innerHTML;
    var peopleList = generateList(people, tmpl);

    document.getElementById('result').innerHTML = peopleList;
}

function strFormat(person, template) {
    template = template.replace('-{name}-', person.name);
    template = template.replace('-{age}-', person.age);

    return template;
}

function generateList(people, template) {
    var result = '<ul>';

    for (var i = 0; i < people.length; i++) {
        var person = people[i];
        result += '<li>' + strFormat(person, template) + '</li>';
    }

    result += '</ul>';

    return result;
}
