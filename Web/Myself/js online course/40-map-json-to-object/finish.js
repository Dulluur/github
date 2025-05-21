/** ЗАДАЧА 40 - Конвертация JSON в JavaScript объекты
 *
 * 1. Конвертируйте массив JSON объектов в массив объектов JavaScript
 *
 * 2. Выведите в консоль результирующий массив
 *
 * 3. Выведите в консоль "postId" второго объекта
 *
 * 4. Выведите в консоль "commentsQuantity" последнего объекта
 */

const postsJSON = [
  '{"postId":1355,"commentsQuantity":5}',
  '{"postId":5131,"commentsQuantity":13}',
  '{"postId":6134,"commentsQuantity":2}',
  '{"postId":2351,"commentsQuantity":8}',
]

let someMassive = postsJSON.map(JSON.parse)
// console.log(someMassive)
// console.log(someMassive[1])
console.log(someMassive[someMassive.length-1].commentsQuantity)

let someMassMassive = postsJSON.map(JSON.parse)
console.log(someMassMassive)
console.log(someMassMassive[1])
console.log(someMassMassive[someMassMassive.length-1].commentsQuantity)
