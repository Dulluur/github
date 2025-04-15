/** ЗАДАЧА 39 - Перебор элементов массива
 *
 * 1. Создайте функцию "cityInfo" с двумя параметрами,
 * которая возвращает строку
 * "London is at the index 0 in the myCities array"
 *
 * 2. Переберите все элементы массива "myCities",
 * для каждого элемента вызовите функцию "cityInfo"
 * и выведите в консоль результат вызова функции
 */

const myCities = ['London', 'New York', 'Singapore']


<<<<<<< HEAD
function cityInfo(city, index){
    return `${city} is at the index ${index} in the myCities array`;
}

// myCities.forEach((city,index) =>{
//     console.log(city,index)
// })

console.log(cityInfo("London",0))
=======
const findCities = (element, index) =>{
    return `${element} is at the index ${index} in the myCities array`
}

myCities.forEach((element, index) => console.log(findCities(element, index)))
>>>>>>> e44afe0a011f2d7f6aaef131bd8a9256147e0323
