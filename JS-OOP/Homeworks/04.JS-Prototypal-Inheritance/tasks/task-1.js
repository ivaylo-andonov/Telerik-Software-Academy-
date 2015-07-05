/*
  Task 1.
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
	  * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * // method removeAttribute(attribute)

Example:
  
  var meta = Object.create(domElement)<br/>
  	.init('meta')<br/>
  	.addAttribute('charset', 'utf-8');
  
  var head = Object.create(domElement)<br/>
  	.init('head')<br/>
  	.appendChild(meta)
  
  var div = Object.create(domElement)<br/>
  	.init('div')<br/>
  	.addAttribute('style', 'font-size: 42px');
  
  div.content = 'Hello, world!';
  
  var body = Object.create(domElement)<br/>
  	.init('body')<br/>
  	.appendChild(div)<br/>
  	.addAttribute('id', 'cuki')<br/>
  	.addAttribute('bgcolor', '#012345');
  
  var root = Object.create(domElement)<br/>
  	.init('html')<br/>
  	.appendChild(head)<br/>
  	.appendChild(body);
  
  console.log(root.innerHTML);

 Outputs:

 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */

function solve() {
    var domElement = (function () {
        function isValidType(type) {
            var regex = /^[a-z0-9]+$/gi;

            if (typeof type !== 'string') {
                return false;
            }

            return regex.test(type);
        }

        function isValidAttributeName(name) {
            var regex = /^[a-z0-9\-]+$/gi;

            return regex.test(name);
        }

        function sortAttributes(attributes) {
            var sorted = attributes.slice(0);

            sorted.sort(function (a, b) {
                if (a.name === b.name) {
                    return 0;
                }
                return a.name > b.name ? 1 : -1;
            });

            return sorted;
        }

        var domElement = {
            init: function (type) {
                this.type = type;
                this.content = '';
                this.attributes = [];
                this.children = [];
                this.parent = '';

                return this;
            },
            appendChild: function (child) {
                this.children.push(child);

                if (typeof child === 'object') {
                    child.parent = this;
                }

                return this;
            },
            addAttribute: function (name, value) {
                var attribute = {},
                    currentAttribute,
                    isTheSameName = false;

                if (!isValidAttributeName(name)) {
                    throw new Error('The name of the attribute should be a non-empty string that contains only Latin letters and digits or dashes!');
                }

                attribute.name = name;
                attribute.value = value;

                for (var i = 0; i < this.attributes.length; i++) {
                    currentAttribute = this.attributes[i];
                    if (name === currentAttribute.name) {
                        currentAttribute.value = value,
                            isTheSameName = true;
                    }
                }

                if (!isTheSameName) {
                    this.attributes.push(attribute);
                }

                return this;
            },
            removeAttribute: function (attributeName) {
                var index;
                for (var i = 0; i < this.attributes.length; i++) {
                    if (this.attributes[i].name === attributeName) {
                        index = i;
                        break;
                    }
                }

                if (index !== undefined) {
                    this.attributes.splice(index, 1);
                } else {
                    throw new Error('There is no such attribute!');
                }

                return this;
            },
            get type() {
                return this._type;
            },
            set type(value) {
                if (!isValidType(value)) {
                    throw new Error('The valid type should be non-empty string that contains only Latin letters and digits!');
                }
                this._type = value;
            },
            get innerHTML() {
                var result = '',
                    child;

                result += '<' + this.type;

                if (this.attributes.length) {
                    var sortedAttributes = sortAttributes(this.attributes),
                        element;

                    for (var i = 0; i < sortedAttributes.length; i++) {
                        element = sortedAttributes[i];
                        result += ' ' + element.name + '="' + element.value + '"';
                    }
                }

                result += '>';

                if (this.children.length) {
                    for (var i = 0; i < this.children.length; i++) {
                        child = this.children[i];
                        if (typeof child === 'string') {
                            result += child;
                        } else {
                            result += child.innerHTML;
                        }

                    }
                } else {
                    result += this.content;
                }

                result += '</' + this.type + '>';

                return result;
            },
            get content() {
                if (this.children.length) {
                    return '';
                }

                return this._content;
            },
            set content(value) {
                this._content = value;
            },
            get attributes() {
                return this._attributes;
            },
            set attributes(value) {
                this._attributes = value;
            },
            get children() {
                return this._children;
            },
            set children(value) {
                this._children = value;
            },
            get parent() {
                return this._parent;
            },
            set parent(value) {
                this._parent = value;
            }
        };

        return domElement;
    }());

    return domElement;
}

module.exports = solve;