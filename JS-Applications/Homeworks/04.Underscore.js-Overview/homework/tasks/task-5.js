/* 
 Create a function that:
 *   **Takes** an array of animals
 *   Each animal has propeties `name`, `species` and `legsCount`
 *   **finds** and **prints** the total number of legs to the console in the format:
 *   "Total number of legs: TOTAL_NUMBER_OF_LEGS"
 *   **Use underscore.js for all operations**
 */

//var Animal = {
//    init: function (name, species, legsCount) {
//        this.name = name;
//        this.species = species;
//        this.legsCount = legsCount;
//
//        return this;
//    }
//};
//
//var animals = [
//    Object.create(Animal).init('Horse', 'mammal', 4),
//    Object.create(Animal).init('Calamari', 'fish', 0),
//    Object.create(Animal).init('Bug', 'insect', 6),
//    Object.create(Animal).init('Cow', 'mammal', 4),
//    Object.create(Animal).init('Spider', 'insect', 8),
//    Object.create(Animal).init('Dolphin', 'mammal', 0)
//];

function solve() {
    var _ = require('./lib/underscore-min.js');
    return function (animals) {
        var totalSumOfLEgs = 0;
        _.each(animals, function(animal){
            totalSumOfLEgs += animal.legsCount;
        });
        console.log("Total number of legs: " + totalSumOfLEgs);
    };
}

//var result = solve();
////result(animals);

module.exports = solve;
