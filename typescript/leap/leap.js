function equallyDivisibleBy(year) {
    return function (test) { return (year % test === 0); };
}
exports["default"] = function (year) {
    var dividesEqual = equallyDivisibleBy(year);
    return (dividesEqual(4) &&
        (!dividesEqual(100) || dividesEqual(400)));
};
