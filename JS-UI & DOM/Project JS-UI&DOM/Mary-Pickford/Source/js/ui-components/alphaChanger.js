(function () {
    var opacityRange = $('#color-opacity');
    opacityRange.change(function () {
        ctx.globalAlpha = opacityRange.val() / 100;
    });
}());