"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var tests = /** @class */ (function () {
    function tests(_test) {
        var _this = this;
        this._test = _test;
        this.show = function () {
            console.log(_this._test.sum(90, 27));
            console.log(_this._test.sub(12, 45));
            console.log(_this._test.mult(12, 5));
        };
    }
    return tests;
}());
