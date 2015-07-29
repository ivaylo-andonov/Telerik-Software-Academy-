(function(){
    var circleTool = makeTool('Circle', '', circleToolMouseDown, null, null, circleToolUpdateSettings),
        defaultRadius=40;

    function circleToolUpdateSettings(){
        ctx.strokeStyle = 'black';
        ctx.fillStyle = 'white';
    }

    function circleToolMouseDown(){
        ctx.beginPath();
        ctx.arc(mousePositionX, mousePositionY, defaultRadius, 0, 2 * Math.PI, false);
        ctx.fill();
        ctx.stroke();
    }
}());

