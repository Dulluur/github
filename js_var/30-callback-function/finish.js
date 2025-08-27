/** ЗАДАЧА 30 - Колбэк функция
 *
 * 1. Что будет выведено в консоль?
 * Постарайтесь ответить без запуска кода.
 *
 * 2. Нужно ли как-то исправить этот код?
 */

// setTimeout(function myFn() {
//   console.log('Привет из функции myFn')
// }, 2000)

// myFn()

// function myFn2(){
//   setTimeout(console.log('Привет из функции MyFN2'), 2000)
// }
// myFn2()

function myFn2() {
  setTimeout(() => console.log('Привет из функции myFn2'), 2000)
}
myFn2()

