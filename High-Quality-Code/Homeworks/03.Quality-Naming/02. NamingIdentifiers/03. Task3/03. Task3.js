function mozillaButton(event, arguments) {
    var mozillaWindow = window,
        browserName = mozillaWindow.navigator.appCodeName,
        isMozilla = (browserName === "Mozilla");
    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}