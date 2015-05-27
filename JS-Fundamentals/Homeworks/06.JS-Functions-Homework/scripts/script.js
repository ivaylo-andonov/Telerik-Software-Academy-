// Problem 1

function task1() {
    var number = jsConsole.readInteger('#number1');
    var lastDigit = number % 10;
    jsConsole.write('The last digit is : ');
    switch (lastDigit) {
        case 0:
            jsConsole.writeLine('Zero');
            break;
        case 1:
            jsConsole.writeLine('One');
            break;
        case 2:
            jsConsole.writeLine('Two');
            break;
        case 3:
            jsConsole.writeLine('Three');
            break;
        case 4:
            jsConsole.writeLine('Four');
            break;
        case 5:
            jsConsole.writeLine('Five');
            break;
        case 6:
            jsConsole.writeLine('Six');
            break;
        case 7:
            jsConsole.writeLine('Seven');
            break;
        case 8:
            jsConsole.writeLine('Eight');
            break;
        case 9:
            jsConsole.writeLine('Nine');
            break;
        default:
            jsConsole.writeLine('Not a digit');
            break;
    }
    document.getElementById('number1').value = '';
}

// Problem 2 
function task2() {
    var input = jsConsole.read('#number2'),
        length = input.length;

    var reversedArray = new Array(length);
    for (var i = 0; i < length; i += 1) {
        reversedArray[length - i - 1] = input[i];
    }
    jsConsole.writeLine('normal = [' + input + ']');
    jsConsole.writeLine('reversed = [' + reversedArray.join('') + ']');

    document.getElementById('number2').value = '';
}

// Problem 3

// just example for text
var text = 'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using \'Content here, content here\', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for \'lorem ipsum\' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).';

function task3() {
    var word = jsConsole.read('#word');
    var isCheck = document.getElementById('check').checked;

    if (word !== '') {
        if (isCheck) {
            searchWord(document.getElementById('text').innerHTML, word, true);
        } else {
            searchWord(document.getElementById('text').innerHTML, word, false);
        }
    }

    document.getElementById('check').checked = false;
    document.getElementById('word').value = '';
}

function searchWord(text, word, caseSensitive) {
    var lookFor,
        clearText,
        newText;

    if (!caseSensitive) {
        lookFor = new RegExp('(\\b' + word + '\\b)', 'gim');
    } else {
        lookFor = new RegExp('(\\b' + word + '\\b)', 'gm');
    }
    clearText = text.replace(/(<span>|<\/span>)/gim, '');
    newText = clearText.replace(lookFor, '<span>$1</span>');
    document.getElementById('text').innerHTML = newText;
}

function getText() {

    document.getElementById('text').innerHTML = text;
}

// Problem 4 

function task4() {
    var count = document.getElementsByTagName('div').length;
    jsConsole.writeLine('There are ' + count + ' DIV`s in the html document.');
    jsConsole.writeLine('( You can check it if you open the .html file and count them )');
}

function createDiv() {
    var string = 'I am new div';
    var newDiv = document.createElement('div');
    newDiv.innerHTML = string;
    document.getElementById('newDivs').appendChild(newDiv);
}

function clearDivs() {
    document.getElementById('newDivs').innerHTML = '';
}

// Problem 5

function task5() {

    var input = jsConsole.read('#numbers5');
    var number = jsConsole.readFloat('#number5');
    var array = input.split(' ').map(Number);
    var count = 0;

    for (var i = 0; i < array.length; i++) {

        if (number === array[i]) {

            count += 1;
        }
    }
    jsConsole.writeLine('The number ' + number + ' is founded (' + count + ') times in the array.');
    document.getElementById('number5').value = '';
    document.getElementById('numbers5').value = '';
}

// Problem 6

function task6() {

    var input = jsConsole.read('#numbers6');
    var number = jsConsole.readFloat('#number6');
    var array = input.split(' ').map(Number);
    jsConsole.writeLine('Your numbers : [' + array + ']');
    jsConsole.write('The number ' + array[number] + ' is ');
    if (number === 0) {

        if (array[number + 1] < array[number]) {
            jsConsole.write(' bigger than its next neighbour');
        }
        else {
            jsConsole.write(' NOT bigger than its next neighbour');
        }
    }
    else if (number === array.length - 1) {
        if (array[number - 1] < array[number]) {
            jsConsole.write(' bigger than its previous neighbour');
        }
        else {
            jsConsole.write(' NOT bigger than its previous neighbour');
        }
    }

    else if (array[number] > array[number - 1] && array[number] > array[number + 1]) {
        jsConsole.write('bigger than neighbours both');
    }
    else if (array[number] <= array[number - 1] || array[number] <= array[number + 1]) {
        jsConsole.write(' NOT bigger than neighbours both');
    }

    jsConsole.writeLine();
    document.getElementById('number6').value = '';
    document.getElementById('numbers6').value = '';
}

// Problem 7

function task7() {
    var input = jsConsole.read('#numbers7');
    var array = input.split(' ').map(Number);
    var index = -1;

    for (var i = 1; i < array.length - 1; i++) {
        if (array[i] > array[i + 1] && array[i] > array[i - 1]) {
            index = i;
            break;
        }       
    }
    jsConsole.writeLine('The index of the first element larger than neighbours is ' + index);
    document.getElementById('numbers7').value = '';

}