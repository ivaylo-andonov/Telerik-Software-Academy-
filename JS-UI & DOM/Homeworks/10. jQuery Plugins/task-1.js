function solve() {
    return function (selector) {
        var $selectedList = $(selector)
            .hide();
        var options = $selectedList.find('option');

        var $divContainer = $('<div>')
            .addClass('dropdown-list')
            .append($selectedList);

        var $currentSelection = $('<div>')
            .addClass('current')
            .attr('data-value', '')
            .text('Select value');

        var $divOptionsContainer = $('<div>')
            .addClass('options-container')
            .css({
                'position': 'absolute',
                'display': 'none'
            });

        $currentSelection.on('click', function () {
            var $container = $('.options-container');
            $container.css('display', 'inline-block');
        });

        $divOptionsContainer.on('click', function (ev) {
            var $clicked = $(ev.target);
            var $divToDisplay = $('.current');
            $divToDisplay.text($clicked.html());
            $selectedList.val($clicked.attr('data-value'));

            var $container = $(this)
                .css('display', 'none');
        });

        for (var i = 1; i <= options.length; i++) {
            var newOpt = $('<div>')
                .addClass('dropdown-item')
                .attr('data-value', $(options[i]).val())
                .attr('data-index', i - 1)
                .text($(options[i]).text());

            $divOptionsContainer.append(newOpt);
        }

        $divContainer.appendTo('body');
        $currentSelection.appendTo($divContainer);
        $divOptionsContainer.appendTo($divContainer);

    };
}