export class emp {
    constructor(public empno: number, public name: string, 
        public salary : number )
        {

        }
}
/*
export class emp { ... }
Defines a class named emp.
The export keyword allows this class to be imported into other files.
Example Import (in another file):
import { emp } from "./emp";
*/
