/** ЗАДАЧА 12 - Создание объекта
 *
 * 1. Создайте объект с тремя свойствами:
 *  - name
 *  - surname
 *  - favoriteNumber
 *
 * 2. Выведите в консоль строку
 * "My name is <name> <surname> and my favorite number is <favoriteNumber>"
 */

const user = {
  name: "Du",
  surname: "Okoneshnikov",
  favoriteNumber: "95815",
};

const resultText = `My name is ${user.name} ${user.surname} and my favorite number is ${user.favoriteNumber}`;
console.log(resultText);
