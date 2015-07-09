var factory = (function () {
    function validateString(value, minLenght, type) {
        if (typeof (value) !== 'string') {
            throw new Error('Name must be a string!');
        }

        if (value.length < minLenght) {
            throw new Error(type + ' must be at least ' + minLenght + ' symbols!');
        }
    }

    var teacher = (function () {
        var teacher = {};
        var courses = [];

        function validateAddingCourse(course) {
            if (typeof course === 'undefined') {
                throw new Error('Cannot add undefined in courses');
            }

            if (!course.name) {
                throw new Error('Cannot add undefined in courses');
            }
        }

        Object.defineProperty(teacher, 'init', {
            value: function (name) {
                courses = [];
                this.name = name;
                return this;
            }
        });

        Object.defineProperty(teacher, 'addCourse', {
            value: function (course) {
                validateAddingCourse(course);

                courses.push(course);
                return this;
            }
        });

        Object.defineProperty(teacher, 'name', {
            get: function () {
                return this._name;
            },
            set: function (value) {
                validateString(value, 3, 'Name');
                this._name = value;
            }
        });

        Object.defineProperty(teacher, 'toString', {
            value: function () {
                var result = 'Teacher: Name=' + this.name;

                if (courses.length > 0) {
                    result += '; Courses=[';
                    for (var i = 0, len = courses.length; i < len; i += 1) {
                        result += courses[i].name;
                        if (i !== len - 1) {
                            result += ', ';
                        }
                    }

                    result += ']';
                }

                return result;
            }
        });

        return function (name) {
            return Object.create(teacher)
                .init(name);
        };
    }());

    var course = (function () {
        var course = {},
            topics = [];

        Object.defineProperty(course, 'init', {
            value: function (name, teacher) {
                topics = [];
                var that = this;
                that.name = name;
                that.teacher = teacher;

                return that;
            }
        });

        Object.defineProperty(course, 'name', {
            get: function () {
                return this._name;
            },
            set: function (value) {
                validateString(value, 2, 'Name');

                this._name = value;
            }
        });

        Object.defineProperty(course, 'addTopic', {
            value: function (topic) {
                validateString(topic, 2, 'Topic');

                topics.push(topic);
                return this;
            }
        });

        Object.defineProperty(course, 'toString', {
            value: function () {
                var result = 'Name=' + this.name;

                if (this.teacher) {
                    result += '; Teacher=' + this.teacher.name;
                }

                if (topics.length > 0) {
                    result += '; Topics=[' + topics.join(', ') + ']';
                }
                return result;
            }
        });

        return course;
    }());

    var localCourse = (function (parent) {
        var localCourse = Object.create(parent);

        Object.defineProperty(localCourse, 'init', {
            value: function (name, teacher, lab) {
                var that = this;
                parent.init.call(that, name, teacher);
                that.lab = lab;
                return that;
            }
        });

        Object.defineProperty(localCourse, 'toString', {
            value: function () {
                var result = 'LocalCourse: ' + parent.toString.call(this) + '; Lab=' + this.lab;

                return result;
            }
        });

        return function (name, teacher, lab) {
            return Object.create(localCourse)
                .init(name, teacher, lab)
        };
    }(course));

    var offsiteCourse = (function (parent) {
        var offsiteCourse = Object.create(parent);

        Object.defineProperty(offsiteCourse, 'init', {
            value: function (name, teacher, town) {
                var that = this;
                parent.init.call(that, name, teacher);
                that.town = town;
                return that;
            }
        });

        Object.defineProperty(offsiteCourse, 'toString', {
            value: function () {
                var result = 'OffsiteCourse: ' + parent.toString.call(this) + '; Town=' + this.town;

                return result;
            }
        });

        return function (name, teacher, lab) {
            return Object.create(offsiteCourse)
                .init(name, teacher, lab)
        };
    }(course));

    return {
        createTeacher: teacher,
        createLocalCourse: localCourse,
        createOffsiteCourse: offsiteCourse
    };
}());

var result = '';

var factory = Object.create(factory);
var nakov = factory.createTeacher('Nakov');
console.log(nakov.toString());
result += nakov.toString();

nakov.name = 'Svetlin Nakov';
var oop = factory.createLocalCourse('OOP', nakov, 'Light');
oop.addTopic('Using Classes and Objects')
   .addTopic('Defining Classes')
   .addTopic('OOP Principles')
   .addTopic('Teamwork')
   .addTopic('Exam Preparation');
console.log(oop.toString());
result += oop.toString();

var html = factory.createOffsiteCourse('HTML', nakov, 'Plovdiv');
html.addTopic('Using Classes and Objects')
    .addTopic('Defining Classes')
    .addTopic('OOP Principles')
    .addTopic('Teamwork')
    .addTopic('Exam Preparation');
console.log(html.toString());
result += html.toString();

nakov.addCourse(oop)
     .addCourse(html);
console.log(nakov.toString());
result += nakov.toString();

oop.name = 'Object-Oriented Programming';
oop.lab = 'Enterprise';
oop.teacher = factory.createTeacher('George Georgiev');
oop.addTopic('Practical Exam');
console.log(oop.toString());
result += oop.toString();

html.name = 'HTML Basics';
html.town = 'Varna';
html.teacher = oop.teacher;
console.log(html.toString());
result += html.toString();

var css = factory.createLocalCourse('CSS', null, 'Ultimate');
console.log(css.toString());
result += css.toString();

var expected = 'Teacher: Name=NakovLocalCourse: Name=OOP; Teacher=Svetlin Nakov; Topics=[Using Classes and Objects, Defining Classes, OOP Principles, Teamwork, Exam Preparation]; Lab=LightOffsiteCourse: Name=HTML; Teacher=Svetlin Nakov; Topics=[Using Classes and Objects, Defining Classes, OOP Principles, Teamwork, Exam Preparation]; Town=PlovdivTeacher: Name=Svetlin Nakov; Courses=[OOP, HTML]LocalCourse: Name=Object-Oriented Programming; Teacher=George Georgiev; Topics=[Using Classes and Objects, Defining Classes, OOP Principles, Teamwork, Exam Preparation, Practical Exam]; Lab=EnterpriseOffsiteCourse: Name=HTML Basics; Teacher=George Georgiev; Topics=[Using Classes and Objects, Defining Classes, OOP Principles, Teamwork, Exam Preparation, Practical Exam]; Town=VarnaLocalCourse: Name=CSS; Lab=Ultimate';

console.log(result === expected);