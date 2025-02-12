import { emp } from './employee';

const employees = [
    new emp(1, "LA",88234),
    new emp(2,"lokesh",88234),
    new emp(3, "asrith",82245),
    new emp(4, "MRL",88222)
]

employees.forEach(x => {
    console.log(x.empno + " " + x.name + " " + x.salary)
})