import { testss } from './test';

class tests {
    constructor(private _test : testss)
    {
        
    }
    show = () => {
        console.log(this._test.sum(90,27));
        console.log(this._test.sub(12,45));
        console.log(this._test.mult(12,5));
    }
}