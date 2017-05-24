"use strict";
exports.__esModule = true;
var Hamming = (function () {
    function Hamming() {
    }
    Hamming.prototype.compute = function (a, b) {
        if (a.length !== b.length) {
            throw new Error('DNA strands must be of equal length.');
        }
        return a.slice().reduce(function (acc, value, index) {
            return value !== b[index] ? acc += 1 : acc;
        }, 0);
    };
    return Hamming;
}());
exports["default"] = Hamming;
