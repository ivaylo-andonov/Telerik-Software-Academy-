// JS PROTOTYPE INHERITANCE CHEAT SHEET v1.02 (abstract class missing...)
 
// - ANIMAL -------------------------------------------------
var animal = (function () {
    // HQ - tip ---> hidden functions on the top of the module
    function isInteger(value) {
        return value === parseInt(value, 10);
    }
 
    function throwIntegerError(type) {
        var message = type + ' must be an integer value';
 
        throw Error(message);
    }
 
    function checkName(nameToCheck) {
        if (!nameToCheck) {
            throw Error('Name missing!');
        }
 
        if (!nameToCheck.length || nameToCheck.length < 3) {
            throw  Error('Name must be at least 3 symbols!');
        }
    }
 
    function checkAge(age) {
        if (!age) {
            throw Error('Age missing!');
        }
 
        if (!isInteger(+age)) {
            throwIntegerError('Age');
        }
 
        if (!age < 0 || age > 150) {
            throw  Error('Invalid age - mus be between 0 ans  150');
        }
    }
 
    // function declared outside defineProperty and returned as value of the property!!
    function animalTestFunction(a, b) {
        return (a * b) + ' ' + this.name + ' - test func + this.name';
    }
 
    // -- Maybe more HQ way
    var animal = {};
 
    Object.defineProperty(animal, 'init', {
        value: function (name, age) {
            this.name = name;
            this.age = age;
            return this; // very important!!!
        },
        enumerable: true
    });
 
    // Not sure which is better defineProperty or defineProperties so the rest of them at once for the purpose the cheat sheet
 
    Object.defineProperties(animal, {
        'name': {
            get: function () {
                return this._name;
            },
            set: function (value) {
                checkName(value);
 
                this._name = value;
            }
        },
        'age': {
            get: function () {
                return this._age;
            },
            set: function (value) {
                checkAge(value);
 
                this._age = value;
            }
        },
        toString: {
            value: function () {
                return 'Animal I am, hmmm. ' + this.name + 'my name is.. ' + this.age + ' year I\'ve being...'
            }
        },
        onlyParentProp: {
            value: 'https://www.youtube.com/watch?v=8tb3RLqY9Xo',
            enumerable: true
        },
        animalTestFunc: {
            value: animalTestFunction,
            writable: false,
            enumerable: true// declared somewhere above - DO NOT use () when reference the function that way !!!!
        }
    });
 
// ---> Maybe not HQ way to make the object
 
    //var animal = {
    //    init: function (name, age) {
    //        this.name = name;
    //        this.age = age;
    //        return this; // very important!!!
    //    },
    //    get name() {
    //        return this._name;
    //    },
    //    set name(value) {
    //        checkName(value);
    //
    //        this._name = value;
    //    },
    //    get age() {
    //        return this._age;
    //    },
    //    set age(value) {
    //        checkAge(value);
    //
    //        this._age = value;
    //    },
    //    toString: function () {
    //        return 'Animal I am, hmmm. ' + this.name + 'my name is.. ' + this.age + ' year I\'ve being...'
    //    }
    //};
 
    return animal; // DO NOT FORGET TO RETURN THE OBJECT!!!!!
}());
 
// - MAMMAL -------------------------------------------------
var mammal = (function (parent) {
    // HQ - tip ---> hidden functions on the top of the module
    function checkToys(toy) {
        if (!toy || toy.length < 3) {
            throw new Error('I want my toys!!!')
        }
    }
 
// ---> Ste child __proto__ to be the parent __proto__
    var mammal = Object.create(parent);
 
// ---> 'HQ' way to declare properties  // parent can be assigned parent = {} ... Object.defineProperty/ies(parent, {....})
    Object.defineProperty(mammal, 'init', {
        value: function (name, age, legs, eyes) {
            parent.init.call(this, name, age);
            this.legs = legs;
            this.eyes = eyes;
            this._toys = [];
 
            return this; // very important!!!
        },
        enumerable: true
    });
 
    Object.defineProperty(mammal, 'toString', {
        value: function () {
            var baseResult = parent.toString.call(this);
 
            return baseResult + ' My legs, hmmmm ... ' + this.legs + '  they are.  I look at you with ' + this.eyes + ' eyes, hmmm ...'
        },
        enumerable: true
    });
 
    Object.defineProperties(mammal, {
        mammalPropOnly: {
            value: 'Try this - https://www.youtube.com/watch?v=dRcHTdWY5lU',
            enumerable: true
        },
        calcSumOfTwoIntegers: {
            value: function (a, b) {
                return (a + b) + ' ' + this.name + ' - calc sum + this.name';
            },
            enumerable: true
        }
    });
 
    Object.defineProperties(mammal, {
        addToy: {
            value: function (toy) {
                checkToys(toy);
 
                this._toys.push(toy);
                return this; // return this if you want to chain!!!
            },
            enumerable: true
        },
        getAllToys: {
            value: function () {
                return this._toys.slice(0); // It is a good to return slice of the private array!!!!
            },
            enumerable: true
        }
    });
 
// ---> Easier to write way to declare way .. (same as above) // BUT there are some bugs SO USE defineProperty/ies !!!!!
    // ---> NOT working when override toString for example, if in the parent is set with defineProperty !!!!
 
    //mammal.init = function(name, age, legs, eyes){
    //    parent.init.call(this, name, age);
    //    this.legs = legs;
    //    this.eyes = eyes;
    //
    //    return this; // very important!!!
    //};
    //
    //mammal.toString = function () {
    //    var baseResult = parent.toString.call(this);
    //
    //    return baseResult + ' My legs, hmmmm ... ' + this.legs + '  they are.  I look at you with ' + this.eyes + ' eyes, hmmm ...'
    //};
 
    return mammal; // DO NOT FORGET TO RETURN THE OBJECT!!!!!
}(animal));
 
// ---> Adding extra property after prototype initialisation and it works :)
//   ---> value: must be a function with return if you want to use this.something in the property/function!!!
Object.defineProperty(animal, 'say', {
        value: function () {
            return 'Say YO mf ' + this.name
        }
    }
);
 
//var someAnimal = Object.create(animal).init('Pesho', 18);
var someAnimal = Object.create(mammal).init('Pesho', 18, 4, 2);
var someAnotherAnimal = Object.create(mammal).init('Johnny', 16, 3, 2).addToy('Danbo').addToy('Homer').addToy('Bart');
console.log(Object.getPrototypeOf(mammal));
console.log(Object.getPrototypeOf(someAnimal));
console.log(someAnimal); // in the console shows only properties that are set as enumerable!!
console.log(someAnimal.toString());
console.log(someAnimal.say());
console.log(someAnimal.hasOwnProperty('_name'));
console.log(someAnimal.onlyParentProp);
console.log(someAnimal.mammalPropOnly);
console.log(someAnimal.calcSumOfTwoIntegers(1, 2));
console.log(mammal.calcSumOfTwoIntegers.call({name: ' Gosho is calling'}, 1, 2));
console.log(mammal.calcSumOfTwoIntegers.apply({name: ' Hohn is applying'}, [3, 5]));
console.log(someAnotherAnimal.animalTestFunc(2, 4));
console.log(mammal.calcSumOfTwoIntegers.call({name: ' Gosho is testing'}, 1, 2));
console.log(mammal.calcSumOfTwoIntegers.apply({name: ' Hohn is testing'}, [3, 5]));
console.log(someAnimal.animalTestFunc === someAnotherAnimal.animalTestFunc); // return TRUE !! nice - use one instance of the function :)
console.log(someAnimal.toString === someAnotherAnimal.toString); // return TRUE !! nice use one instance of the function :)
console.log(someAnotherAnimal.getAllToys());
 
for (var prop in someAnimal) {
    console.log(prop)
}