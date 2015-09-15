/*
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName`, `lastName` and `age` properties
*   **finds** the students whose age is between 18 and 24
*   **prints**  the fullname of found students, sorted lexicographically ascending
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

//var Person = {
//     init: function (firstName, lastName, age) {
//         this.firstName = firstName;
//         this.lastName = lastName;
//         this.age = age;
//         this.fullname = function () {
//             return this.firstName + ' ' + this.lastName;
//         };
//         return this;
//     }
// };
//
// var students = [
//     Object.create(Person).init('Petar', 'Petrov', 15),
//     Object.create(Person).init('Penka', 'Minkova', 20),
//     Object.create(Person).init('Sebastian', 'Leger', 18),
//     Object.create(Person).init('Sliva', 'Sopoliva', 45),
//	   Object.create(Person).init('Ivo', 'Andonov', 23),
//     Object.create(Person).init('Asparuh', 'Unufriev', 25),
// ];

function solve(){
	var _ = require('./lib/underscore-min.js')

    return function (students){
        _.chain(students)
            .filter(function(student){
				return 18 <= student.age && student.age <= 24;
			}).map(function(student){
				var fullName = student.firstName + ' ' + student.lastName;
				return fullName;
			}).sortBy(function(fullName){
				return fullName;
			}).each(function(fullName){
				console.log(fullName);
			})
    }
}

//var result = solve();
//result(students);

module.exports = solve;
