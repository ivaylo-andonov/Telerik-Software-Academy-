function Solve(params) {
    var nums = params.slice(1).map(Number),
    maxSum = nums[0],
    i, j;

    for (i = 0; i < nums.length; i += 1) {
        var currSUm = 0;
        for (j = i ; j < nums.length; j += 1) {
            currSUm += nums[j];
            if (currSUm > maxSum) {
                maxSum = currSUm;
            }
        }
    }
    return maxSum;
}


var test = [
  '8',
  '1',
  '6',
  '-9',
  '4',
  '4',
  '-2',
  '10',
  '-1',
];


function task() {
    console.log(Solve(test));
}

