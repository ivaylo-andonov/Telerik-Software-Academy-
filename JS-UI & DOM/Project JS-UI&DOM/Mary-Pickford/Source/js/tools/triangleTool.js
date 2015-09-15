(function () {
    var triangleTool = makeTool('Triangle', '', triangleToolMouseDown, null, null, triangleToolUpdateSettings),
        flipperObj = [1, 0, 0, 0],
        currentIndex = -1;

    function triangleToolUpdateSettings() {
        ctx.strokeStyle = swatch.style.backgroundColor;
        ctx.fillStyle = swatch.style.backgroundColor;
        flip();
        function flip() {
            flipperObj[currentIndex] = 0;
            flipperObj[currentIndex + 1] = 1;
            currentIndex += 1;
            if (currentIndex + 1 === 4) {
                currentIndex = -1;
            }
        }
    }

    function triangleToolMouseDown() {
        var tempX = mousePositionX;
        var tempY = mousePositionY;
        ctx.beginPath();
        ctx.moveTo(tempX, tempY);

        if (flipperObj[0]) {
            ctx.lineTo(tempX + 100, tempY);
            ctx.lineTo(tempX, tempY + 100);
        } else if (flipperObj[1]) {
            ctx.lineTo(tempX - 100, tempY);
            ctx.lineTo(tempX, tempY + 100);
        } else if (flipperObj[2]) {
            ctx.lineTo(tempX - 100, tempY);
            ctx.lineTo(tempX, tempY - 100);
        } else if (flipperObj[3]) {
            ctx.lineTo(tempX + 100, tempY);
            ctx.lineTo(tempX, tempY - 100);
        }

        ctx.closePath();
        ctx.stroke();
    }

}());
