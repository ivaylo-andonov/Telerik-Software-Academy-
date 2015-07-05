function solve(params) {
    var N = params[0].split(' ').map(Number)[0],
        K = params[0].split(' ').map(Number)[1],
        sequence = params[1].split(' ').map(Number),
        j, i, sum = 0, result = 0, nextSeq = [],
        newNum = 0;

    for (j = 0; j < K ; j += 1) {

        nextSeq = [];
        for (i = 0; i < sequence.length; i += 1) {

            if (sequence[i] === 0) {
                if (i === 0) {
                    newNum = Math.abs(sequence[sequence.length - 1] - sequence[i + 1]);
                }
                else if (i === sequence.length - 1) {
                    newNum = Math.abs(sequence[0] - sequence[i - 1]);
                }
                else {
                    newNum = Math.abs(sequence[i - 1] - sequence[i + 1]);
                }
                nextSeq.push(newNum);
            }
            else if (sequence[i] === 1) {
                if (i === 0) {
                    newNum = sequence[sequence.length - 1] + sequence[i + 1];
                }
                else if (i === sequence.length - 1) {
                    newNum = sequence[0] + sequence[i - 1];
                }
                else {
                    newNum = sequence[i - 1] + sequence[i + 1];
                }
                nextSeq.push(newNum);
            }
            else if (sequence[i] % 2 !== 0) {
                if (i === 0) {
                    newNum = Math.min(sequence[sequence.length - 1], sequence[i + 1]);
                }
                else if (i === sequence.length - 1) {
                    newNum = Math.min(sequence[0], sequence[i - 1]);
                }
                else {
                    newNum = Math.min(sequence[i - 1], sequence[i + 1]);
                }
                nextSeq.push(newNum);
            }
            else if (sequence[i] % 2 === 0) {
                if (i === 0) {
                    newNum = Math.max(sequence[sequence.length - 1], sequence[i + 1]);
                }
                else if (i === sequence.length - 1) {
                    newNum = Math.max(sequence[0], sequence[i - 1]);
                }
                else {
                    newNum = Math.max(sequence[i - 1], sequence[i + 1]);
                }
                nextSeq.push(newNum);
            }
        }
        sequence = nextSeq.slice(0);
    }
    for (var m = 0; m < sequence.length; m++) {
        sum += sequence[m];
    }
    return sum;
}

function task() {
    console.log(solve(test));
}


var test = [
   '10 3',
'1 9 1 9 1 9 1 9 1 9'];