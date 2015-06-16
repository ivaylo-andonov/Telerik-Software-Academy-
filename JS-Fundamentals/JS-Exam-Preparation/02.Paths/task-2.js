function solve(args) {

    var rowsCols = args[0].split(' '),
        rows = +rowsCols[0],
        cols = +rowsCols[1],
        matrix = args.slice(1),
        sum = 0,
        row = 0,
        col = 0,
        upDown,
        leftRight,

        // How the current row and col are changing by the different dirs from the matrix ( walking )
        deltas = {
            'u':  -1,
            'd':   1,
            'l':  -1,
            'r':   1,
        },
        i;

    matrix = args.slice(1).map(function(line){
        return line.split(' ');
    });

    while (1) {

        // If doesnt exist -> its outside of the matrix -> return with curr sum
        if (!matrix[row] || !matrix[row][col]) {
            return 'successed with ' + sum;
        }

        // If we are again on marked step -> fail and return
        if (matrix[row][col] === 'used') {
            return 'failed at (' + row + ', ' + col + ')';
        }

        // sum += Math.pow(2,row); ->  THE SAME,but faster
        sum += (1 << row) + col;

        // Dirs fot the row: u or d
        upDown = matrix[row][col][0];

        //Dirs for the col : l or r
        leftRight = matrix[row][col][1];

        matrix[row][col] = 'used';

        // Add the current value into the rows,cols from the prop of object 
        row += deltas[upDown];
        col += deltas[leftRight];        
    }   
}

var test = [
'3 5',
'dr dl dl ur ul',
'dr dr ul ul ur',
'dl dr ur dl ur'
];


function task() {
    console.log(solve(test));
}

