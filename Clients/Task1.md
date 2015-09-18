**How to:  Select elements with JQuery by ID or by ClassName **
--------------------------------------------------------------

If you need to select some DOM element by ID or className using JQuery you have to follow several steps, described below:

 1. Firstable, you must be sure, that jquery library is imported in your project properly.
 
 Example:

        <script src="jquery.min.js"></script>


 2. In your script, you should use the jquery special sign "$" , before the element you want.After that, in the brackets you write in quotes the element`s name as previously, use '#' for selecting by ID or use '.' for selecting by ClassName.
 
 Examples:
	- by using ID:
    ```function hideAllContent() {
                $('#home-page-content').hide();
    }```
    
    - by using class name:
    ```function hideAllContent() {
                $('.home-page-content').hide();
    }```
    
    
For more information you can read detailed documentation for JQuery library [HERE](https://learn.jquery.com/using-jquery-core/selecting-elements/)  .

In case, it`s still not working, contact us:

- E-mail : academy@telerik.com
- Forum : http://www.telerik.com/forums

Regards!
Telerik Academy
 