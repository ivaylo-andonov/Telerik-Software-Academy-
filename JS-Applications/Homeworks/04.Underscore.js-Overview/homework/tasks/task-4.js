/* 
 Create a function that:
 *   **Takes** an array of animals
 *   Each animal has propeties `name`, `species` and `legsCount`
 *   **groups** the animals by `species`
 *   the groups are sorted by `species` descending
 *   **sorts** them ascending by `legsCount`
 *	if two animals have the same number of legs sort them by name
 *   **prints** them  the console in the format:

 ```
 ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
 GROUP_1_NAME:
 ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
 NAME has LEGS_COUNT legs //for the first animal in group 1
 NAME has LEGS_COUNT legs //for the second animal in group 1
 ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
 GROUP_2_NAME:
 ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
 NAME has LEGS_COUNT legs //for the first animal in the group 2
 NAME has LEGS_COUNT legs //for the second animal in the group 2
 NAME has LEGS_COUNT legs //for the third animal in the group 2
 NAME has LEGS_COUNT legs //for the fourth animal in the group 2
 ```
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

//var animals = [
//    Object.create(Animal).init('Horse', 'mammal', 4),
//    Object.create(Animal).init('Calamari', 'fish', 0),
//    Object.create(Animal).init('Bug', 'insect', 6),
//    Object.create(Animal).init('Cow', 'mammal', 4),
//    Object.create(Animal).init('Spider', 'insect', 8),
//    Object.create(Animal).init('Dolphin', 'mammal', 0)
//];

function solve() {
	
	String.prototype.repeat = function (count) {
    count = count || 1;
    return Array(count + 1).join(this);
};

    var _ = require('./lib/underscore-min.js');

    return function (animals) {

        var groupedBySpeciesDescending = _.chain(animals)
            .sortBy('species')
            .reverse()
            .groupBy('species').value();

        _.each(groupedBySpeciesDescending, function (animalsPerGroup, groupName) {
            var sortedAnimals = _.chain(animalsPerGroup)
                .sortBy('name')
                .sortBy('legsCount')
                .value();

            console.log('-'.repeat(groupName.length + 1));
            console.log(groupName + ':');
            console.log('-'.repeat(groupName.length + 1));

            _.each(sortedAnimals, function (animal) {
                console.log(animal.name + ' has ' + animal.legsCount + ' legs');
            })
        });
    }
}

//var result = solve();
//result(animals);

module.exports = solve;
