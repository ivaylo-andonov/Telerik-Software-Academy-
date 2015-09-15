var radVal = document.getElementById('rad-value'),
    increase = document.getElementById('plus'),
    decrease = document.getElementById('minus'),
    writingFontSize = 30,
    interval = 3;

increase.addEventListener('click', function () {
    ctx.lineWidth += interval;
    radVal.innerHTML = ctx.lineWidth;
    writingFontSize += interval;
    ctx.font = writingFontSize + "px Cherry Cream Soda";
});

decrease.addEventListener('click', function () {
    ctx.lineWidth -= interval;
    radVal.innerHTML = ctx.lineWidth;
    writingFontSize += interval;
    ctx.font = writingFontSize + "px Cherry Cream Soda";
});



