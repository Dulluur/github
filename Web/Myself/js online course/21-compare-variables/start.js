/** ЗАДАЧА 21 - Сравнение переменных
 *
 * 1. Сравните 2 переменные "myVariable1" и "myVariable2".
 * Выведите в консоль "true", если значение "myVariable1" меньше или равно "myVariable2".
 *
 * 2. Преобразуйте обе переменные в числа перед сравнением.
 */

let myVariable1 = 10;
let myVariable2 = "5";

myVariable1 = Number(myVariable1);
myVariable2 = Number(myVariable2);

// if (myVariable1 <= myVariable2) {
//   console.log(true);
// } else {
//   console.log(false);
// }
// Напишите код здесь

myVariable1 = "20";
myVariable2 = 100;

// Напишите код здесь
// if (myVariable1 <= myVariable2) {
//   console.log(true);
// } else {
//   console.log(false);
// }

//Улучшенное решение

function compareValue(vol1, vol2) {
  let num1 = Number(vol1);
  let num2 = Number(vol2);

  console.log(num1 <= num2);
}

compareValue(10, "5");
compareValue("20", 100);
