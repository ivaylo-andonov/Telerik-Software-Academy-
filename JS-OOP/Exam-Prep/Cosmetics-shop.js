var CosmeticShop = (function () {
    var categories = [];

    var product = (function () {
        var product = {},
            typeGender = {
                men: 'men',
                women: 'women',
                unisex: 'unisex'
            };

        function validateProduct(name, price, brand, gender) {
            validateProductName(name);
            validateProductPrice(price);
            validateProductBrand(brand);
            validateProductGender(gender);
        }

        function validateProductPrice(price) {
            if (isNaN(price) || price < 0) {
                throw new Error('Product price must be a possitive number');
            }
        }

        function validateProductGender(gender) {
            if (!typeGender[gender]) {
                throw new Error('Product gender type must be one of the Men, Women or Unisex');
            }
        }

        function validateProductName(name) {
            if (typeof name !== 'string') {
                throw new Error('Product name must be a string!');
            }

            if (name.length < 3 || name.length > 10) {
                throw new Error('Product name must be between ' + 3 + ' and ' + 10 + ' symbols long!');
            }
        }

        function validateProductBrand(brand) {
            if (typeof brand !== 'string') {
                throw new Error('Product brand must be a string!');
            }

            if (brand.length < 2 || brand.length > 10) {
                throw new Error('Product brand must be between ' + 2 + ' and ' + 10 + ' symbols long!');
            }
        }

        Object.defineProperty(product, 'init', {
            value: function init(name, price, brand, gender) {
                validateProduct(name, price, brand, gender);

                this.name = name;
                this.price = price;
                this.brand = brand;
                this.gender = typeGender[gender];

                return this;
            }
        });

        Object.defineProperty(product, 'getInfo', {
            value: function () {
                return 'Info: ' + this.name + ' ' + this.price + ' ' + this.brand + ' ' + this.gender;
            }
        });

        return product;
    }());

    var shampoo = (function (parent) {
        var shampoo = Object.create(parent),
            usageTypes = {
                everyday: 'everyday',
                medical: 'medical'
            };

        function validateShampoo(milliliters, type) {
            validateShampooMilliliters(milliliters);
            validateShampooUsageType(type);
        }

        function validateShampooMilliliters(milliliters) {
            if (isNaN(milliliters) || milliliters < 0) {
                throw new Error('Shampoo milliliters must be a possitive number');
            }
        }

        function validateShampooUsageType(type) {
            if (!usageTypes[type]) {
                throw new Error('Shampoo usage type must be one of the EveryDay or Medical');
            }
        }

        Object.defineProperty(shampoo, 'init', {
            value: function (name, price, brand, gender, milliliters, usage) {

                validateShampoo(milliliters, usage);

                var finalPrice = price * milliliters;

                parent.init.call(this, name, finalPrice, brand, gender);
                this.milliliters = milliliters;
                this.usage = usageTypes[usage];

                return this;
            }
        });

        Object.defineProperty(shampoo, 'getInfo', {
            value: function () {
                return parent.getInfo.call(this) + ' ' + this.milliliters + ' ' + this.usage;
            }
        });

        return shampoo;
    }(product));

    var toothpaste = (function (parent) {
        var toothpaste = Object.create(parent);

        function validateIngredients(ingredients) {
            if (!Array.isArray(ingredients)) {
                throw new Error('Toothpaste ingredients must be a string!');
            }

            ingredients.forEach(function (ingr) {
                if (typeof ingr !== 'string') {
                    throw new Error('Toothpaste\'s ingredient name must be a string!');
                }

                if (ingr.length < 4 || ingr.length > 12) {
                    throw new Error('Each ingredient must be between ' + 4 + ' and ' + 12 + ' symbols long!');
                }
            });
        }

        Object.defineProperty(toothpaste, 'init', {
            value: function (name, price, brand, gender, ingredients) {
                parent.init.call(this, name, price, brand, gender);
                this.ingredients = ingredients.join(', ');

                return this;
            }
        });

        Object.defineProperty(toothpaste, 'getInfo', {
            value: function () {
                return parent.getInfo.call(this) + ' ' + this.ingredients;
            }
        });

        return toothpaste;
    }(product));

    var category = (function () {
        var category = {},
            products = [];

        function validateCategoryName(name) {
            if (typeof name !== 'string') {
                throw new Error('Category name must be a string!');
            }

            if (name.length < 2 || name.length > 15) {
                throw new Error('Category name must be between ' + 2 + ' and ' + 15 + ' symbols long!');
            }
        }

        function checkIfCategoryExists(categoryName) {
            var isCategoryExists = categories.some(function (category) {
                return category.name === categoryName;
            });

            return isCategoryExists;
        }

        function getProductByName(name) {
            var productAsArray = products.filter(function (prod) {
                return prod.name === name;
            });

            return productAsArray[0];
        }

        Object.defineProperty(category, 'init', {
            value: function (name) {
                validateCategoryName(name);

                if (!checkIfCategoryExists(name)) {
                    categories.push({ name: name });
                }

                this.name = name;
                products = [];

                return this;
            }
        });

        Object.defineProperty(category, 'add', {
            value: function (product) {
                products.push(product);
                return this;
            }
        });

        Object.defineProperty(category, 'remove', {
            value: function (productName) {
                var product, index;

                product = getProductByName(productName);
                index = products.indexOf(product);

                if (index > -1) {
                    products.splice(index, 1);
                }
            }
        });

        return category;
    }());

    var shoppingCart = (function () {
        var shoppingCart = {},
            products = [];


        function getProductByName(name) {
            var productAsArray = products.filter(function (prod) {
                return prod.name === name;
            });

            return productAsArray[0];
        }

        Object.defineProperty(shoppingCart, 'add', {
            value: function (product) {
                products.push(product);
                return this;
            }
        });

        Object.defineProperty(shoppingCart, 'remove', {
            value: function (productName) {
                var product, index;

                product = getProductByName(productName);
                index = products.indexOf(product);

                if (index > -1) {
                    products.splice(index, 1);
                }
            }
        });

        Object.defineProperty(shoppingCart, 'getTotalPrice', {
            value: function () {
                var totalPrice = products.reduce(function (sum, prod) {
                    return sum + prod.price;
                }, 0);

                return totalPrice;
            }
        });

        return shoppingCart;
    }());
}());