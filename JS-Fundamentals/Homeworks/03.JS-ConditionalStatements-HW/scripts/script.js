// Problem 1

function task1() {
    var firstNumber = jsConsole.readFloat('#first-num');
    var secondNumber = jsConsole.readFloat('#second-num');
    var isExchange = false;

    jsConsole.writeLine('Your numbers are ' + firstNumber + ' and ' + secondNumber);

    if (firstNumber > secondNumber) {
        var temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
        isExchange = true;
    }
    if (isExchange) {
        jsConsole.writeLine('--> Exchange: ' + firstNumber + ' ' + secondNumber);
    }
    else {
        jsConsole.writeLine('--> No exchange: ' + firstNumber + ' ' + secondNumber);
    }

    document.getElementById('first-num').value = '';
    document.getElementById('second-num').value = '';
}

//Problem 2
function task2() {
    var firstNumber = jsConsole.readFloat('#first-num2');
    var secondNumber = jsConsole.readFloat('#second-num2');
    var thirdNumber = jsConsole.readFloat('#third-num2');

    if (firstNumber * secondNumber * thirdNumber > 0) {
        jsConsole.writeLine('The sign is +');
    }
    else {
        jsConsole.writeLine('The sign is -');
    }

    document.getElementById('first-num2').value = '';
    document.getElementById('second-num2').value = '';
    document.getElementById('third-num2').value = '';
}

//Problem 3
function task3() {
    var firstNumber = jsConsole.readFloat('#first-num3');
    var secondNumber = jsConsole.readFloat('#second-num3');
    var thirdNumber = jsConsole.readFloat('#third-num3');

    // We shoud solve this task with NESTED IF`s :/
    if (firstNumber > secondNumber && firstNumber > thirdNumber) {
        jsConsole.writeLine('The biggest number is ' + firstNumber);
    }
    else if (secondNumber > firstNumber && secondNumber > thirdNumber) {
        jsConsole.writeLine('The biggest number is ' + secondNumber);
    }
    else if (thirdNumber > firstNumber && thirdNumber > secondNumber) {
        jsConsole.writeLine('The biggest number is ' + thirdNumber);
    }

    document.getElementById('first-num3').value = '';
    document.getElementById('second-num3').value = '';
    document.getElementById('third-num3').value = '';
}

//Problem 4
function task4() {
    var firstNumber = jsConsole.readFloat('#first-num4');
    var secondNumber = jsConsole.readFloat('#second-num4');
    var thirdNumber = jsConsole.readFloat('#third-num4');

    // We must do it with nested ifs :(
    if (firstNumber > secondNumber && firstNumber > thirdNumber) {
        if (secondNumber > thirdNumber) {
            jsConsole.writeLine('Sort in descending order: ' + firstNumber + ' ' + secondNumber + ' ' + thirdNumber);
        }
        else if (thirdNumber > secondNumber) {
            jsConsole.writeLine('Sort in descending order: ' + firstNumber + ' ' + thirdNumber + ' ' + secondNumber);
        }
    }
    else if (secondNumber > firstNumber && secondNumber > thirdNumber) {
        if (firstNumber > thirdNumber) {
            jsConsole.writeLine('Sort in descending order: ' + secondNumber + ' ' + firstNumber + ' ' + thirdNumber);
        }
        else if (thirdNumber > firstNumber) {
            jsConsole.writeLine('Sort in descending order: ' + secondNumber + ' ' + thirdNumber + ' ' + firstNumber);
        }
    }
    else if (thirdNumber > firstNumber && thirdNumber > secondNumber) {
        if (firstNumber > secondNumber) {
            jsConsole.writeLine('Sort in descending order: ' + thirdNumber + ' ' + firstNumber + ' ' + secondNumber);
        }
        else if (secondNumber > firstNumber) {
            jsConsole.writeLine('Sort in descending order: ' + thirdNumber + ' ' + secondNumber + ' ' + firstNumber);
        }
    }

    document.getElementById('first-num4').value = '';
    document.getElementById('second-num4').value = '';
    document.getElementById('third-num4').value = '';
}

// Problem 5

function task5() {
    var digit = jsConsole.readInteger('#problem5');

    if (digit > 9) {
        jsConsole.writeLine('The input consist more than 1 digits.Try again between 0-9.');
    }
    switch (digit) {
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
    document.getElementById('problem5').value = '';
}

// Problem 6

function task6() {
    var a = jsConsole.readFloat('#a-side');
    var b = jsConsole.readFloat('#b-side');
    var c = jsConsole.readFloat('#c-side');

    var r1,
        r2,
        disc,
        caseOfDisc;

    disc = b * b - 4 * a * c;
    if (disc > 0) {
        caseOfDisc = 1;
    }
    else if (disc === 0) {
        caseOfDisc = 2;
    }
    else {
        caseOfDisc = 3;
    }

    switch (caseOfDisc) {
        case 1:
            r1 = (-b - Math.sqrt(disc)) / (2 * a);
            r2 = (-b + Math.sqrt(disc)) / (2 * a);
            jsConsole.writeLine("x1 is " + r1);
            jsConsole.writeLine("x2 is " + r2);
            break;
        case 2:
            r1 = r2 = (-b) / (2 * a);
            jsConsole.writeLine("Roots are Equal");
            jsConsole.writeLine(' x1 = x2 = ' + r1);
            break;
        case 3:
            r1 = (-b) / (2 * a);
            r2 = Math.sqrt(-disc) / (2 * a);
            jsConsole.writeLine("No real roots!");
            break;
    }

    document.getElementById('a-side').value = '';
    document.getElementById('b-side').value = '';
    document.getElementById('c-side').value = '';
}









// Problem 7
function task7() {
    var firstNumber = jsConsole.readFloat('#first-num7');
    var secondNumber = jsConsole.readFloat('#second-num7');
    var thirdNumber = jsConsole.readFloat('#third-num7');
    var forthNumber = jsConsole.readFloat('#forth-num7');
    var fifthNumber = jsConsole.readFloat('#fifth-num7');

    var maxNumber = Math.max(firstNumber, secondNumber, thirdNumber, forthNumber, fifthNumber);
    jsConsole.writeLine('The MAX number is ' + maxNumber);

    document.getElementById('first-num7').value = '';
    document.getElementById('second-num7').value = '';
    document.getElementById('third-num7').value = '';
    document.getElementById('forth-num7').value = '';
    document.getElementById('fifth-num7').value = '';
}

// Problem 8
function task8() {
    var number = jsConsole.readInteger('#problem8');

    var hundreds = Math.floor(Math.abs(number / 100));
    var tens = Math.floor((number % 100) / 10);
    var ones = number % 10;

    if (hundreds > 0 && hundreds < 10) {
        switch (hundreds) {
            case 1:
                jsConsole.write("One hundred ");
                break;
            case 2:
                jsConsole.write("Two hundred ");
                break;
            case 3:
                jsConsole.write("Three hundred ");
                break;
            case 4:
                jsConsole.write("Four hundred ");
                break;
            case 5:
                jsConsole.write("Five hundred ");
                break;
            case 6:
                jsConsole.write("Six hundred ");
                break;
            case 7:
                jsConsole.write("Seven hundred ");
                break;
            case 8:
                jsConsole.write("Eight hundred ");
                break;
            case 9:
                jsConsole.write("Nine hundred ");
                break;
            default:
                jsConsole.writeLine();
                break;
        }
        if ((tens === 0 && ones > 0) || tens === 1) {
            Console.Write("and ");
        }
    }
    if (tens === 1) {
        switch (ones) {
            case 0:
                jsConsole.writeLine("Ten");
                break;
            case 1:
                jsConsole.writeLine("Eleven");
                break;
            case 2:
                jsConsole.writeLine("Twelve");
                break;
            case 3:
                jsConsole.writeLine("Thirteen");
                break;
            case 4:
                jsConsole.writeLine("Fourteen");
                break;
            case 5:
                jsConsole.writeLine("Fifteen");
                break;
            case 6:
                jsConsole.writeLine("Sixteen");
                break;
            case 7:
                jsConsole.writeLine("Seventeen");
                break;
            case 8:
                jsConsole.writeLine("Eighteen");
                break;
            case 9:
                jsConsole.writeLine("Nineteen");
                break;
            default:
                jsConsole.writeLine();
                break;
        }
    }
    if (tens > 1) {
        switch (tens) {
            case 2:
                jsConsole.write("Twenty ");
                break;
            case 3:
                jsConsole.write("Thirty ");
                break;
            case 4:
                jsConsole.write("Fourty ");
                break;
            case 5:
                jsConsole.write("Fifty ");
                break;
            case 6:
                jsConsole.write("Sixty ");
                break;
            case 7:
                jsConsole.write("Seventy ");
                break;
            case 8:
                jsConsole.write("Eighty ");
                break;
            case 9:
                jsConsole.write("Ninety ");
                break;
            default:
                jsConsole.writeLine();
                break;
        }
    }
    if (tens !== 1) {
        switch (ones) {
            case 1:
                jsConsole.writeLine("One");
                break;
            case 2:
                jsConsole.writeLine("Two");
                break;
            case 3:
                jsConsole.writeLine("Three");
                break;
            case 4:
                jsConsole.writeLine("Four");
                break;
            case 5:
                jsConsole.writeLine("Five");
                break;
            case 6:
                jsConsole.writeLine("Six");
                break;
            case 7:
                jsConsole.writeLine("Seven");
                break;
            case 8:
                jsConsole.writeLine("Eight");
                break;
            case 9:
                jsConsole.writeLine("Nine");
                break;
            default:
                jsConsole.writeLine();
                break;
        }
    }
    if (hundreds === 0 && tens === 0 && ones === 0) {
        jsConsole.writeLine("Zero");
    }

    document.getElementById('problem8').value = '';
}