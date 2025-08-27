/** ЗАДАЧА 34 - Массив объектов
 *
 * 1. Создайте массив с 3 объектами "cars"
 *
 * 2. Каждый объект должен иметь три свойства
 *  - carBrand (строка)
 *  - price (число)
 *  - isAvailableForSale (логическое значение)
 *
 * 3. Добавьте еще один объект в массив
 *
 * 4. Выведите результирующий массив в консоль
 */

let myCars = [
    {
        cardBrand:"BMW",
        price:10,
        isAvailableForSale:true
    },
    {
        cardBrand:"Toyota",
        price:20,
        isAvailableForSale:true
    },
    {
        cardBrand:"Mercedes",
        price:30,
        isAvailableForSale:false
    }
]
const newCarZoro = {
    cardBrand:"Zoro",
    price:40,
    isAvailableForSale:false
}

myCars.push(newCarZoro)

console.log(myCars)
