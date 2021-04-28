let elems_num = 20000000;

//let humans = new Array(elems_num);
// 
let humans = [];

console.time("alloc");
for (let i = 0; i < elems_num; i++)
{
    humans.push({Age: i, F1: 0, F2: 0, F3: 0, F4: 0});
}
console.timeEnd("alloc");

let humans_ages = new Array(elems_num).fill(0);

console.time("map");
for (let i = 0; i < elems_num; i++)
{
    humans_ages[i] = humans[i].Age;
}
console.timeEnd("map");