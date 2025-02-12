"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var employee_1 = require("./employee");
var employees = [
    new employee_1.emp(1, "LA", 88234),
    new employee_1.emp(2, "lokesh", 88234),
    new employee_1.emp(3, "asrith", 82245),
    new employee_1.emp(4, "MRL", 88222)
];
employees.forEach(function (x) {
    console.log(x.empno + " " + x.name + " " + x.salary);
});
