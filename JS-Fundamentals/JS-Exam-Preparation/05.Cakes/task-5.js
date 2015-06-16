function solve(params) {
    var i,j,k,
      price,
      s = params[0],
      c1 = params[1],
      c2 = params[2],
      c3 = params[3],
      result = 0;

    for (i = 0; i <= (s / c1) + 1; i++) {
        for (j = 0; j <= (s / c2) + 1; j++) {
            for (k = 0; k <= (s / c3) + 1; k++) {

                price = (i * c1) + (j * c2) + (k * c3);
                if (price <= s) {                   
                    result = Math.max(result, price);
                }
            }
        }
    }

    return result;
}