var factory = (function () {
    var pilots = [],
        machines = [];

    var pilot = (function () {
        var pilot = {},
            machines = [];

        Object.defineProperty(pilot, 'init', {
            value: function (name) {
                var that = this;
                that.name = name;
                machines = [];

                // extra stuff for printing and factory
                pilots.push(that);
                console.log('Pilot ' + that.name + ' hired');

                return that;
            }
        });

        Object.defineProperty(pilot, 'addMachine', {
            value: function (machine) {
                machines.push(machine);
                return this;
            }
        });

        Object.defineProperty(pilot, 'report', {
            value: function () {
                var result = '';
                result += this.name + ' - ' + (machines.length > 0 ? machines.length : 'no') + ' ' + (machines.length === 1 ? 'machine' : 'machines');
                if (machines.length > 0) {
                    result += '\n';

                    machines.sort(function (a, b) {
                        return a.healthPoints < b.healthPoints;
                    });

                    machines.forEach(function (machine) {
                        result += machine.toString();
                        result += '\n';
                    });
                }

                return result;
            }
        });

        return function (name) {
            return Object.create(pilot)
                .init(name);
        };
    }());

    var machine = (function () {
        var machine = {};

        Object.defineProperty(machine, 'init', {
            value: function (name, attackPoints, defensePoints, healthPoints, mode, type) {
                var that = this;
                that.name = name;
                that.attackPoints = attackPoints;
                that.defensePoints = defensePoints;
                that.healthPoints = healthPoints;
                that.mode = mode;
                that.pilot;
                that.targets = [];
                that.type = type;

                // extra stuff for printing and factory
                machines.push(that);

                return that;
            }
        });

        Object.defineProperty(machine, 'attack', {
            value: function (target) {
                this.targets.push(target.name);
                target.healthPoints -= this.attackPoints;
            }
        });

        Object.defineProperty(machine, 'toString', {
            value: function () {
                var result = '',
                    that = this;

                result += '- ' + that.name + '\n';
                result += ' *Type: ' + that.type + '\n';
                result += ' *Health: ' + that.healthPoints + '\n';
                result += ' *Attack: ' + that.attackPoints + '\n';
                result += ' *Defense: ' + that.defensePoints + '\n';
                result += ' *Targets: ' + (that.targets.length === 0 ? 'None' : that.targets.join(', ')) + '\n';

                return result;
            }
        });

        Object.defineProperty(machine, 'toggleMode', {
            value: function () {
                this.mode = !this.mode;
            }
        });

        return machine;
    }());

    var fighter = (function (parent) {
        var fighter = Object.create(parent);

        Object.defineProperty(fighter, 'init', {
            value: function (name, attackPoints, defensePoints, stealthMode) {
                parent.init.call(this, name, attackPoints, defensePoints, 200, stealthMode, 'Fighter');

                console.log('Fighter ' + this.name + ' manufactured - attack: ' + this.attackPoints + '; defense: ' + this.defensePoints + '; stealth: ' + (this.mode ? 'ON' : 'OFF'));

                return this;
            }
        });

        Object.defineProperty(fighter, 'toString', {
            value: function () {
                var result = '';

                result += parent.toString.call(this);
                result += ' *Stealth: ' + (this.mode ? 'ON' : 'OFF');

                return result;
            }
        });

        return function (name, attackPoints, defensePoints, mode) {
            return Object.create(fighter)
                .init(name, attackPoints, defensePoints, mode);
        };
    }(machine));

    var tank = (function (parent) {
        var tank = Object.create(parent);

        Object.defineProperty(tank, 'init', {
            value: function (name, attackPoints, defensePoints) {
                parent.init.call(this, name, attackPoints, defensePoints, 100, false, 'Tank');
                this.toggleMode();

                console.log('Tank ' + this.name + ' manufactured - attack: ' + this.attackPoints + '; defense: ' + this.defensePoints);

                return this;
            }
        });

        Object.defineProperty(tank, 'toString', {
            value: function () {
                var result = '';

                result += parent.toString.call(this);
                result += ' *Defense: ' + (this.mode ? 'ON' : 'OFF');

                return result;
            }
        });

        Object.defineProperty(tank, 'toggleMode', {
            value: function () {
                if (this.mode) {
                    this.defensePoints -= 30;
                    this.attackPoints += 40;
                } else {
                    this.defensePoints += 30;
                    this.attackPoints -= 40;
                }
                parent.toggleMode.call(this);

            }
        });

        return function (name, attackPoints, defensePoints) {
            return Object.create(tank)
                .init(name, attackPoints, defensePoints);
        };
    }(machine));

    return {
        hirePilot: pilot,
        manufactureTank: tank,
        manufactureFighter: fighter,
    }
}());

var factory = Object.create(factory);
var john = factory.hirePilot('John');
var nelson = factory.hirePilot('Nelson');
var t72 = factory.manufactureTank('T-72', 100, 100);
var kingcobra = factory.manufactureFighter('Kingcobra', 150, 90, true);
john.addMachine(t72).addMachine(kingcobra);
console.log(john.report());
t72.attack(kingcobra);
console.log(john.report());
t72.attack(kingcobra);
console.log(john.report());