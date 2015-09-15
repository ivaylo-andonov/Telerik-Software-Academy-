(function () {
    var starTool = makeTool('Star', '', starToolMouseDown, null, null, starToolUpdateSettings);

    function starToolUpdateSettings() {
        ctx.strokeStyle = swatch.style.backgroundColor;
        ctx.fillStyle = swatch.style.backgroundColor;
    }

    function starToolMouseDown() {
        var scale = 50;
        var tempX = mousePositionX;
        var tempY = mousePositionY;
        ctx.beginPath();
        ctx.moveTo(tempX, tempY);
        ctx.lineTo(tempX + scale, tempY);
        ctx.lineTo(tempX + scale * 1.5, tempY - scale);
        ctx.lineTo(tempX + scale * 2, tempY);
        ctx.lineTo(tempX + scale * 3, tempY);
        ctx.lineTo(tempX + scale * 2.5, tempY + scale);
        ctx.lineTo(tempX + scale * 3, tempY + scale * 2);
        ctx.lineTo(tempX + scale * 2, tempY + scale * 2);
        ctx.lineTo(tempX + scale * 1.5, tempY + scale * 3);
        ctx.lineTo(tempX + scale, tempY + scale * 2);
        ctx.lineTo(tempX, tempY + scale * 2);
        ctx.lineTo(tempX + scale * 0.5, tempY + scale);
        ctx.lineTo(tempX, tempY);
        ctx.stroke();
    }
}());
