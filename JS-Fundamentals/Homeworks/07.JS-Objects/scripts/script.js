// PROBLEM 1

// POINT CONSTRUCTOR

function Point(x, y) {
    if (!isNumber(x) || !isNumber(y)) {
        throw new Error('Error, Incorrect input value!');
    }

    if (!(this instanceof Point)) {
        return new Point(x, y);
    }

    this.x = x;
    this.y = y;
}

// POINT PROTOTYPES

Point.prototype.toString = function () {
    return 'P(' + this.x + ',' + this.y + ')';
};

// LINE CONSTRUCTOR

function Line(startPoint, endPoint) {
    if (!(startPoint instanceof Point) || !(endPoint instanceof Point)) {
        throw new Error("Error! Incorrect input value!");
    }

    if (!(this instanceof Line)) {
        return new Line(startPoint, endPoint);
    }

    this.startPoint = startPoint;
    this.endPoint = endPoint;
}

// LINE PROTOTYPES

Line.prototype.distance = function () {
    var x = Math.pow(this.startPoint.x - this.endPoint.x, 2);
    var y = Math.pow(this.startPoint.y - this.endPoint.y, 2);

    return Math.sqrt(x + y);
};

Line.prototype.toString = function () {
    return 'L[' + this.startPoint.toString() + ',' + this.endPoint.toString() + ']';
};

// TRIANGLE CONSTRUCTOR

function Triangle(a, b, c) {
    if (!(this instanceof Triangle)) {
        return new Triangle(a, b, c);
    }
    if (!(a instanceof Line) || !(b instanceof Line) || !(c instanceof Line)) {
        throw new Error('A, B and C must be instances of Line');
    }

    if (!canFormTriangle(a, b, c)) {
        jsConsole.writeLine('The lines can NOT form a Triangle.');
        throw new Error("Segment lines cannot form a triangle!");

    }
    jsConsole.writeLine('The lines can form a Triangle.');
    this.a = a;
    this.b = b;
    this.c = c;
}

// FUNCTIONS

function canFormTriangle(a, b, c) {
    return a.distance() < b.distance() + c.distance() &&
           b.distance() < a.distance() + c.distance() &&
           c.distance() < a.distance() + b.distance();
}

function isNumber(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}

// Get the input and print the result
var xCoorA, yCoorA, xCoorB, yCoorB, xCoorC, yCoorC, pointA, pointB, pointC, lineA, lineB, lineC;

function task1Points() {
    xCoorA = jsConsole.readFloat('#xCoorA'),
    yCoorA = jsConsole.readFloat('#yCoorA'),
    xCoorB = jsConsole.readFloat('#xCoorB'),
    yCoorB = jsConsole.readFloat('#yCoorB'),
    xCoorC = jsConsole.readFloat('#xCoorC'),
    yCoorC = jsConsole.readFloat('#yCoorC'),

    pointA = new Point(xCoorA, yCoorA),
    pointB = new Point(xCoorB, yCoorB),
    pointC = new Point(xCoorC, yCoorC);

    jsConsole.writeLine('Point A --> ' + pointA.toString());
    jsConsole.writeLine('Point B --> ' + pointB.toString());
    jsConsole.writeLine('Point C --> ' + pointC.toString());
}

function task1Lines() {

    lineA = new Line(pointA, pointB),
    lineB = new Line(pointB, pointC),
    lineC = new Line(pointA, pointC);

    jsConsole.writeLine('Line A (A - B) --> ' + lineA.toString());
    jsConsole.writeLine('Line B (B - C) --> ' + lineB.toString());
    jsConsole.writeLine('Line C (A - C) --> ' + lineC.toString());

}

function task1Distances() {

    jsConsole.writeLine('Distance between the points of Line A : ' + lineA.distance());
    jsConsole.writeLine('Distance between the points of Line B : ' + lineB.distance());
    jsConsole.writeLine('Distance between the points of Line C : ' + lineC.distance());
}

function task1FormTriangle() {
    var triangle = new Triangle(lineA, lineB, lineC);
}

// PROBLEM 2

function task2() {
    var input = jsConsole.read('#array1'),
     seqArray = input.split(' ').map(Number),
     number = jsConsole.readInteger('#number1');

    jsConsole.writeLine('Your array before removing : ');
    jsConsole.writeLine('[' + seqArray.join(', ') + ']');

    seqArray.remove(number);

    jsConsole.writeLine('Your array after removing : ');
    jsConsole.writeLine('[' + seqArray.join(', ') + ']');

    document.getElementById('array1').value = '';
    document.getElementById('number1').value = '';
}

// Create a new function of the type Array, use .prototype for that mission and after that use it
Array.prototype.remove = function (element) {
    for (var i = this.length; i--;) {
        if (this[i] === element) {
            this.splice(i, 1);
        }
    }
    return this;
};


// PROBLEM 3
function task3() {
    var human = {
        name: "Vlado",
        age: 32
    };

    var secondHuman = (cloneObject(human));

    secondHuman.name = "Ivaylo";
    secondHuman.age = 28;

    jsConsole.writeLine('First Human --> name: ' + human.name + ', age: ' + human.age);
    jsConsole.writeLine('Second Human --> name: ' + secondHuman.name + ', age: ' + secondHuman.age);
}

function cloneObject(obj) {
    if (obj === null || typeof obj !== 'object') {
        return obj;
    }

    var clonedObj = {};
    for (var key in obj) {
        clonedObj[key] = cloneObject(obj[key]);
    }
    return clonedObj;
}

// PROBLEM 4

function task4() {

    var karatist = {
        name: 'Unufri',
        age: Infinity,
        rank: 1000
    };

    jsConsole.writeLine('"Karatist" -  name: ' + karatist.name + ', age: ' + karatist.age + ', rank: ' + karatist.rank);
    jsConsole.writeLine('Has gender? : ' + hasProperty(karatist, 'gender'));
    jsConsole.writeLine('Has rank? : ' + hasProperty(karatist, 'rank'));
    jsConsole.writeLine('Has medals? : ' + hasProperty(karatist, 'medals'));

    function hasProperty(obj, prop) {
        return obj.hasOwnProperty(prop);
    }
}

// PROBLEM 5

var persons = [];

function task5() {

    var firstName = jsConsole.read('#firstName'),
        lastName = jsConsole.read('#lastName'),
        age = jsConsole.readInteger('#age');

    var person = {
        firstName: firstName,
        lastName: lastName,
        age: age
    };

    persons.push(person);

    document.getElementById('firstName').value = '';
    document.getElementById('lastName').value = '';
    document.getElementById('age').value = '';
}

function youngest() {

    var min = 10000,
        youngestPerson = '';

    jsConsole.writeLine('----------All persons----------');
    for (var i = 0; i < persons.length; i++) {
        jsConsole.writeLine('- First name: ' + persons[i].firstName + ', Last name: ' + persons[i].lastName + ', Age: ' + persons[i].age);
    }

    for (var j = 0; j < persons.length; j++) {
        if (persons[j].age < min) {
            min = persons[j].age;
            youngestPerson = persons[j].firstName;
        }
    }
    jsConsole.writeLine('Youngest person is ' + min + ' years old and his name is ' + youngestPerson);
}

// PROBLEM 6

function task6() {
    var people = [
       { firstName: "Ivaylo", lastName: "Andonov", age: 23 },
       { firstName: "Simeon", lastName: "Levkov", age: 20 },
       { firstName: "Petranka", lastName: "Ivanov", age: 66 },
       { firstName: "Ivaylo", lastName: "Petrov", age: 31 },
       { firstName: "Ivaylo", lastName: "Andonov", age: 32 },
       { firstName: "Simeon", lastName: "Levkov", age: 23 },
       { firstName: "Ivaylo", lastName: "Petrov", age: 31 },
       { firstName: "Petar", lastName: "Ivanov", age: 31 },
       { firstName: "Sava", lastName: "Petrov", age: 23 },
       { firstName: "Simeon", lastName: "Petrov", age: 23 }
    ];

    console.log("GROUP PEOPLE");
    console.table(people);

    console.log("By firstname:");
    console.log(groupPeople(people, 'firstName'));

    console.log("By lastname:");
    console.log(groupPeople(people, 'lastName'));

    console.log("By age:");
    console.log(groupPeople(people, 'age'));

    function groupPeople(peopleArr, criterion) {
        var groupedPeople = [],
            arrLength = peopleArr.length,
            currentValue;

        for (var index = 0; index < arrLength; index++) {
            currentValue = peopleArr[index][criterion];
            if (!(groupedPeople[currentValue])) {
                groupedPeople[currentValue] = [];
            }
            groupedPeople[currentValue].push(peopleArr[index]);
        }
        return groupedPeople;
    }
}
