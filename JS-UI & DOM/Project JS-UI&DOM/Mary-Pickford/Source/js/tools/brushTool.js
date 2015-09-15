(function(){
    var brushCursor = 'img/toolIcons/brush.png';
    var brushTool = makeTool('Brush', brushCursor, brushToolMouseDown, brushToolMouseMove, null, updateBrushToolSettings);

    function updateBrushToolSettings() {
        ctx.strokeStyle = swatch.style.backgroundColor;
        ctx.fillStyle = swatch.style.backgroundColor;
    }

    function brushToolMouseMove() {
        if (mouseClicked) {
            ctx.lineTo(mousePositionX, mousePositionY);
            ctx.stroke();
            ctx.beginPath();
            ctx.arc(mousePositionX, mousePositionY, ctx.lineWidth / 2, 0, 2 * Math.PI);
            ctx.fill();
            ctx.beginPath();
            ctx.moveTo(mousePositionX, mousePositionY);
        }
    }

    function brushToolMouseDown(){
        ctx.beginPath();
    }
}());



