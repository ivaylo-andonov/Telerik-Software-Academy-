(function () {
    var circleTool = makeTool('Ellipse', '', handleMouseDown, null, handleMouseUp, updateBrushToolSettings),
        startX,
        startY;

    function updateBrushToolSettings() {
        ctx.strokeStyle = 'black';
        ctx.fillStyle = 'white';
    }

    function drawEllipse(x, y) {
        ctx.beginPath();
        ctx.moveTo(startX, startY + (y - startY) / 2);
        ctx.bezierCurveTo(startX, startY, x, startY, x, startY + (y - startY) / 2);
        ctx.bezierCurveTo(x, y, startX, y, startX, startY + (y - startY) / 2);
        ctx.fill();
        ctx.stroke();
    }

    function handleMouseDown() {
        startX = mousePositionX;
        startY = mousePositionY;
    }

    function handleMouseUp() {
        drawEllipse(mousePositionX, mousePositionY);
    }
}());

