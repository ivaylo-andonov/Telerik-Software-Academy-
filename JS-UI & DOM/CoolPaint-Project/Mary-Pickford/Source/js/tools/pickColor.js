var swatch = document.getElementById('swatch');
swatch.addEventListener('click', setSwatch);

function setSwatch(e) {
    var swatch = e.target;

    setColor(swatch.style.backgroundColor);

}

function setColor(color) {
    ctx.fillStyle = color;
    ctx.strokeStyle = color;

}

var colors = ['black', 'grey','silver', 'white', 'darkred','crimson','red','tomato','orangered', 'orange','gold', 'yellow', 'darkgreen', 'green', 'lime', 'greenyellow', 'navy', 'blue','royalblue','skyblue','indigo','magenta', 'hotpink', 'aqua'];
for (var i = 0, n = colors.length ;i < n; i+=1) {
    var swatch = document.createElement('div');
    swatch.className = 'color';
    swatch.style.backgroundColor = colors[i];
    swatch.addEventListener('click', setSwatch);
    document.getElementById('colors').appendChild(swatch);
}