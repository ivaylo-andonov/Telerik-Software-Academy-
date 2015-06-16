function Solve(params) {

    // Get input
    var fieldSize = params[0].split(' ').map(Number),
        N = fieldSize[0],
        M = fieldSize[1],
        counter = 0,
        startPos = params[1].split(' ').map(Number),
        startX = startPos[0],
        startY = startPos[1],
        jumps = params.slice(2).map(function (line) {
            return line.split('');
        }),
        sum = 0;

    while (1) {

        if (!jumps[startX] || !jumps[startX][startY]) {
            return 'out ' + sum;
        }
        if (jumps[startX][startY] === 'used') {
            return 'lost ' + counter;
        }
        sum += (1 << (startX + 1)) + (startY + 1);

        if (jumps[startX][startY] === 'u') {
            jumps[startX][startY] = 'used';
            startX += -1;
        }
        else if (jumps[startX][startY] === 'd') {
            jumps[startX][startY] = 'used';
            startX += 1;
        }
        else if (jumps[startX][startY] === 'l') {
            jumps[startX][startY] = 'used';
            startY += -1;
        }
        else if (jumps[startX][startY] === 'r') {
            jumps[startX][startY] = 'used';
            startY += 1;
        }       
        counter += 1;
    }
}



var test = [
  "3 4",
  "1 3",
  "lrrd",
  "dlll",
  "rddd"
];


function task() {
    console.log(Solve(test));
}