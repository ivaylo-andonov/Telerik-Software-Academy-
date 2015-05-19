// Problem 1:

function task1() {
    var number = document.getElementById('problem1').value;

    if (!isNaN(number) && number !== '') {

        if (number % 2 === 0) {
            jsConsole.writeLine(number + ' is <span style="color:#11cfff">EVEN</span>');
            console.log('Problem 1: ' + number + ' is even');
        } else {
            jsConsole.writeLine(number + ' is <span style="color:#11cfff">ODD</span>');
            console.log('Problem 1: ' + number + ' is odd');
        }
    }
    else {
        jsConsole.writeLine('<span style="color:red">The input isn`t an integer.Please, try again.</span>');
    }

    // Clear the input field
    document.getElementById('problem1').value = '';
}

// Problem 2

function task2() {

    var number = document.getElementById('problem2').value;

    if (!isNaN(number) && number !== '') {
        if (number % 5 === 0 && number % 7 === 0) {
            jsConsole.writeLine(number + ' is divisible by 5 and 7');
            console.log('Problem 2: ' + number + ' is divisible by 5 and 7');
        } else {
            jsConsole.writeLine(number + ' is NOT divisible by 5 and 7');
            console.log('Problem 2: ' + number + ' is NOT divisible by 5 and 7');
        }
    }
    else {
        jsConsole.writeLine('<span style="color:red">The input isn`t an integer.Please, try again.</span>');
    }
    document.getElementById('problem2').value = '';
}

// Problem 3

function task3() {
    var width = document.getElementById('rect-width').value;
    var height = document.getElementById('rect-height').value;
    var result = width * height;

    jsConsole.writeLine('Rectangle area is : ' + result);
    console.log('Problem 3: ' + 'Rectangle area is ' + result);
    if (result > 100000) {
        alert("Wow! Too big number, dude!");
    }
    document.getElementById('rect-width').value = '';
    document.getElementById('rect-height').value = '';
}

// Problem 4
function task4() {
    var num = document.getElementById('problem4').value; // Math.Abs returns only absolute (+) numbers
    var isThirdDigit7 = false;

    if (!isNaN(num) && num !== '') {
        var position = Math.floor(Math.abs(num / 100));      // Find the third digit of number
        if (position % 10 === 7) {
            isThirdDigit7 = true;
        }
        jsConsole.writeLine('Is the third digit = 7 ? ->  ' + isThirdDigit7);

    }
    else {
        jsConsole.writeLine('<span style="color:red">The input isn`t an integer.Please, try again.</span>');
    }
    // To find is the last digit is 7 
    console.log('Problem 4: ' + ' Is the third digit 7? ->  ' + isThirdDigit7);
    document.getElementById('problem4').value = '';
}

// Problem 5:

function task5() {
    var input = document.getElementById('problem5').value;
    var binaryNumber = parseInt(input, 10).toString(2);
    var pad = '0000000000000000';
    var fullBinaryNum = (pad + binaryNumber).slice(-pad.length);

    if (!isNaN(input) && input !== '') {
        var thirdBit = (input >> 3) & 1;
        jsConsole.writeLine('Number: ' + input + '<br>' + ' Binary representation: ' + fullBinaryNum + '<br>' + 'Bit #3: ' + thirdBit);
        console.log('Problem 5:' + input + ', binary representation: ' + fullBinaryNum + ', third bit: ' + thirdBit);
    }
    else {
        jsConsole.writeLine('<span style="color:red">The input isn`t an integer.Please, try again.</span>');
    }
    document.getElementById('problem5').value = '';
}

// Problem 6

function task6() {
    var coorX = document.getElementById('coor-x').value,
        coorY = document.getElementById('coor-y').value,
        r = 5,
        withinCircle = (coorX * coorX + coorY * coorY) <= r * r;

    if (!isNaN(coorX) && !isNaN(coorY) && coorX !== '' && coorY !== '') {
        jsConsole.writeLine('The point (' + coorX + ',' + coorY + ') is within the circle K(O, 5) --> ' + withinCircle);

        console.log('Problem 6: The point (' + coorX + ',' + coorY + ') is within the circle K(O, 5) --> ' + withinCircle);
    } else {
        jsConsole.writeLine('<span style="color:red">X and Y should be valid coordinates.Try again!</span>');

    }
    document.getElementById('coor-x').value = '';
    document.getElementById('coor-y').value = '';
}

// Problem 7
function task7() {
    var number = document.getElementById('problem7').value;
    var isPrime = true;

    if (!isNaN(number) && number !== '') {

        if (number > 1) {
            for (var i = 2; i < number; i++) {
                if (number % i === 0) {
                    isPrime = false;
                    break;
                }
            }
        }
        else {
            isPrime = false;
        }
        jsConsole.writeLine(number + ' is prime? --> ' + isPrime);

        console.log(number + ' is prime? --> ' + isPrime);
    } else {
        jsConsole.writeLine('<span style="color:red">Invalid integer.Try again!</span>');
    }
    document.getElementById('problem7').value = '';
}

// Problem 8:

function task8() {
    var sideA = document.getElementById('side-a').value;
    var sideB = document.getElementById('side-b').value;
    var height = document.getElementById('height').value;
    var area = 0;

    if (!isNaN(sideA) && !isNaN(sideB) && !isNaN(height)) {
        area = (sideA * 1 + sideB * 1) * height / 2;
        jsConsole.writeLine('Trapezoid area is: ' + area);
        console.log('Problem 8: Trapezoid area is: (' + sideA + '+' + sideB + ') / 2 *' + height + ' = ' + area);
    } else {
        jsConsole.writeLine('<span style="color:red">Invalid input data.Try again!</span>');
    }

    document.getElementById('side-a').value = '';
    document.getElementById('side-b').value = '';
    document.getElementById('height').value = '';
}

// Problem 9:

function task9() {
    var coorX = document.getElementById('coord-x').value,
        coorY = document.getElementById('coord-y').value,
        r = 3,
        withinCircle = ((coorX - 1) * (coorX - 1) + (coorY - 1) * (coorY - 1)) <= r * r,
        outsideRect = ((coorX < -1) || (coorX > 5) || (coorY > 1) || (coorY < -1)),
        checkCondition = withinCircle && outsideRect;

    console.log(coorX);
    if (!isNaN(coorX) && !isNaN(coorY)) {
        jsConsole.writeLine('Circle: K((1,1),3)' + '<br>' + 'Rectangle: R(top=1, left=-1, width=6, height=2)' + '<br>'
            + 'The Point: P(' + coorX + ', ' + coorY + ') Is inside in K and outside of the R?' + '<br>' + '---> ' + checkCondition);

        console.log('Problem 9: The point (' + coorX + ',' + coorY +
        ') is within the circle K((1,1)), 3) and outside the given rectangle --> '
        + checkCondition);
    } else {
        jsConsole.writeLine('X and Y must be numbers');
    }

    document.getElementById('coord-x').value = '';
    document.getElementById('coord-y').value = '';
}