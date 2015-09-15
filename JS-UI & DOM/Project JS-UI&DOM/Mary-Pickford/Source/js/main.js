var ctx;

var mouseClicked;
var keyPressed;
var mousePositionX;
var mousePositionY;

var currentTool;

var tools = {};

var makeTool = function (name, cursor, onMouseDown, onMouseMove, onMouseUp, updateToolSettings) {
    'use strict';

    var newTool = {
        name: name,
        cursor: cursor,
        onMouseDown: onMouseDown,
        onMouseMove: onMouseMove,
        onMouseUp: onMouseUp,
        updateToolSettings: updateToolSettings
    };

    tools[newTool.name] = newTool;

    return newTool;
};
