Isolated Problem
----------------
Hello Dear,
I just looked at your problem with using events in JQuery.

The wrong is that Jquery does not use "attachEventListener" in contrast of native javascript.

Here we we use "*on*" after selected element, after that the wishing event, in this case  is"*click*".

Here is your code fixed and working:

     <script>
        function hideAllContent() {
            $('#home-page-content').hide();
            $('#courses-page-content').hide();
            $('#about-page-content').hide();
            $('#contact-page-content').hide();
        }

        $('#home-page').on('click', function () {
            hideAllContent();
            $('#home-page-content').show();
        });

        $('#courses-page').on('click', function () {
            hideAllContent();
            $('#courses-page-content').show();
        });

        $('#about-page').on('click', function () {
            hideAllContent();
            $('#about-page-content').show();
        });

        $('#contact-page').on('click', function () {
            hideAllContent();
            $('#contact-page-content').show();
        });
    </script>


For more information :  https://api.jquery.com/category/events/

Regards!