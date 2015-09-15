var threadsController = function () {

    function all(context) {
        var threads;
        data.threads.get()
            .then(function (resThreads) {
                threads = resThreads.result;
                return templates.get('threads');
            })
            .then(function (template) {
                context.$element().html(template(threads));
                toastr.success('Hello posts');
            });
    }

    function add(context) {
        templates.get('threadAdd')
            .then(function (template) {
                context.$element().html(template());
                $('#btn-add-thread').on('click', function () {
                    var title = $('#tb-thread-title').val();
                    data.threads.add(title)
                        .then(function () {
                            context.redirect('#/threads');
                        });
                });
            });
    }

    function threadDetails(context) {
        var thread;
        data.threads.getById(this.params.id)
            .then(function (res) {
                thread = res.result;
                return templates.get('threadDetails');
            })
            .then(function (template) {
                context.$element().html(template(thread));
            });
    }

    function addMessages(context) {
        var threadId = context.params.id;
        templates.get('addMessage')
            .then(function (template) {
                context.$element().html(template());
                $('#btn-add-message').on('click', function () {
                    var text = $('#tb-msg-text').val();
                    console.log(threadId);
                    console.log(text);

                    data.threads.addMessage(threadId, {
                        text
                    }).then(function (res) {
                        console.log(threadId);
                        console.log(text);
                        console.log(res);
                        context.redirect('#/threads/' + threadId);
                    });
                })
            });

    }

    return {
        all: all,
        add: add,
        details: threadDetails,
        addMessage: addMessages
    };
}();