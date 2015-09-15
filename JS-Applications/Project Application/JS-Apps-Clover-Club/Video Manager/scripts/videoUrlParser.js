var videoUrlParser = (function() {
    function parse(url) {
        var videoId = url.split('v=')[1],
            ampersandPosition = url.indexOf('&');

        if (ampersandPosition != -1) {
            videoId = videoId.substring(0, ampersandPosition);
        }

        return videoId;
    }

    return {
        parse: parse
    };
})();