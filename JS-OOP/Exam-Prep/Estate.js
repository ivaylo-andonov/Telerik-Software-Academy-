var Validators = (function() {
		var Validators = {
			validateNonEmptyString: function(value, methodName) {
				if (typeof value != 'string') {
					throw new Error('Value must be a string. Method ' + methodName);
				}
				if (value === '') {
					throw new Error('Invalid empty string. Method ' + methodName);
				}
			},
			validateIntegerInRange: function(value, minValue, maxValue, methodName) {
				validateInteger(value, methodName);
				if (typeof minValue != 'number' || typeof maxValue != 'number') {
					throw new Error('Range values must be valid numbers. Method ' + value);
				}
				if (value < minValue || value > maxValue) {
					throw new Error('Value is out of the given range. Method ' + methodName);
				}
				if ((value | 0) !== value) {
					throw new Error('Number must be an integer. Method' + methodName);
				}
			},
			validateBoolean: function(value, methodName) {
				if (typeof value != 'boolean') {
					throw new Error('Invalid non-boolean value. Method ' + methodName);
				}
			},
			validatePositiveInteger: function(value, methodName) {
				validateInteger(value, methodName);
				if (value < 0) {
					throw new Error('Invalid negative value. Method ' + methodName);
				}
			}
		};

		function validateInteger(value, methodName) {
			validateNumber(value, methodName);
			if (!(value % 1 === 0)) {
				throw new Error('Number must be an integer. Method ' + methodName);
			}
		}

		function validateNumber(value, methodName) {
			if (isNaN(value)) {
				throw new Error('Value must be a number. Method ' + methodName);
			}
		}

		return Validators;
	}());

	var Estate = (function() {
		var Estate = {
			init: function(name, area, location, isFurnitured) {
				this.name = name;
				this.area = area;
				this.location = location;
				this.isFurnitured = isFurnitured;

				return this;
			},
			typeName: 'Estate',
			set name(value) {
				Validators.validateNonEmptyString(value, 'Estate.name');
				this._name = value;
			},
			get name() {
				return this._name;
			},
			set area(value) {
				Validators.validateIntegerInRange(value, 1, 10000, 'Estate.area');
				this._area = value;
			},
			get area() {
				return this._area;
			},
			set location(value) {
				Validators.validateNonEmptyString(value, 'Estate.location');
				this._location = value;
			},
			get location() {
				return this._location;
			},
			set isFurnitured(value) {
				Validators.validateBoolean(value, 'Estate.isFurnitured');
				this._isFurnitured = value;
			},
			get isFurnitured() {
				return this._isFurnitured;
			},
			toString: function() {
				var isFurnituredText = this.isFurnitured ? 'Yes' : 'No';
				return this.typeName + ': Name = ' + this.name + ', Area = ' + this.area + ', Location = ' + this.location + ', Furnitured = ' + isFurnituredText;
			}
		};

		return Estate;
	}());

	var BuildingEstate = (function(parent) {
		var BuildingEstate = Object.create(parent);
		Object.defineProperties(BuildingEstate, {
			init: {
				value: function(name, area, location, isFurnitured, rooms, hasElevator) {
					parent.init.call(this, name, area, location, isFurnitured);
					this.rooms = rooms;
					this.hasElevator = hasElevator;

					return this;
				}
			},
			typeName: {
				value: 'BuildingEstate'
			},
			rooms: {
				set: function(value) {
					Validators.validateIntegerInRange(value, 0, 100, 'BuildingEstate.rooms');
					this._rooms = value;
				},
				get: function() {
					return this._rooms;
				}
			},
			hasElevator: {
				set: function(value) {
					Validators.validateBoolean(value, 'BuildingEstate.hasElevator');
					this._hasElevator = value;
				},
				get: function() {
					return this._hasElevator;
				}
			},
			toString: {
				value: function() {
					var elevatorText = this.hasElevator ? 'Yes' : 'No';
					return parent.toString.call(this) + ', Rooms: ' + this.rooms + ', Elevator: ' + elevatorText;
				}
			}
		});

		return BuildingEstate;
	}(Estate));

	var Apartment = (function() {
		var Apartment = Object.create(BuildingEstate);
		Object.defineProperties(Apartment, {
			init: {
				value: function(name, area, location, isFurnitured, rooms, hasElevator) {
					BuildingEstate.init.call(this, name, area, location, isFurnitured, rooms, hasElevator);
					return this;
				}
			},
			typeName: {
				value: 'Apartment'
			}
		});

		return Apartment;
	}());

	var Office = (function() {
		var Office = Object.create(BuildingEstate);
		Object.defineProperties(Office, {
			init: {
				value: function(name, area, location, isFurnitured, rooms, hasElevator) {
					BuildingEstate.init.call(this, name, area, location, isFurnitured, rooms, hasElevator);
					return this;
				}
			},
			typeName: {
				value: 'Office'
			}
		});

		return Office;
	}());

	var House = (function() {
		var House = Object.create(Estate);
		Object.defineProperties(House, {
			init: {
				value: function(name, area, location, isFurnitured, floors) {
					Estate.init.call(this, name, area, location, isFurnitured);
					this.floors = floors;
					return this;
				}
			},
			typeName: {
				value: 'House'
			},
			floors: {
				set: function(value) {
					Validators.validateIntegerInRange(value, 1, 10, 'House.floors');
					this._floors = value;
				},
				get: function() {
					return this._floors;
				}
			},
			toString: {
				value: function() {
					return Estate.toString.call(this) + ', Floors: ' + this.floors;
				}
			}
		});

		return House;
	}());

	var Garage = (function(parent) {
		var Garage = Object.create(parent);
		Object.defineProperties(Garage, {
			init: {
				value: function(name, area, location, isFurnitured, width, height) {
					parent.init.call(this, name, area, location, isFurnitured);
					this.width = width;
					this.height = height;
					return this;
				},
			},
			typeName: {
				value: 'Garage'
			},
			width: {
				set: function(value) {
					Validators.validateIntegerInRange(value, 1, 500, 'Garage.width');
					this._width = value;
				},
				get: function() {
					return this._width;
				}
			},
			height: {
				set: function(value) {
					Validators.validateIntegerInRange(value, 1, 500, 'Garage.height');
					this._height = value;
				},
				get: function() {
					return this._height;
				}
			},
			toString: {
				value: function() {
					return parent.toString.call(this) + ', Width: ' + this.width + ', Height: ' + this.height;
				}
			}
		});

		return Garage;
	}(Estate));

	var Offer = (function() {
		var Offer = {
			init: function(estate, price) {
				this.estate = estate;
				this.price = price;
				return this;
			},
			typeName: {
				value: 'Offer'
			},
			set estate(value) {
				if (!value) {
					throw new Error('Invalid estate null value');
				};
				this._estate = value;
			},
			get estate() {
				return this._estate;
			},
			set price(value) {
				Validators.validatePositiveInteger(value);
				this._price = value;
			},
			get price() {
				return this._price;
			},
			toString: function() {
				return this.typeName + ': Estate = ' + this.estate.name + ', Location = ' + this.estate.location + ', Price = ' + this.price;
			}
		};

		return Offer;
	}());

	var RentOffer = (function() {
		var RentOffer = Object.create(Offer);
		Object.defineProperties(RentOffer, {
			init: {
				value: function(estate, price) {
					Offer.init.call(this, estate, price);
					return this;
				}
			},
			typeName: {
				value: 'Rent'
			}
		});

		return RentOffer;
	}());

	var SaleOffer = (function(parent) {
		var SaleOffer = Object.create(parent);
		Object.defineProperties(SaleOffer, {
			init: {
				value: function(estate, price) {
					parent.init.call(this, estate, price);
					return this;
				}
			},
			typeName: {
				value: 'Sale'
			}
		});

		return SaleOffer;
	}(Offer));