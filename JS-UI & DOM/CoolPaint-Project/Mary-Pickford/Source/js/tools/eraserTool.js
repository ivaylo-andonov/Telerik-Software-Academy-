(function(){
    var eraserTool = makeTool('Eraser', '', eraserToolMouseDown, eraserToolToolMouseMove, null, updateEraserToolSettings);

    var radius = 5;

    function updateEraserToolSettings() {
        ctx.strokeStyle = 'white';
        ctx.fillStyle = 'white';
        ctx.lineWidth = radius * 2;
    }

    function eraserToolToolMouseMove() {
        if (mouseClicked) {
            ctx.lineTo(mousePositionX, mousePositionY);
            ctx.stroke();
            ctx.beginPath();
            ctx.arc(mousePositionX, mousePositionY, radius, 0, 2 * Math.PI);
            ctx.fill();
            ctx.beginPath();
            ctx.moveTo(mousePositionX, mousePositionY);
        }
    }

    function eraserToolMouseDown(){
        ctx.beginPath();
    }
}());
