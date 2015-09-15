(function () {
    var sprayCanTool = makeTool('Spray can', '', applySprayOnMouseDown, null, null, updateSprayCanToolSettings);

    function updateSprayCanToolSettings(){
        ctx.strokeStyle = swatch.style.backgroundColor;
        ctx.fillStyle = swatch.style.backgroundColor;
    }
    function applySprayOnMouseDown() {
        if(mouseClicked){
            sleep()
        }
    }


    function spray() {
        var centerX = mousePositionX,
            centerY = mousePositionY,
            x,
            y,
            lineWidth=ctx.lineWidth,
            density = ctx.lineWidth * 3;

        for (var i = 0; i < density; i += 1) {
            x = centerX + getRandomSprayPattern(lineWidth);
            y = centerY + getRandomSprayPattern(lineWidth);
            ctx.fillRect(x, y, 1, 1);
        }
    }

    function sleep() {
        spray();
        var speedOfDrawing = 20;
        if(mouseClicked){
            setTimeout(sleep, speedOfDrawing);
        }
    }

    function getRandomSprayPattern(widthOfSprayPattern) {
        return Math.floor((Math.random() * widthOfSprayPattern + 1));
    }
}());
