function putImage() {
    var canvas = document.getElementById("canvas");

    var image = canvas.toDataURL("image/png");

    $('#save').attr('download', 'Perfect pic').attr('href', image);

}

$('#save').click(putImage);
