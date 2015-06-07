// Problem 1

var persons = [];

function task1() {
    jsConsole.writeLine(new Array(45).join('-'));
    persons = createManyPersons();
    persons.forEach(function (item) {
        item.printFull();
    });
    jsConsole.writeLine(new Array(45).join('-'));
    return persons;
}

function makePerson(fname, lname, age, gender) {
    return {
        firstname: fname,
        lastname: lname,
        age: age,
        gender: gender,
        printFull: function () {
            jsConsole.writeLine( this.firstname + ' ' + this.lastname + ', ' + this.age + ' years old, ' + this.gender);
        },
        toString: function () {
            return this.firstname + ' ' + this.lastname ;
        },       
    };
}

function createManyPersons() {
    var i,
        personsArray = [],
        firstNames = ['Pavel', 'Milena', 'Sandy', 'Mindi', 'Sali', 'Lenka', 'Slavei', 'Mimi', 'Stefcho', 'Ani'],
        lastNames = ['Lenkov', 'Vo', 'Rivera', 'Mindilq', 'Salov', 'Salvador', 'Peevski', 'Peneva', 'Kecov', 'Dudova'];

    for (i = 0; i < 10; i += 1) {
        personsArray[i] = makePerson(firstNames[i], lastNames[i], Math.floor((Math.random() * 100) + 1), ((i % 2) ? 'female' : 'male'));
    }
    return personsArray;
}

// Problem 2

function task2() {
    var areOnlyAdults = persons.every(function (item) {
        return item.age >= 18;
    });
    jsConsole.writeLine('Are all adults? --> ' + areOnlyAdults);
    jsConsole.writeLine(new Array(45).join('-'));
}

// Problem 3

function task3() {
    jsConsole.writeLine('All underage persons : \n ');

    var allUnderage = persons.filter(function (person) {
        return person.age < 18;
    }).forEach(function(person) {
        person.printFull();
    });
    jsConsole.writeLine(new Array(45).join('-'));
}

// Problem 4

function task4() {
    var averageAgeFemales = persons.filter(function (person) {
        if (person.gender === 'female') {
            return person.age;
        }       
    }).reduce(function (sum, item,i, array) {
        var femaleCount = array.length;
        return ((sum + item.age) / femaleCount);
    }, 0);

    jsConsole.writeLine('The Average years of all females --> ' + averageAgeFemales.toFixed(2));
    jsConsole.writeLine(new Array(45).join('-'));
}

// Problem 5

function task5() {

    // First sort the persons by age ( from younger into older ) 
    var sortedPersons = persons.sort(function (first, second) {
        return first.age - second.age;
    });

    // Use the new method Find 
    var youngestPerson = sortedPersons.find(function (person) {
        if (person.gender === 'male') {           
            return person; 
        }
    });

    // Print the youngest !
    jsConsole.write('The youngest Man --> ');
    youngestPerson.printFull();
    jsConsole.writeLine(new Array(45).join('-'));
}

// Create a new method of Array - 'Find'
if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

// Problem 6

function task6() {
    var formatedResult = '';

    var resultObj = persons.reduce(function (obj, item) {
        if (obj[item.firstname[0]]) {
            obj[item.firstname[0]].push(item);
        } else {
            obj[item.firstname[0]] = [item];
        }
        return obj;
    }, {});

    for (var prop in resultObj) {
        formatedResult +=  prop + ': [' + resultObj[prop] + ']; ' + '<br>';
    }
    jsConsole.writeLine('Grouped by first letter of first name:' + '<br>'  + formatedResult);
    jsConsole.writeLine(new Array(45).join('-'));
}