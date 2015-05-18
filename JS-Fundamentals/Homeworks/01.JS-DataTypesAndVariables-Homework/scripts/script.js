function literals() {

    var array = [
    "var integer = 23;",
    "var float = 333.33;",
    "var bool = true;",
    "var string = \"Petrakis\";",
    "var object = { name: Ivaylo, age: 22, gender: male };",
    "var undefine;",
    "var nullable = null;",
    "var NaN = pesho / sashka ;",
    "var func = function () {console.log('Literals')};"
    ];
    jsConsole.writeLine("\r\n" + "-------------------- Task 1 --------------------");

    for (var i = 0; i < array.length; i++) {
        jsConsole.writeLine(array[i]);
    }
    jsConsole.writeLine("\r\n");
}

function howAreYou() {

    jsConsole.writeLine( "\r\n" + "-------------------- Task 2 --------------------");
    jsConsole.writeLine('"How you doin\'?", Joey said.');
    jsConsole.writeLine("\r\n");
}

function typeOfLiterals() {

    jsConsole.writeLine( "\r\n" + "-------------------- Task 3 --------------------");
    var integer = 23;
    var float = 333.33;
    var bool = true;
    var string = 'Petrakis';
    var object = { name: 'Ivaylo', age: 22, gender: 'male' };
    var undefine;
    var nullable = null;
    var NaN = 'pesho' / 'sashka';
    var func = function () { console.log('Literals') };

    var literalArray = [integer, float, bool, string, object, undefine, nullable, NaN, func];

    for (var i = 0; i < literalArray.length; i++) {
        jsConsole.writeLine(' - ' + literalArray[i] + '     | The type is: => ' + typeof (literalArray[i]));
    }
    jsConsole.writeLine("\r\n");
}

function task4() {

    jsConsole.writeLine("\r\n" + "-------------------- Task 4 --------------------");

    var nullVariable = null;
    var undefinedVariable;

    jsConsole.writeLine('Null is of type: ' + typeof (nullVariable));
    jsConsole.writeLine('Undefined is of type: ' + typeof (undefinedVariable));
    jsConsole.writeLine("\r\n");
}