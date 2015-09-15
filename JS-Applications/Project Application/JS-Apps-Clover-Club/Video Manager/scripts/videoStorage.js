var videoStorage = (function () {
    function setVideoId(data) {
        sessionStorage.currentAddedVideo = data.objectId;
    }

    return {
        setVideoId: setVideoId
    };
}());