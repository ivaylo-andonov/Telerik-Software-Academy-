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

        var books = [],
            categories = [];

        function checkExistingParams(name, type) {
            for (var i = 0, len = books.length; i < len; i += 1) {
                if (books[i][type] === name) {
                    return true;
                }
            }
            return false;
        }
        // Creat category
        function addCategory(name) {
            categories[name] = {
                books: [],
                ID: categories.length + 1
            };
        }

        function listBooks(bookProperty) {
            // check if empty array
            if (books.length === 0) {
                return books;
            }
            if (bookProperty !== undefined) {
                // check if sorting by certain category
                if (bookProperty.category !== undefined) {
                    return books.filter(function (book) {
                        if (book.category === bookProperty.category) {
                            return book;
                        }
                    });
                }
                // check if sorting by certain author
                if (bookProperty.author !== undefined) {
                    return books.filter(function (book) {
                        if (book.author === bookProperty.author) {
                            return book;
                        }
                    });
                }
            }
            return books;
        }

        function addBook(book) {
            
            // Validations
            if (checkExistingParams(book.title, 'title')) {
                throw new Error('Existing Title');
            }
            if (checkExistingParams(book.isbn, 'isbn')) {
                throw new Error('Existing ISBN');
            }
            if (book.title.length < 2 || book.title.length > 100) {
                throw new Error('Must be between 2-100 chars');
            }
            if (book.category.length < 2 || book.category.length > 100) {
                throw new Error('Must be between 2-100 chars');
            }
            if (book.author === '') {
                throw new Error('Author Must be non-empty');
            }
            if (book.isbn.length !== 13 && book.isbn.length !== 10) {
                throw new Error('ISBN should be between 10 or 13 digits');
            }
            // If this category does not exist, automatically create it
            if (categories.indexOf(book.category) < 0) {
                addCategory(book.category);
            }

            // Create book ID
            book.ID = books.length + 22;
            // Add book into books array
            books.push(book);
            // Add book into the same category like the book is
            categories[book.category].books.push(book);

            return book;
        }

        function listCategories() {
            var namesOfCategories = [];

            // Sort categories by ID
            categories.sort(function (a, b) {
                return a.ID - b.ID;
            });

            // Should return only categories`names ( seen from unit tests)
            Array.prototype.push.apply(namesOfCategories, Object.keys(categories));

            return namesOfCategories;
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
