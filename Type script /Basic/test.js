"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.test = void 0;
var test = /** @class */ (function () {
    function test() {
        this.sum = function (a, b) { return a + b; };
        this.sub = function (a, b) { return a - b; };
        this.mult = function (a, b) { return a * b; };
    }
    return test;
}());
exports.test = test;
