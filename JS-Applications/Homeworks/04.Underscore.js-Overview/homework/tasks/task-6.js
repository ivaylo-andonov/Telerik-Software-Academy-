/* 
 Create a function that:
 *   **Takes** a collection of books
 *   Each book has propeties `title` and `author`
 **  `author` is an object that has properties `firstName` and `lastName`
 *   **finds** the most popular author (the author with biggest number of books)
 *   **prints** the author to the console
 *	if there is more than one author print them all sorted in ascending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (books) {
        var groupedByAuthor = _.chain(books)
            .map(function (book) {
                book.author.fullname = book.author.firstName + ' ' + book.author.lastName;

                return book;
            })
            .groupBy(function (book) {
                return book.author.fullname;
            })
            .value();

        var maxBooks = _.max(groupedByAuthor, 'length').length;
        var authorsWithMaxBooks = _.chain(groupedByAuthor)
            .filter(function (books) {
                return books.length === maxBooks;
            })
            .sortBy(function (books) {
                return books[0].author.fullname;
            })
            .value();


        _.each(authorsWithMaxBooks, function (books) {
            console.log(books[0].author.fullname);
        });
    };
}

module.exports = solve;
