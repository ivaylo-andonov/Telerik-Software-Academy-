// Problem 1
function task1() {
    var array = new Array(20);
    for (var i = 0; i < array.length; i += 1) {
        array[i] = i + 1;
    }

    i = 0;
    for (; i < array.length; i += 1) {
        array[i] *= 5;
    }
    jsConsole.writeLine(array.join(', ') + ';');
}

// Problem 2

function task2() {
    var wordOne = jsConsole.read('#word1');
    var wordTwo = jsConsole.read('#word2');

    if (wordOne !== '' && typeof (wordOne) === 'string' && wordTwo !== '' && typeof (wordTwo) === 'string') {
        if (wordOne.length > wordTwo.length) {
            jsConsole.writeLine('The char arrays are not equal.First one has bigger length.');
        }
        else if (wordTwo.length > wordOne.length) {
            jsConsole.writeLine('The char arrays are not equal.Second one has bigger length.');
        }
        else {
            jsConsole.write('The words (char arrays) have equal length');
            for (var i = 0; i < wordOne.length; i++) {
                if (wordOne[i] !== wordTwo[i]) {
                    jsConsole.writeLine(',but they have different elements.');
                    return;
                }

            }
            jsConsole.writeLine(' and equal elements.');
        }
    }
    document.getElementById('word1').value = '';
    document.getElementById('word2').value = '';
}

// Problem 3

function task3() {
    var input = jsConsole.read('#sequence');
    var seqArray = input.split(' ').map(Number);
    if (seqArray instanceof Array) {

        var bestElement,
            bestLength = 1,
            currLength = 0,
            currElement = seqArray[0];

        for (var i = 0; i < seqArray.length; i++) {
            if (seqArray[i] === currElement) {
                currLength += 1;

            }
            else {
                currElement = seqArray[i];
                currLength = 1;
            }
            if (currLength >= bestLength) {
                bestElement = currElement;
                bestLength = currLength;

            }
        }
        jsConsole.write('The maximal sequence is : ');
        for (var k = 0; k < bestLength; k++) {

            jsConsole.write(bestElement + ' ');
        }
        jsConsole.writeLine();
    }

    document.getElementById('sequence').value = '';
}

// Problem 4

function task4() {
    var input = jsConsole.read('#sequence2');
    var seqArray = input.split(' ').map(Number);
    if (seqArray instanceof Array) {

        var currLength = 1,
            bestLength = 1,
            lastIndex = 0;

        for (var i = 1; i < seqArray.length; i++) {
            if (seqArray[i - 1] < seqArray[i]) {
                currLength++;
            }
            else {
                if (bestLength < currLength) {
                    bestLength = currLength;
                    currLength = 1;
                    lastIndex = i;
                }
            }
        }

        if (bestLength < currLength) {
            bestLength = currLength;
            lastIndex = seqArray.length;
        }

        var result = 'The maximal increasing sequence is : ';
        for (var j = 0; j < bestLength; j++) {
            result += seqArray[lastIndex - bestLength + j];
            result += ' ';
        }
        jsConsole.writeLine(result);
    }
    document.getElementById('sequence2').value = '';
}

// Problem 5

function task5() {
    var input = jsConsole.read('#sequence3');
    var seqArray = input.split(' ').map(Number);
    if (seqArray instanceof Array) {

        jsConsole.writeLine('Your sequense before the sort:');
        jsConsole.writeLine(seqArray.join(', '));

        for (var i = 0; i < seqArray.length - 1; i++) {
            for (var j = i + 1; j < seqArray.length; j++) {
                if (seqArray[i] > seqArray[j]) {
                    var temp = seqArray[i];
                    seqArray[i] = seqArray[j];
                    seqArray[j] = temp;
                }
            }
        }

        jsConsole.writeLine('Your sequense after the sort:');
        jsConsole.writeLine(seqArray.join(', '));
    }
    document.getElementById('sequence3').value = '';
}

// Problem 6

function task6() {
    var input = jsConsole.read('#sequence4');
    var seqArray = input.split(' ').map(Number);
    if (seqArray instanceof Array) {

        jsConsole.writeLine('Your sequence : ');
        jsConsole.writeLine(seqArray.join(', '));

        var maxLength = 0;
        var element = seqArray[0];
        for (var i = 0; i < seqArray.length; i++) {

            var currLength = 0;

            for (var j = 0; j < seqArray.length; j++) {
                if (seqArray[i] === seqArray[j]) {
                    currLength++;
                }
            }
            if (currLength > maxLength) {
                maxLength = currLength;
                element = seqArray[i];
            }
        }
        jsConsole.writeLine('The most frequent number is ' + element + ' (' + maxLength + ' times)');
    }
    document.getElementById('sequence4').value = '';
}

//Problem 7. Binary search
//Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

function task7() {
    var input = jsConsole.read('#sequence5');
    var seqArray = input.split(' ').map(Number);
    var number = jsConsole.readInteger('#number5'),
        minIndex = 0,
        maxIndex = seqArray.length - 1;
        
    seqArray.sort(function (a, b) { return (a - b); });       // For binary search algorithm the array must be sorted
    jsConsole.writeLine('Your array sorted: ' + '<br>' + '[' + seqArray.join(', ') + ']');
    
    binarySearch(number, seqArray, minIndex, maxIndex);

    document.getElementById('sequence5').value = '';
    document.getElementById('number5').value = '';
}

function binarySearch(number, seqArray, minIndex, maxIndex) {

    var midPoint ;

    if (maxIndex < minIndex) {
        jsConsole.writeLine('The number doest not consist in the array.');
    }
    else {
        midPoint = (((minIndex + maxIndex) / 2) | 0);

        if (seqArray[midPoint] < number) {
            binarySearch(number, seqArray, midPoint + 1, maxIndex);
        }
        else if (seqArray[midPoint] > number) {
            binarySearch(number, seqArray, minIndex, midPoint - 1);
        }
        else {
            jsConsole.writeLine('The number ' + number + ' is at [' + midPoint + '] position in the array.');
        }
    }
}