/** ЗАДАЧА 38 - Тернарный оператор
 *
 * 1. Перепишите инструкцию "if .. else" без использования "else"
 *
 * 2. Перепишите содержимое функции, используя тернарный оператор
 *
 * 3. Замените обычную функцию на стрелочную функцию
 */

function isArrayEmpty(inputArray) {
  if (inputArray.length > 0) {
    return 'Массив не пустой'
  } else {
    return 'Массив пустой'
  }
}

//1
function isArrayEmptyFirst(inputArray){
  if(inputArray.length > 0){
    return "Массив не пустой"
  }
  return "Массив пустой"
}

//3
const isArrayEmptySecond = (inputArray) => 
  inputArray.length > 0 ? "Массив не пустой" : "Массив пустой"


//2
function isArrayEmptyThird(inputArray){
  inputArray.length > 0 ? 'Массив не пустой' : 'Массив пустой'
}

// console.log(isArrayEmpty([1, 3]))
// console.log(isArrayEmpty([]))

// console.log(isArrayEmptySecond([1, 3]))
// console.log(isArrayEmptySecond([]))

// console.log(isArrayEmptyThird([1, 3]))
// console.log(isArrayEmptyThird([]))

console.log(isArrayEmptyFirst([1, 3]))
console.log(isArrayEmptyFirst([]))
