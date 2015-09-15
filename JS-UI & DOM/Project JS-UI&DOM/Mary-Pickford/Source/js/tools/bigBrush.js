(function () {
    var bigBrushCursor = 'img/toolIcons/bigBrush.png';
    var bigBrushTool = makeTool('Big Brush', bigBrushCursor, applySprayOnMouseDown, null, null, updateBigBrushToolSettings);

    function updateBigBrushToolSettings(){
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
            density = 40;

        for (var i = 0; i < density; i += 1) {
            x = centerX + getRandomSprayPattern(20);
            y = centerY + getRandomSprayPattern(20);
            ctx.fillRect(x, y, ctx.lineWidth * 2, 1);
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
