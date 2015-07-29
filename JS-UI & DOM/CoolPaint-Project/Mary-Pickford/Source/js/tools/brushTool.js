(function(){
    var brushCursor = 'img/toolIcons/brush.png';
    var brushTool = makeTool('Brush', brushCursor, brushToolMouseDown, brushToolMouseMove, null, updateBrushToolSettings);

    var radius = 5;

    function updateBrushToolSettings() {
        ctx.strokeStyle = 'black';
        ctx.fillStyle = 'black';
        ctx.lineWidth = radius * 2;
    }

    function brushToolMouseMove() {
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

    function brushToolMouseDown(){
        ctx.beginPath();
    }
}());
