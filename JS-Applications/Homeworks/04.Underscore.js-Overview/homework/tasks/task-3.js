/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName` and `age` properties
        *   Array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

//var Person = {
//     init: function (firstName, lastName, age, marks) {
//         this.firstName = firstName;
//         this.lastName = lastName;
//         this.age = age;
//		   this.marks = marks;
//
//         return this;
//     }
// };
//
// var students = [
//     Object.create(Person).init('Petar', 'Petrov', 15, [2,4,5]),
//     Object.create(Person).init('Penka', 'Minkova', 20, [2,2,5,4]),
//     Object.create(Person).init('Sebastian', 'Leger', 18, [5,5,6,6]),
//     Object.create(Person).init('Sliva', 'Sopoliva', 45, [3,5,5,6]),
//	   Object.create(Person).init('Ivo', 'Andonov', 23, [3,3,5,2]),
//     Object.create(Person).init('Asparuh', 'Unufriev', 25, [6,3]),
// ];

function solve(){
	var _ = require('./lib/underscore-min.js')
	
    return function (students) {
		var foundStudent = _.chain(students)
	     .each(function(student){
			 student.averigeMark = function(){
				 var marksSum = _.reduce(this.marks, function (sum, mark) {
                    return sum + mark;
                }, 0);
                return marksSum / this.marks.length;
			 }
		 })
		 .max(function(student){
			 return student.averigeMark();
		 })
		 .value();
	     console.log(foundStudent.firstName + ' ' + foundStudent.lastName + ' has an average score of ' + foundStudent.averigeMark());
  };
}

//var result = solve();
//result(students);

module.exports = solve;
