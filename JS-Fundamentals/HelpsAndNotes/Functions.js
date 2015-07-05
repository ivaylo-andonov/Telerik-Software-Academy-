// String to char Array
if (!String.prototype.toCharArray) {
		String.prototype.toCharArray = function () {
			return this.split('');
		}
	}

// Trim left
if (!String.prototype.trimLeft) {
	String.prototype.trimLeft = function () {
		return this.replace(/^\s+/, '');
	}
}

// Trim right
if (!String.prototype.trimRight) {
	String.prototype.trimRight = function () {
		return this.replace(/\s+$/, '');
	}
}

// Trim whitespaces
if (!String.prototype.trim) {
	String.prototype.trim = function () {
		return this.trimLeft().trimRight();
	}
}

// Trim leftChars
if (!String.prototype.trimLeftChars) {
	String.prototype.trimLeftChars = function (chars) {
		var regEx = new RegExp('^[' + chars + ']+');
		return this.replace(regEx, '');
	}
}

// Trim right chars
if (!String.prototype.trimRightChars) {
	String.prototype.trimRightChars = function (chars) {

		var regEx = new RegExp('[' + chars + ']+$');
		return this.replace(regEx, '');
	}
}

// Trim chars
if (!String.prototype.trimChars) {
	String.prototype.trimChars = function (chars) {
		return this.trimLeftChars(chars).trimRightChars(chars);
	}
}

// Padleft
if (!String.prototype.padLeft) {
	String.prototype.padLeft = function (count, char) {
		char = char || ' ';
		if (char.length > 1) {
			return String(this);
		}
		if (this.length >= count) {
			return String(this);
		}
		var str = String(this);
		for (var i = 0, thisLen = str.length; i < count - thisLen; i++) {
			str = char + str;
		}
		return str;
	}
}

// Padright
if (!String.prototype.padRight) {
	String.prototype.padRight = function (count, char) {
		char = char || ' ';
		if (char.length > 1) {
			return String(this);
		}
		if (this.length >= count) {
			return String(this);
		}
		var str = String(this);
		for (var i = 0, thisLen = this.length; i < count - thisLen; i++) {
			str += char;
		}
		return str;
	}
}

// Get all words in text with trimmed ""
function getWords(text) {
			var words = text.split(/[\s\.,-?!)(]/),
				i;

			for (i = 0; i < words.length; i++) {
				if (words[i] == "") {
					words.splice(i, 1);
				}
			}
			return words;
		}

//Delete tags in text
function removeTags(text) {
	for (var j = 0; j < text.length; j++) {
		var indexStart = text.indexOf('<');
		var indexEnd = text.indexOf('>');
		text = (text.replace(text.substring(indexStart, indexEnd + 1),''));// trii tagovete
	}
	return  text
}

// Get tag name
function getTagName(text) {
	var tagName='';
	for (var i = 0; i < text.length; i++) {
		var indexStart = text.indexOf('>');
		var indexEnd = text.indexOf('<');
		tagName = text.substring(indexStart, indexEnd + 1);   
	}
	return tagName;
}

// Text between tags
function textBetweenTags(text) {
	var textBetweenTags='';
	for (var i = 0; i < text.length; i++) {
		var indexStart = text.indexOf('>');
		var indexEnd = text.indexOf('</');
		textBetweenTags = text.substring(indexStart+1, indexEnd );
	}
	return textBetweenTags;
}

//Convert mixedCase word
function convertWordUpcaseAndLowcase(text) {
	text=text.split('');
	var word='';
	for (var i =0;i<text.length;i++) {
		if (i%2===0) {
			word+= text[i].toUpperCase();
		}
		else {
			word += text[i];
		}
	}
	return word;
}

//Broi vsichki savpadenia na tyrsenia string bez znachenie sliato ili ne
function countStringOccuranceInText(text, pattern) { 
	text = text.toLowerCase();
	var count = 0;
	for (var i = 0; i < text.length; i++) {
		text = text.replace(pattern, "*");
		if (text[i] === '*') {
			count++;
		}
	}
	return count;
}


// Removes the first element found from left to right in the array
// Second argument should be truthy to remove all elements

// Remove element/s from Array
Array.prototype.remove = function(arg, all){
    for(var i = 0; i < this.length; i++){
        if(this[i] === arg){
            this.splice(i,1);

            if(!all)
                break;
            else
                i--;
        }
    }
};

[].removeAt(pos)
// Removes the element at the position
Array.prototype.removeAt = function(position){
    this.splice(position,1);
};

[].clear()
// Removes all elements of the array
Array.prototype.clear = function(){
    this.length = 0;
};

[].insertAt(arg, pos)
// Inserts an element at a given position
Array.prototype.insertAt = function(arg, position){
    this.splice(position, 0, arg);
};

[].occurs(arg)
// Counts the occurrences of a given element in array
Array.prototype.occurs = function(arg){
    var counter = 0;

    for(var i = 0; i< this.length; i++){
        if(this[i] === arg)
            counter++;
    }

    return counter;
};

[].contains(arg)
// Checks if the array contains the given element
Array.prototype.contains = function(arg){
    for(var i = 0; i < this.length; i++)
        if(this[i] === arg)
            return true;
    return false;
};

// Method .Contains() with start and end points
function contains(arr, value, start, end) {
			var i,			
			start = start || 0,
			end = end || arr.length;

			for (i = start; i < end; i++) {
				if (arr[i] === value) {
					return true;
				}
			}			
			return false;
		}

		
// Check is number
function isNumber(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}

// Fill the matrix
var matrix = [], rows = 5, cols = 5 ,row , col , count = 0 ;
for(row = 0; row < rows; row += 1) {
     matrix.push( [] );
      for ( col = 0; col < cols; col += 1){
           matrix[row][col] = count;
           count += 1;
     }
}		

// Copy arrays	
var numbers = [5, 6, 7, 8, 9];
var copy = numbers.slice();
numbers[1] = 100;
//console.log(numbers); // [5,100,7,8,9];
//console.log(copy); // [5,6,7,8,9];

	
// Is null ot empty
function isEmpty(string) {
        return (string.length === 0 || !string.trim());
    };
	
	
// Remove empty strings (trashes) from splitting in array
array = array.filter(function(item){
   return !!item;
})


// IsLetter
function isLetter(symbol) {
	var asciiCode = symbol.charCodeAt(0);
	if ((asciiCode > 64 && asciiCode < 91) || (asciiCode > 96 && asciiCode < 123)) {
		return true;
	}
	return false;
}

// isDigit
function isDigit(symbol) {
	var asciiCode = symbol.charCodeAt(0);
	if (asciiCode > 47 && asciiCode < 58)  {
		return true;
	}
	return false;
}

// Math.pow(2,number) :  (1 << number); ->  THE SAME,but faster
  	
// Math.floor : 22.3 | 0 (22)

// Math.Round : 22.3 + 0.5 | 0 ->(22) , 22.6 + 0.5 | 0 -> (23)
	
