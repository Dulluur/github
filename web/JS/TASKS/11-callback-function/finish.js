/** ЗАДАЧА 11 - Колбэк функция
 *
 * 1. Выведите в консоль "Привет, мир!" с задержкой 5 секунд
 *
 * 2. Используйте стрелочную функцию
 */

// function printWorld(){
//     console.log("Привет, мир!")
// }

// setTimeout(printWorld, 5000)

setTimeout (()=> console.log("Привет, мир!"), 5000)

let a
let b
function myFn(){
    let b
    a = true
    b = 10
    console.log(b)
}

myFn()

console.log(a)
console.log(b)
