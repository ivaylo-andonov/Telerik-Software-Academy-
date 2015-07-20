(function () {

    'use strict';

    var b = navigator.appName;
    var addScroll = false;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    var off = 0, txt = "", pX = 0, pY = 0;
    document.onmousemove = mouseMove;

    if (b === "Netscape") {
        document.captureEvents(this.Event.MOUSEMOVE);
    }

    function mouseMove(evn) {
        if (b === "Netscape") {
            pX = evn.pageX - 5;
            pY = evn.pageY;
        }
		else {
            pX = event.x - 5;
            pY = event.y;
        }

        if (b === "Netscape") {
            if (document.layers['ToolTip'].visibility === 'show') {
                new PopTip();
            }
        }
		else {
            if (document.all['ToolTip'].style.visibility === 'visible') {
                new PopTip();
            }
        }
    }

    function PopTip() {
        if (b === "Netscape") {
            this.theLayer = eval('document.layers[\'ToolTip\']');

            if ((pX + 120) > window.innerWidth) {
                pX = window.innerWidth - 150;
            }

            this.theLayer.left = pX + 10;
            this.theLayer.top = pY + 15;
            this.theLayer.visibility = 'show';
        } 
		else {
            this.theLayer = eval('document.all[\'ToolTip\']');

            if (this.theLayer) {
                pX = event.x - 5;
                pY = event.y;

                if (addScroll) {
                    pX = pX + document.body.scrollLeft;
                    pY = pY + document.body.scrollTop;
                }

                if ((pX + 120) > document.body.clientWidth) {
                    pX = pX - 150;
                }

                this.theLayer.style.pixelLeft = pX + 10;
                this.theLayer.style.pixelTop = pY + 15;
                this.theLayer.style.visibility = 'visible';
            }
        }
    }

    function HideTip() {
        var args = HideTip.arguments;

        if (b === "Netscape") {
            document.layers['ToolTip'].visibility = 'hide';
        }
		else {
            document.all['ToolTip'].style.visibility = 'hidden';
        }
    }

    function HideMenu1() {
        if (b === "Netscape") {
            document.layers['menu1'].visibility = 'hide';
        }
		else {
            document.all['menu1'].style.visibility = 'hidden';
        }
    }

    function ShowMenu1() {
        if (b === "Netscape") {
            this.theLayer = eval('document.layers[\'menu1\']');
            this.theLayer.visibility = 'show';
        }
		else {
            this.theLayer = eval('document.all[\'menu1\']');
            this.theLayer.style.visibility = 'visible';
        }
    }

    function HideMenu2() {
        if (b === "Netscape") {
            document.layers['menu2'].visibility = 'hide';
        }
		else {
            document.all['menu2'].style.visibility = 'hidden';
        }
    }

    function ShowMenu2() {
        if (b === "Netscape") {
            this.theLayer = eval('document.layers[\'menu2\']');
            this.theLayer.visibility = 'show';
        }
		else {
            this.theLayer = eval('document.all[\'menu2\']');
            this.theLayer.style.visibility = 'visible';
        }
    }
})();