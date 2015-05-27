// Problem 1
function task1() {

    var n = jsConsole.readInteger('#num-1');
    for (var i = 1; i <= n; i++) {
        jsConsole.writeLine(i);
    }
    jsConsole.writeLine();
    document.getElementById('num-1').value = '';
}

// Problem 2
function task2() {

    var n = jsConsole.readInteger('#num-2');
    jsConsole.writeLine('The numbers are:');
    for (var i = 1; i <= n; i++) {
        if (i % 3 !== 0 && i % 7 !== 0) {
            jsConsole.write(i);
            if (i !== n) {
                jsConsole.write(', ');
            }
        }
    }
    jsConsole.writeLine();
    document.getElementById('num-2').value = '';
}

// Problem 3
function task3() {

    var input = jsConsole.read('#sequence');
    var min = Number.MAX_VALUE;
    var max = Number.MIN_VALUE;

    var array = input.split(' ');
    for (var i = 0; i < array.length; i++) {
        if (max < array[i] * 1) {
            max = array[i] * 1;
        }
        if (min > array[i] * 1) {
            min = array[i] * 1;
        }
    }

    jsConsole.writeLine('Min is: ' + min);
    jsConsole.writeLine('Max is: ' + max);

    jsConsole.writeLine();
    document.getElementById('sequence').value = '';
}

// Problem 4

function task4() {
    var smallest = 'ksks',
        largest = '',
        result,
        property;

    for (property in document) {
        if (property < smallest) {
            smallest = property;
        }
        if (property > largest) {
            largest = property;
        }
    }

    result = 'Document: smallest: ' + smallest + '; largest: ' + largest + '<br>';
    console.log('Document: smallest: ' + smallest + '; largest: ' + largest);
    smallest = 'ksks';
    largest = '';

    for (property in window) {
        if (property < smallest) {
            smallest = property;
        }
        if (property > largest) {
            largest = property;
        }
    }

    result += 'Window: smallest: ' + smallest + '; largest: ' + largest + '<br>';
    console.log('Window: smallest: ' + smallest + '; largest: ' + largest);
    smallest = 'ksks';
    largest = '';

    for (property in navigator) {
        if (property < smallest) {
            smallest = property;
        }
        if (property > largest) {
            largest = property;
        }
    }

    result += 'Navigator: smallest: ' + smallest + '; largest: ' + largest ;
    console.log('Navigator: smallest: ' + smallest + '; largest: ' + largest);
    
    jsConsole.writeLine(result);
}