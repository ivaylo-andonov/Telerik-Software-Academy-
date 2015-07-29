(function(){
    var triangleTool = makeTool('Triangle', '', triangleToolMouseDown, null, null, triangleToolUpdateSettings);

    function triangleToolUpdateSettings() {
        ctx.strokeStyle = 'black';
        ctx.fillStyle = 'white';
    }

    function triangleToolMouseDown() {
        var tempX = mousePositionX;
        var tempY = mousePositionY;
        ctx.beginPath();
        ctx.moveTo(tempX, tempY);
        ctx.lineTo(tempX + 100, tempY);
        ctx.lineTo(tempX , tempY + 100);
        ctx.closePath();
        ctx.fill();
        ctx.stroke();
    }

}());
