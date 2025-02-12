var calc = function (a, b, c) {
    if (typeof c !== 'undefined') {
        return a + b + c;
    }
    return a + b;
};
console.log(calc(90, 27, 1220103));
console.log(calc(90, 27));
