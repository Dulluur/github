/** ЗАДАЧА 10 - Комментарий перед функцией
 *
 * 1. Объявите функцию с двумя параметрами, значения которых - числа
 *
 * 2. Эта функция должна возвращать разницу между первым и вторым параметром
 *
 * 3. Добавьте многострочный комментарий перед функцией:
 *  - Текст комментария "Возвращает разницу двух чисел"
 *  - Укажите тип параметров - number
 *  - Укажите тип возвращаемого значения - number
 *  - Опишите возвращаемое значение - "Разница чисел"
 *
 * 4. Вызовите функцию
 */


/**
 * Возвращает разницу двух чисел
 * @param {number} firstNumber
 * @param {number} secondNumber
 * @returns {number} Разница чисел
 */

const firstNumber = 23
const secondNumber = 18

function reverseNubmer (firstNumber, secondNumber){
    result = firstNumber - secondNumber
    console.log(result)
}

reverseNubmer(firstNumber, secondNumber)