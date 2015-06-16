function solve(args) {
    var s = +args[0],
        i,
        j,
        k,
        count = 0;

    for ( i = 0; i <= s / 10; i+=1) {
        
        for ( j = 0; j <= s / 4; j+=1) {

            for ( k  = 0; k <= s / 3; k+=1) {

                if ((i* 10 + j* 4 + k * 3) === s) {
                    count += 1;
                }
            }
        }
    }
    return count;
}

function task() {
    console.log(solve(['40']));
}
