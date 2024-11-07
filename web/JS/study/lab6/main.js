const arr = [1, 2, 3, 4, 5];
const str = ["one", "two", "three", "four", ["five", "six", "seven"]];

//1
const arr_new1 = arr.map((ch, ind) => ch + (2 * ind));
console.log(arr_new1);

//2
//Подсчитайте количество элементов массива arr, оканчивающихся на цифру 0
// const countZero = arr.filter(item => item % 10 === 0).length;
// console.log(countZero)

//3
// Сформируйте новый массив arr_new2, каждый элемент которого будет равен средним значениям соседних элементов arr, начиная с первого элемента arr.

// const arr_new2 = arr.map((element, index) => {
//   if (index === 0) {
//     return (element + arr[index + 1]) / 2;
//   }
//   else if (index === arr.length - 1) {
//     return (element + arr[index - 1]) / 2;
//   }
//   else {
//     return (arr[index - 1] + element + arr[index + 1]) / 3;
//   }
// });

//4
//Создайте стрелочную функцию для вывода числа, полученного из k-го элемента arr, путем перестановки цифр этого элемента в обратном порядке. Встроенную функцию reverse использовать нельзя.


