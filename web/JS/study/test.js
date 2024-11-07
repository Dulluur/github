// Инициализация массивов
let arr = [10, 25, 30, 47, 50];
let str = ["apple", "banana", "cherry", "date", ["elm", "fig", "grape"]];

// Задание 1
let arr_new1 = arr.map((num, index) => num + index * 2);
console.log("arr_new1:", arr_new1);