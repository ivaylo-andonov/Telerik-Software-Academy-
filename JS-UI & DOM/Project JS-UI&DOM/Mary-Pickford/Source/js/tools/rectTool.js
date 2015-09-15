(function(){
    var rectTool = makeTool('Rectangle', '', rectToolMouseDown, null, rectToolMouseUp, rectToolUpdateSettings),
        startX,
        startY;

    function rectToolUpdateSettings(){
        ctx.strokeStyle = swatch.style.backgroundColor;
        ctx.fillStyle = swatch.style.backgroundColor;
    }

    function rectToolMouseDown(){
        startX = mousePositionX;
        startY = mousePositionY;

    }

    function rectToolMouseUp(){
        drawRectangle(mousePositionX, mousePositionY);
    }
    function drawRectangle(x,y){
        ctx.beginPath();
        ctx.strokeRect(startX, startY, Math.abs(startX-x), Math.abs(startY-y));
    }
}());
