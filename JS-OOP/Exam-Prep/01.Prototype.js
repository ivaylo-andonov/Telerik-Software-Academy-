var playable = (function() {
		var playable = {
			get id() {
				return this._id;
			},
			set id(value) {
				this._id = value;
			},
			get title() {
				return this._title;
			},
			set title(value) {
				this._title = value;
			},
			get author() {
				return this._author;
			},
			set author(value) {
				this._author = value;
			},
			init: function(id, title, author) {
				this.id = id;
				this.title = title;
				this.author = author;

				return this;
			},
			play: function() {
				var result = '' + this.id + '. ' + this.title + ' - ' + this.author;

				return result;
			}
		};

		return playable;
	}());

	var audio = (function(parent) {
		var audio = Object.create(parent, {
			length: {
				get: function() {
					return this._length;
				},
				set: function(value) {
					this._length = value;
				},
				enumerable: true,
				configurable: true
			},
			init: {
				value: function(id, title, author, length) {
					parent.init.call(this, id, title, author);
					this.length = length;

					return this;
				},
				enumerable: true,
				configurable: true,
				writable: true
			},
			play: {
				value: function() {
					var baseResult = parent.play.call(this);
					baseResult += ' - ' + this.length;

					return baseResult;
				},
				enumerable: true,
				configurable: true,
				writable: true
			}
		});

		return audio;
	}(playable));

	var video = (function(parent) {
		var video = Object.create(parent, {
			imdbRating: {
				get: function() {
					return this._imdbRating;
				},
				set: function(value) {
					this._imdbRating = value;
				},
				enumerable: true,
				configurable: true
			},
			init: {
				value: function(id, title, author, imdbRating) {
					parent.init.call(this, id, title, author);
					this.imdbRating = imdbRating;

					return this;
				},
				enumerable: true,
				configurable: true,
				writable: true
			},
			play: {
				value: function() {
					var baseResult = parent.play.call(this);
					baseResult += ' - ' + this.imdbRating;

					return baseResult;
				},
				enumerable: true,
				configurable: true,
				writable: true
			}
		});

		return video;
	}(playable));