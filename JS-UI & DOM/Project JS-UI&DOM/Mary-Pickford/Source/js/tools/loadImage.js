function insertImage() {
    var imageURL = $('#url').val();

    currentVariable = new Image();
    currentVariable.onload = function () {
        ctx.drawImage(currentVariable, 0, 0, 1000, 500);
    };
    currentVariable.src = imageURL;
    document.getElementById('url').value = "";
}
