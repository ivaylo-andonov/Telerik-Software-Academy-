function Solve1(params) {

    var numbers = params.slice(1).map(Number),
        i,count = 1;

    for ( i = 1; i < numbers.length; i+=1) {
       
        if (numbers[i - 1] > numbers[i] ) {
            count += 1;
        }      
    }
    return count;
}

function Solve2(params) {

    var numbers = params.slice(1).map(Number),
        i, count = 1;

    for (i = 0; i < numbers.length; i += 1) {

        if (numbers[i +1] < numbers[i]) {
            count += 1;
        }
    }
    return count;
}

var test = [
  '6',
  '1',
  '3',
  '-5',
  '8',
  '7',
  '-6',
];


function task() {
    console.log(Solve1(test));
}