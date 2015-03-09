# Red dragon Team

# Chicken eggs
# Console Project Game


List of team members:
 
Jenia Racheva	 - zhenia.racheva 	
   
Ivaylo Andonov	 - IvayloAndonov 	   

Andrei Boiadjiev	 - ahansb	
   
Martin Atanasov	 - jumarto	
   
Iliana Antova	 - iliant	
   
Boian Minchev	 - bminchev	   

Angel Tosev	 - angel.tosev.5	
   
Emil Tishinov	 - emil_t	 

The player controls basket at the bottom of the screen of the console. From the top of the console screen moving objects are created randomly and they move from the top of the screen to the bottom of the screen. The objects are several types.

When the player collect:
Egg – the player receives 20 points.
Green shit – increases the speed of the falling objects with 20 km/h.
Purple shit – decreases the speed of the falling objects with 20 km/h.
Bomb – decreases the Lives variable with 1;
The objects are written in separated class files. Every object has row, col, color and vision. When these objects are created they are stored in falliingThings list from which they will be called. After the entering the name of the player an infinite while loop starts which continue until the variable lives is equal to 0. On every iteration of the loop a check is done whether the player’s basket coordinates matches with some of the moving objects that appear from the top of the screen. New objects are created at the method InitiallyAddingRocks() which calls GenerateFigure(). 
A random generator is used to create one of the 4 types of objects. If the variable lives is equal to 0 the program open method entrance(). It starts with a check for a recorded high scores in the text file scores.txt. If there is such data it is stored in three lists – points, names and dates. After that another check is done whether the current score is bigger than the scores of the list. If it is – the smallest score from the list is removed and the new score is added. 
 
GitHub repository:
https://github.com/IvayloAndonov/TeamWorkProjectCSharp2/commits/master
