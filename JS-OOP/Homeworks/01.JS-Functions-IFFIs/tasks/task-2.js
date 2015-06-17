// Write a function that finds all the prime numbers in a range
// It should return the prime numbers in an array
// It must throw an Error if any of the range params is not convertible to Number
// It must throw an Error if any of the range params is missing

function findPrimes(start, end) {
    if(arguments.length < 2) {
        throw  new Error('The function should has start and end parameters.');
    } else if (!isNumber(start) || !isNumber(end)) {
        throw  new Error('The start and end parameters must be a numbers.');
    } else {
        var primeNumbers = [],
            number;
        start = start * 1;
        end = end * 1;

        for(number = start; number <= end; number += 1) {
            if(isPrime(number)) {
                primeNumbers.push(number);
            }
        }
        return primeNumbers;
    }

    function isNumber(n) {
		return !isNaN(parseFloat(n)) && isFinite(n);
    } 

    function isPrime(number) {
        var maxDivider = Math.sqrt(number),
            isPrime = true,
            currentDivider;

        if(number < 2) {
            return false;
        }
        for(currentDivider = 2; currentDivider <= maxDivider; currentDivider += 1) {
            if(!(number % currentDivider)) {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }	
}

module.exports = findPrimes;