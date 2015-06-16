function Solve(params) {
    var rows = params[0].split(' ')[0],
        cols = params[0].split(' ')[1],
        matrix = params.slice(1).map(function (line) {
            return line.split('');
        }),
        row = rows - 1, col = cols - 1,
        points = 0, counter = 0,
        horseMoves = [[-2, 1], [-1, 2], [1, 2], [2, 1], [2, -1], [1, -2], [-1, -2], [-2, -1]];

    while (1) {

        if (!matrix[row] || !matrix[row][col]) {
            return 'Go go Horsy! Collected ' + points + ' weeds';
        }
        if (matrix[row][col] === 'used') {
            return 'Sadly the horse is doomed in ' + counter + ' jumps';
        }       
        points += (1 << row) - col; // Get the points
        var currNum = matrix[row][col];
        matrix[row][col] = 'used';
        row += horseMoves[currNum - 1][0];
        col += horseMoves[currNum - 1][1];
        counter += 1;        
    }
}

var test = [
 '3 5',
'54361',
'43326',
'52188',
];


function task() {
    console.log(Solve(test));
}