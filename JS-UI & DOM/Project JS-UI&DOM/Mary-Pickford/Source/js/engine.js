'use strict';

function init(canvas, width, height) {
    ctx = canvas.getContext('2d');
    canvas.width = width;
    canvas.height = height;

    ctx.lineWidth = 10;

    //Fixes issue with paint bucket drawing over black
    //initial color on the canvas is (0,0,0)...
    ctx.rect(0, 0, width, height);
    ctx.fillStyle = 'white';
    ctx.fill();
    $(canvas).css('cursor', 'crosshair');

    currentTool = tools['Brush'];

    // Initialize the cursor
    $('#canvas').css('cursor', 'url(' + currentTool.cursor + ') 0 100, crosshair');
}

function changeTool(toolItem) {
    var selectedToolName = $(toolItem).text();
    var tool = tools[selectedToolName];
    currentTool = tool;
    updateToolSettings();

    if (tool.name === 'Brush') {
        $('canvas').mousedown();
        $('canvas').mouseup();
    }

   var button = $('#flipper');
    if(tool.name === 'Triangle'){
        var element = $('<button id ="flipper" onclick="updateToolSettings()">Flip</button>');

        if (button.length === 0) {
            $(document.body).append(element);
            button.click(updateToolSettings);
        }
    } else {
        button.remove();
    }
}

function addToolsInTheSidebar() {
    for (var index in tools) {
        var tool = tools[index];
        var newItem = $('<a href="#"></a>');
        newItem.attr('title', tool.name);
        newItem.text(tool.name);
        if (index === 'Brush') {
            newItem.addClass('selected');
        }

        $('nav').append(newItem);
    }
}

function updateToolSettings() {
    if (currentTool.updateToolSettings !== null) {
        currentTool.updateToolSettings();
    }


    // Update the cursor
    $('#canvas').css('cursor', 'url(' + currentTool.cursor + ') 0 100, crosshair');
    updateCursorColor(swatch.style.backgroundColor);
}

function updateCursorColor(color){
    // currentTool
    var currentToolImage = currentTool.cursor;

    if(currentToolImage && currentTool.name !== 'Eraser'){
        attachColor(currentToolImage, color, function (newCursor) {
            $('#canvas').css('cursor', 'url(' + newCursor + '), auto');
            $('#canvas').css('cursor', 'url(' + newCursor + ') 0 100, auto');
        });
    }
}

function onMouseDown() {
    mouseClicked = true;
    if (currentTool.onMouseDown !== null) {
        currentTool.onMouseDown();
    }
}

function onMouseUp() {
    mouseClicked = false;
    if (currentTool.onMouseUp !== null) {
        currentTool.onMouseUp();
    }

    logAction(canvas.toDataURL());
}

function onMouseMove(event) {
    mousePositionX = event.offsetX;
    mousePositionY = event.offsetY;

    if (currentTool.onMouseMove !== null) {
        currentTool.onMouseMove();
    }
}

function onKeyDown(ev){
    keyPressed = true;

    var eventObject = window.event? event : ev;

    // TODO: Take out these keys in another file & function

    // CTRL + z
    if (eventObject.keyCode === 90 && eventObject.ctrlKey) {
        undoAction();
    }

    // CTRL + y
    if (eventObject.keyCode === 89 && eventObject.ctrlKey) {
        redoAction();
    }
}

function clearCurrentLayer() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    // TODO: Take out this in another function
    localStorage.removeItem('actions');
}

$(document).ready(function () {
    var canvas = document.getElementById('canvas');
    init(canvas, 1000, 500);

    updateToolSettings();
    addToolsInTheSidebar();

    $(canvas).mousedown(onMouseDown);
    $(canvas).mousemove(onMouseMove);
    $(canvas).mouseup(onMouseUp);

    $(document).keydown(onKeyDown);

    $('nav a').click(function () {
        if (!$(this).is('#menuToggle')) {
            var tool = this;
            changeTool(tool);
        }
    });

    $('#clear').click(clearCurrentLayer);

    $('#submit').click(insertImage);

    $('#canvas').mousemove(function () {
        $('#x').html('X: ' + mousePositionX);
        $('#y').html('Y: ' + mousePositionY);
    });
});
