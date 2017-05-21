var HelloWorld = function() {};

HelloWorld.prototype.hello = function(input) {
    var name = input ? input : "World"

    return "Hello, " + name + "!";
};

module.exports = HelloWorld;
