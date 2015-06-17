/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
    var library = (function () {

        var books = [];
        var categories = {};

        function listBooks() {
            books = books.sort(function (a, b) { return a.ID - b.ID });
            return books;
        }

        function addBook(title, author, ISBN, category) {
            if (!category) {
                category = 'Action';
            }
            if (title.length < 2 || title.length > 100) {
                throw new Error('Must be between 2-100 chars');
            }
            if (category.length < 2 || category.length > 100) {
                throw new Error('Must be between 2-100 chars');
            }
            if (author.length < 1 || author === undefined) {
                throw new Error('Must be non-empty');
            }
            if (ISBN.lengt !== 10 || ISBN.length !== 13) {
                throw new Error('Must be 10 or 13 digits');
            }
            var book = {
                title: title,
                author: author,
                isbn: ISBN,
                category: category,
                ID: function () {
                    // Math.random should be unique because of its seeding algorithm.
                    // Convert it to base 36 (numbers + letters), and grab the first 9 characters
                    // after the decimal.
                    return ''  + Math.random().toString(36).substr(2, 9);
                }
            };
            books.push(book);
            if (!categories[book.category]) {
                categories[book.category] = book;
            }
            return book;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
module.exports = solve;
