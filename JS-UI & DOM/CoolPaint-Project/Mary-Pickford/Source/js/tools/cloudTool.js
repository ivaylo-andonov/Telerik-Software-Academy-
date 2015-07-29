(function(){
    var cloudTool = makeTool('Cloud', '', cloudToolMouseDown, null, null, cloudToolUpdateSettings);

    function cloudToolUpdateSettings(){
        ctx.strokeStyle = 'black';
        ctx.fillStyle = 'white';
    }

    function cloudToolMouseDown() {
        var tempX = mousePositionX;
        var tempY = mousePositionY;
        ctx.beginPath();
        ctx.moveTo(tempX, tempY);
        ctx.bezierCurveTo(tempX - 40, tempY + 20, tempX - 40, tempY + 70, tempX + 60, tempY + 70);
        ctx.bezierCurveTo(tempX + 80, tempY + 100, tempX + 150, tempY + 100, tempX + 170, tempY + 70);
        ctx.bezierCurveTo(tempX + 250, tempY + 70, tempX + 250, tempY + 40, tempX + 220, tempY + 20);
        ctx.bezierCurveTo(tempX + 260, tempY - 40, tempX + 200, tempY - 50, tempX + 170, tempY - 30);
        ctx.bezierCurveTo(tempX + 150, tempY - 75, tempX + 80, tempY - 60, tempX + 80, tempY - 30);
        ctx.bezierCurveTo(tempX + 30, tempY - 75, tempX - 20, tempY - 60, tempX, tempY);
        ctx.closePath();
        ctx.fill();
        ctx.stroke();
    }
}());
