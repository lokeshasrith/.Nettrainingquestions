const calc = (a :number, b : number, c? : number) => {
    if(typeof c !=='undefined') {
        return a+b+c
    }
    return a+b
}
console.log(calc(90,27,1220103))
console.log(calc(90,27))