function Solve(params) {

    // Get input
    var fieldSize = params[0].split(' ').map(Number),
        N = fieldSize[0],
        M = fieldSize[1],
        row, col, count = 1,
        field = [],
        startPos = params[1].split(' ').map(Number),
        startX = startPos[0],
        startY = startPos[1],
        jumps = params.slice(2).map(function (line) {
            return line.split(' ').map(Number);
        }),
        sum = 0,
        i = 0;

    // Filling the field
    for (row = 0; row < N; row += 1) {
        field.push([]);
        for (col = 0; col < M; col += 1) {
            field[row][col] = count;
            count += 1;
        }
    }

    // Jumping around the field
    while (true) {

        // Add sum and moving
        sum += field[startX][startY];
        startX += jumps[i][0];
        startY += jumps[i][1];

        // If jump outside the field -> escape + sum
        if (field[startX] === undefined || field[startX][startY] === undefined) {
            return 'escaped ' + sum;
        }

        i += 1;

        // Check if jumps ends -> go again
        if (i >= jumps.length) {
            i = 0;
        }
    }
}

var test = [
    '6 7 3',
    '0 0',
    '2 2',
    '-2 2',
    '3 -1',
];


function task() {
    console.log(Solve(test));
}