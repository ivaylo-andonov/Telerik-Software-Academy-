(function () {
    var bucketCursor = 'img/toolIcons/bucket.png';
    var bucketTool = makeTool('Bucket', bucketCursor, bucketToolMouseDown, null, null, updateBucketToolSettings);

    function updateBucketToolSettings() {
        ctx.strokeStyle = swatch.style.backgroundColor;
        ctx.fillStyle = swatch.style.backgroundColor;
    }

    function bucketToolMouseDown() {
        var canvas = $('#canvas'),
            selectedColor = $('#swatch'),
            width = canvas.width(),
            height = canvas.height(),
            colorLayer = ctx.getImageData(0, 0, width, height),
            startColors = ctx.getImageData(mousePositionX, mousePositionY, 1, 1),
            drawingAreaX = 0,
            drawingAreaY = 0,
            drawingAreaWidth = width,
            drawingAreaHeight = height,
            colors = getColors(ctx.fillStyle),
            desiredColor = {
                r: colors.red,
                g: colors.green,
                b: colors.blue,
                a: ctx.globalAlpha * 100 + 155
            },
        // Changing this makes smoother borders
        //It also affects coloring(wont apply if colors are very similar);
            tolerance = 50;

        alterColors(mousePositionX, mousePositionY, startColors.data[0], startColors.data[1], startColors.data[2]);
        function alterColors(startX, startY, startR, startG, startB) {

            if ((desiredColor.r - tolerance <= startR && desiredColor.r + tolerance >= startR) &&
                (desiredColor.g - tolerance <= startG && desiredColor.g + tolerance >= startG) &&
                (desiredColor.b - tolerance <= startB && desiredColor.b + tolerance >= startB)) {
                return;
            }

            var newPos,
                x,
                y,
                pixelPos,
                reachLeft,
                reachRight,
                drawingBoundLeft = drawingAreaX,
                drawingBoundTop = drawingAreaY,
                drawingBoundRight = drawingAreaX + width - 1,
                drawingBoundBottom = drawingAreaY + height - 1,
                pixelStack = [[startX, startY]];

            while (pixelStack.length) {

                newPos = pixelStack.pop();
                x = newPos[0];
                y = newPos[1];

                // Get current pixel position
                pixelPos = (y * width + x) * 4;

                // Go up as long as the color matches and are inside the canvas
                while (y >= drawingBoundTop && matchStartColor(pixelPos, startR, startG, startB)) {
                    y -= 1;
                    pixelPos -= width * 4;
                }

                pixelPos += width * 4;
                y += 1;
                reachLeft = false;
                reachRight = false;

                // Go down as long as the color matches and in inside the canvas
                while (y <= drawingBoundBottom && matchStartColor(pixelPos, startR, startG, startB)) {
                    y += 1;

                    colorPixel(pixelPos, desiredColor.r, desiredColor.g, desiredColor.b, desiredColor.a);

                    if (x > drawingBoundLeft) {
                        if (matchStartColor(pixelPos - 4, startR, startG, startB)) {
                            if (!reachLeft) {
                                // Add pixel to stack
                                pixelStack.push([x - 1, y]);
                                reachLeft = true;
                            }
                        } else if (reachLeft) {
                            reachLeft = false;
                        }
                    }

                    if (x < drawingBoundRight) {
                        if (matchStartColor(pixelPos + 4, startR, startG, startB)) {
                            if (!reachRight) {
                                // Add pixel to stack
                                pixelStack.push([x + 1, y]);
                                reachRight = true;
                            }
                        } else if (reachRight) {
                            reachRight = false;
                        }
                    }

                    pixelPos += width * 4;
                }
            }


            function matchStartColor(pixelPos) {
                var r = colorLayer.data[pixelPos],
                    g = colorLayer.data[pixelPos + 1],
                    b = colorLayer.data[pixelPos + 2];
                if ((r - tolerance <= startR && r + tolerance >= startR) &&
                    (g - tolerance <= startG && g + tolerance >= startG) &&
                    (b - tolerance <= startB && b + tolerance >= startB)) {
                    return true;
                } else {
                        return false;
                }

            }

            function colorPixel(pixelPos, r, g, b, a) {
                colorLayer.data[pixelPos] = r;
                colorLayer.data[pixelPos + 1] = g;
                colorLayer.data[pixelPos + 2] = b;
                colorLayer.data[pixelPos + 3] = a !== undefined ? a : 255;
            }

            ctx.putImageData(colorLayer, 0, 0);
        }

        function getColors(rgb) {
            rgb = /^#?([a-f\d]{2})([a-f\d]{2})([a-f\d]{2})$/i.exec(rgb);
            var colors = {
                red: parseInt(rgb[1], 16),
                green: parseInt(rgb[2], 16),
                blue: parseInt(rgb[3], 16)
            };
            return colors;
        }
    }
}());

