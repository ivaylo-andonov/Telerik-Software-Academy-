/* globals $ */
$.fn.gallery = function (columns) {
    var columns = columns || 4,
        $this = $(this),
        $galleryList = $(".gallery-list"),
        $selectedContainer = $(".selected"),
        $staticImgs = $(".image-container"),
        $imgs = $(".image-container").find('img'),
        $selectedImg = $("#current-image"),
        $nextImg = $("#next-image"),
        $prevImg = $("#previous-image"),
        $disabledDiv = $("<div></div>"),
        i,
        len = $staticImgs.length;
 
    $this.addClass("gallery");
    $this.append($disabledDiv);
    $selectedContainer.hide();
 
    for (i = 0; i < len; i += 1) {
        if (i % columns === 0) {
            $($staticImgs[i]).addClass("clearfix");
        }
    }
 
    $galleryList.on("click", "img", function () {
        var $this = $(this),
            currentImgDataInfo = $this.attr("data-info") | 0;
            switchImages(currentImgDataInfo);
 
        $galleryList.addClass("blurred");
        $disabledDiv.addClass("disabled-background");
        $selectedContainer.show();
 
    });
 
    $selectedImg.on("click", function () {
        $disabledDiv.removeClass("disabled-background");
        $galleryList.removeClass("blurred");
        $selectedContainer.hide();
 
    });
 
    $prevImg.on("click", function  () {
        var $this = $(this),
            imgDataInfo = $this.attr("data-info") | 0;
        switchImages(imgDataInfo);
    });
 
    $nextImg.on("click", function  () {
        var $this = $(this),
            imgDataInfo = $this.attr("data-info") | 0;
        switchImages(imgDataInfo);
    });
 
    function switchImages(currentImgDataInfo){
       var prevImgDataInfo = getPrevImageDataInfo(currentImgDataInfo),
            nextImgDataInfo = getNextImageDataInfo(currentImgDataInfo);
 
        $selectedImg.attr("data-info", currentImgDataInfo);
        $prevImg.attr("data-info", prevImgDataInfo);
        $nextImg.attr("data-info", nextImgDataInfo);
 
     /* $selectedImg.attr("src", "imgs/" + currentImgDataInfo + ".jpg");
        $prevImg.attr("src", "imgs/" + prevImgDataInfo + ".jpg");
        $nextImg.attr("src", "imgs/" + nextImgDataInfo + ".jpg");*/
 
        $selectedImg.attr("src", $imgs.eq(currentImgDataInfo-1).attr("src"));
        $prevImg.attr("src",  $imgs.eq(prevImgDataInfo-1).attr("src"));
        $nextImg.attr("src",  $imgs.eq(nextImgDataInfo-1).attr("src"));
    }
 
    function getPrevImageDataInfo(current) {
        var prev = current - 1;
        if (prev <= 0) {
            prev = $staticImgs.length;
        }
        return prev;
    }
 
    function getNextImageDataInfo(current) {
        var result = current + 1;
        if (result > $staticImgs.length) {
            result = 1;
        }
        return result;
    }
 
};