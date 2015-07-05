/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {

	var Student = (function () {

		var Student = {
			init: function (firstname, lastname, id) {
				this.firstname = firstname;
				this.lastname = lastname;
				this.id = id;
			}
		};

		Object.defineProperties(Student, {
			firstname: {
				get: function () {

					return this._firstname;
				},
				set: function (value) {
					validateStudentName(value);
					this._firstname = value;
					return this;
				}
			},
			lastname: {
				get: function () {

					return this._lastname;
				},
				set: function (value) {
					validateStudentName(value);
					this._lastname = value;
					return this;
				}
			}
		});

		function validateStudentName(value) {

			var namePattern = /^[A-Z]{1}[a-z]*/;

			if (!namePattern.test(value)) {
				throw {message: 'You have entered an invalid name'};
			}
		}

		return Student;
	}());

	var Course = {
		init: function (title, presentations) {
			this.id = 0;
			this.title = title;
			this.presentations = presentations;
			this.students = [];
			return this;
		},
		addStudent: function (name) {

			validateIfStringIsPassed(name);

			var names = name.split(' ');

			if (names.length > 2) {
				throw {message: 'Students must have only two names'};
			}

			var firstName = names[0].trim(),
				lastName = names[1].trim(),
				objToPush = Object.create(Student);

			this.id += 1;

			objToPush.init(firstName, lastName, this.id);

			this.students.push(objToPush);
			return objToPush.id;
		},
		getAllStudents: function () {
			return this.students.slice();
		},
		submitHomework: function (studentID, homeworkID) {

			validateIDs(this, studentID, homeworkID);
			return this;
		},
		pushExamResults: function (results) {

			// Just validation no actual functionality
			validateResults(this, results);

		},
		getTopStudents: function () {
			throw {message: 'Not implemented'};
		}
	};

	Object.defineProperties(Course, {
		title: {
			get: function () {

				return this._title;
			},
			set: function (value) {

				validateIfStringIsPassed(value);
				validateWhiteSpace(value);
				this._title = value;
				return this;
			}
		},
		presentations: {
			get: function () {
				return this._presentations.slice();
			},
			set: function (value) {

				validatePresentations(value);
				this._presentations = value;
				return this;
			}
		}
	});

	function validateIfStringIsPassed(value) {

		if (!value) {
			throw {message: 'Title can not be an empty string'};
		}

		if (typeof value !== 'string') {
			throw {message: 'You need to pass a string as title'};
		}
	}

	function validateWhiteSpace(value) {

		var whiteSpacePattern = /^\s|[\s]{2,}|\s+$/;

		if (whiteSpacePattern.test(value)) {
			throw {message: 'The title can not start or end with white-space'};
		}
	}

	function validatePresentations(value) {

		if (!Array.isArray(value)) {
			throw {message: 'You must pass an Array as argument'};
		}

		if (value.length < 1) {
			throw {message: 'You can not pass an empty Array'};
		}

		value.forEach(function (element) {

			validateIfStringIsPassed(element);
			validateWhiteSpace(element);
		});
	}

	function validateIDs(object, studentID, homeworkID) {

		if (studentID > object.students.length || studentID < 1) {

			throw {message: 'Invalid Student ID'};
		}

		if (homeworkID > object.presentations.length || homeworkID < 1) {
			throw {message: 'Invalid Homework ID'};
		}
	}

	function validateResults(course, results){

		var i,
			j,
			len,
			checkId;

		if (!Array.isArray(results)) {
			throw {message: 'You must pass an Array as argument'};
		}

		for (i = 0, len = results.length; i < len; i += 1) {
			checkId = results[i].StudentID;
			for (j = i + 1, len = results.length; j < len; j += 1) {
				if (checkId === results[j].StudentID) {
					throw {message: 'Dupliacting IDs'};
				}
			}
		}

		results.some(function(object) {
			if(typeof object.StudentID !== 'number') {
				throw {message: 'Student ID must be a number'};
			}
			if (object.StudentID < 0 || object.StudentID > course.id) {

				throw {message: 'Invalid Student ID in the course database'};
			}
			if (!object.hasOwnProperty('score')) {
				throw {message: 'Score is missing'};
			}
			if (!object.hasOwnProperty('StudentID')) {
				throw {message: 'Student is missing'};
			}
		});
	}

	return Course;
}

module.exports = solve;
