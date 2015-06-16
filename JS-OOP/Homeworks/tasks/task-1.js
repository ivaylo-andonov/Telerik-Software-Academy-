// Write a function that sums an array of numbers:
// Numbers must be always of type Number
// Returns null if the array is empty
// Throws Error if the parameter is not passed (undefined)
// Throws if any of the elements is not convertible to Number
function sums(numbers) {
	   if(numbers === undefined) {
			throw new Error('The array cannot be undefined.');
		} else if(!numbers.length){
			return null;
		} 
		else {
			if (!numbers.every(function(item) {
                return !isNaN(item);
            })) {
				throw new Error('All elements must be numbers.');
			}
			return numbers.reduce(function(sum, num) {
				return sum + num * 1;
			}, 0);
		}
	}
module.exports = sums;