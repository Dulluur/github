/** ЗАДАЧА 31 - Интервалы и Таймауты
 *
 * Используйте следующие встроенные функции:
 * setTimeout
 * setInterval
 * clearInterval
 *
 * Нужно вывести в консоль ТОЛЬКО 5 сообщений с интервалом 2 секунды:
 * "Сообщение номер 1"
 * "Сообщение номер 2"
 * "Сообщение номер 3"
 * "Сообщение номер 4"
 * "Сообщение номер 5"
 */

let number = 1;

const messageInterval2 = setInterval(() => {
  console.log(`Сообщение номер ` + number);
  number += 1;
}, 2000);

setTimeout(() => clearInterval(messageInterval2), 11000)

//С корем пополам сделал, малеха болею, поэтому запомнить сложно

