"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.emp = void 0;
var emp = /** @class */ (function () {
    function emp(empno, name, salary) {
        this.empno = empno;
        this.name = name;
        this.salary = salary;
    }
    return emp;
}());
exports.emp = emp;
/*
export class emp { ... }
Defines a class named emp.
The export keyword allows this class to be imported into other files.
Example Import (in another file):
import { emp } from "./emp";
*/
