function solve() {

    var Constants = {
        MIN_LENGTH: 3,
        MAX_LENGTH: 25,
        MIN_RATING: 1,
        MAX_RATING: 5,
    };

    var Validators = {
        validateString: function (str, minLen, maxLen) {
            return (typeof str === 'string' && str.length >= minLen && str.length <= maxLen);
        },
        validateRating: function (rating, min, max) {
            return (typeof rating === 'number' && rating >= min && rating <= max);
        },
        validatePageAndSize: function (page, size, maxElements) {
            if (page < 0) {
                throw new Error('Page must be greather than or equal to 0');
            }
            if (size <= 0) {
                throw new Error('Size must be greather than or equal to 1');
            }

            if (page * size > maxElements) {
                throw new Error('Page * size will not return any elements from collection');
            }
        }
    };

    function indexOfElementWithIdInCollection(collection, id) {
        var i, len;
        for (i = 0, len = collection.length; i < len; i++) {
            if (collection[i].id === id) {
                return i;
            }
        }
        return -1;
    }

    function getSortingFunction(firstParameter, secondParameter) {
        return function (first, second) {
            if (first[firstParameter] < second[firstParameter]) {
                return -1;
            }
            else if (first[firstParameter] > second[firstParameter]) {
                return 1;
            }

            if (first[secondParameter] < second[secondParameter]) {
                return -1;
            }
            else if (first[secondParameter] > second[secondParameter]) {
                return 1;
            }
            else {
                return 0;
            }
        }
    }

    var player = (function () {

        var lastId = 0;

        var player = {
            init: function (name) {
                this.name = name;
                this.id = ++lastId;
                this.playlists = [];

                return this;
            },
            addPlaylist: function (playlistToAdd) {
                if (playlistToAdd.id === undefined) {
                    throw new Error('Playlist cannot be undefined,should has ID');
                }
                this.playlists.push(playlistToAdd);

                return this;
            },
            getPlaylistById: function (id) {
                var foundedIndex = indexOfElementWithIdInCollection(this.playlists, id);
                if (foundedIndex < 0) {
                    return null;
                }
                return this.playlists[foundedIndex];
            },
            removePlaylist: function (idOrPlaylist) {
                var id = idOrPlaylist;
                if (typeof idOrPlaylist !== 'number') {
                    id = idOrPlaylist.id;
                }
                var foundedIndex = indexOfElementWithIdInCollection(this.playlists, id);
                if (foundedIndex < 0) {
                    throw new Error('Non existing playable in playlist to be removed.');
                }

                this.playlists.splice(foundedIndex, 1);

                return this;
            },
            listPlaylists: function (page, size) {

                Validators.validatePageAndSize(page, size, this.playlists);

                var sortedPlaylists = this.playlists.slice().sort(getSortingFunction('name', 'id'));

                return sortedPlaylists.splice(page * size, size);

            },
            contains: function (playable, playlist) {
                var myPlaylist = this.getPlaylistById(playable.id);
                if (myPlaylist === null) {
                    return false;
                }

                var myPlayable = myPlaylist.getPlayableById(playlist.id);
                if (myPlayable === null) {
                    return false;
                }

                return true;
            },
            search: function (pattern) {

            },
            get name() {
                return this._name;
            },
            set name(value) {
                if (!(Validators.validateString(value, Constants.MIN_LENGTH, Constants.MAX_LENGTH))) {
                    throw new Error('Invalid name or name.length is out of range: MIN- ' +
                        Constants.MIN_LENGTH + ',MAX- ' + Constants.MAX_LENGTH);
                }
                this._name = value;
            },
        };

        return player;

    }());

    var playlist = (function () {

        var lastId = 0;

        var playlist = {
            init: function (name) {
                this.name = name;
                this.id = ++lastId;
                this.playables = [];

                return this;
            },
            addPlayable: function (playableToAdd) {
                if (playableToAdd.id === undefined) {
                    throw new Error('Playable cannot be undefined,should has ID');
                }
                this.playables.push(playableToAdd);

                return this;
            },
            getPlayableById: function (id) {
                var foundedIndex = indexOfElementWithIdInCollection(this.playables, id);
                if (foundedIndex < 0) {
                    return null;
                }
                return this.playables[foundedIndex];
            },
            removePlayable: function (idOrPlayble) {
                var id = idOrPlayble;
                if (typeof idOrPlayble !== 'number') {
                    id = idOrPlayble.id;
                }
                var foundedIndex = indexOfElementWithIdInCollection(this.playables, id);
                if (foundedIndex < 0) {
                    throw new Error('Non existing playable in playlist to be removed.');
                }

                this.playables.splice(foundedIndex, 1);

                return this;
            },
            listPlayables: function (page, size) {
                Validators.validatePageAndSize(page, size, this.playables);

                var sortedPlayables = this.playables.slice().sort(getSortingFunction('name', 'id'));

                return sortedPlayables.splice(page * size, size);
            },
            get name() {
                return this._name;
            },
            set name(value) {
                if (!(Validators.validateString(value, Constants.MIN_LENGTH, Constants.MAX_LENGTH))) {
                    throw new Error('Invalid name or name.length is out of range: MIN- ' +
                        Constants.MIN_LENGTH + ',MAX- ' + Constants.MAX_LENGTH);
                }
                this._name = value;
            },

        };

        return playlist;

    }());

    var playable = (function () {
        var lastId = 0,

        playable = {
            init: function (title, author) {
                this.id = ++lastId;
                this.title = title;
                this.author = author;

                return this;
            },
            play: function () {
                return this.id + '. ' + this.title + ' - ' + this.author;
            },
            get title() {
                return this._title;
            },
            set title(value) {
                if (!(Validators.validateString(value, Constants.MIN_LENGTH, Constants.MAX_LENGTH))) {
                    throw new Error('Invalid string or string.length is out of range: MIN- ' +
                        Constants.MIN_LENGTH + ',MAX- ' + Constants.MAX_LENGTH);
                }
                this._title = value;
            },
            get author() {
                return this._author;
            },
            set author(value) {
                if (!Validators.validateString(value, Constants.MIN_LENGTH, Constants.MAX_LENGTH)) {
                    throw new Error('Invalid string or string.length is out of range: MIN- ' +
                        Constants.MIN_LENGTH + ',MAX- ' + Constants.MAX_LENGTH);
                }
                this._author = value;
            },
        };

        return playable;
    }());

    var audio = (function (parent) {

        var audio = Object.create(parent, {
            init: {
                value: function (title, author, length) {
                    parent.init.call(this, title, author);
                    this.length = length;

                    return this;
                }
            },
            play: {
                value: function () {
                    var base = parent.play.call(this);
                    base += ' - ' + this.length;
                    return base;
                }
            },
            length: {
                get: function () {
                    return this._length;
                },
                set: function (value) {
                    if (value <= 0 || typeof value !== 'number') {
                        throw new Error('Length cannot be less than 0');
                    }
                    this._length = value;
                },
            }
        });

        return audio;
    }(playable));

    var video = (function (parent) {

        var video = Object.create(parent, {
            init: {
                value: function (title, author, imdbRating) {
                    parent.init.call(this, title, author);
                    this.imdbRating = imdbRating;

                    return this;
                }
            },
            play: {
                value: function () {
                    var base = parent.play.call(this);
                    base += ' - ' + this.imdbRating;
                    return base;
                }
            },
            imdbRating: {
                get: function () {
                    return this._imdbRating;
                },
                set: function (value) {
                    if (!(Validators.validateRating(value, Constants.MIN_RATING, Constants.MAX_RATING))) {
                        throw new Error('Invalid number or number is out of range: MIN- ' +
                            Constants.MIN_RATING + ', MAX- ' + Constants.MAX_RATING);
                    }
                    this._imdbRating = value;
                },
            }
        });

        return video;

    }(playable));

    var module = {


        getPlayer: function (name) {
            return Object.create(player).init(name);
        },
        getPlaylist: function (name) {
            return Object.create(playlist).init(name);
        },
        getAudio: function (title, author, length) {
            return Object.create(audio).init(title, author, length);
        },
        getVideo: function (title, author, imdbRating) {
            return Object.create(video).init(title, author, imdbRating);
        }
    };

    return module;
}

//var module = solve();

//var ivo = module.getPlayer('Ivo');
//console.log(ivo);

//var playlist = module.getPlaylist('Cherno');
//console.log(playlist);

//var audio = module.getAudio('In da club', '50 cent', 43);
//var video = module.getVideo('Bang Bang', 'John', 4);
//var kiki = module.getAudio('In da club222', '50000 cent', 43);
//var miki = module.getVideo('Bang Bang333', 'John3333', 2);
//playlist.addPlayable(audio).addPlayable(video).addPlayable(kiki).addPlayable(miki);
//console.log(playlist.listPlayables(0, 3));
//console.log(playlist);

//var playlist2 = module.getPlaylist('Chalga');

//var chalga = module.getAudio('Chalga', 'Magda', 6);
//var malga = module.getVideo('Blow', 'Kiro', 2);
//var koko = module.getAudio('Coco', 'Genesis', 63);

//playlist2.addPlayable(chalga).addPlayable(malga).addPlayable(koko);
//console.log(playlist2.listPlayables(0, 2));

//ivo.addPlaylist(playlist2).addPlaylist(playlist);
//console.log(ivo);
//console.log(ivo.listPlaylists(0, 2));


//var song = module.getAudio('ivoo', 'Pencho', 4);
//var videos = module.getVideo('Scared', 'King', 3);

////console.log(song);
//console.log(videos);

