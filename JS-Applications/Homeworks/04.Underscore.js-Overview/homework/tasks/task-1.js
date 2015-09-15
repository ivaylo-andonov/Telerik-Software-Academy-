/* 
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName` and `lastName` properties
*   **Finds** all students whose `firstName` is before their `lastName` alphabetically
*   Then **sorts** them in descending order by fullname
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   Then **prints** the fullname of founded students to the console
*   **Use underscore.js for all operations**
*/

//var Person = {
//    init: function (firstName, lastName, age) {
//        this.firstName = firstName;
//        this.lastName = lastName;
//       this.age = age;
//        this.fullname = function () {
//            return this.firstName + ' ' + this.lastName;
//        };
//        return this;
//    }
//};
//
//var students = [
//    Object.create(Person).init('Petar', 'Petrov', 35),
//    Object.create(Person).init('Penka', 'Minkova', 20),
//    Object.create(Person).init('Sliva', 'Sopoliva', 45),
//    Object.create(Person).init('Ivo', 'Andonov', 23),
//    Object.create(Person).init('Asparuh', 'Unufriev', 25),
//];

function solve(){
    
	var _ = require('./lib/underscore-min.js')
	
	return function(students){
		_.chain(students)
			.filter(function(student){
				return student.firstName < student.lastName;
			}).map(function(student) {
				return student.firstName + ' ' + student.lastName;
			}).sortBy(function(fullName){
				return fullName;
			})
			.reverse()
			.each(function(fullName){
				console.log(fullName);
			})
	}
}

//var result = solve();
//result(students);

module.exports = solve;