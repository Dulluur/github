/** ЗАДАЧА 4 - Объединение строк
 *
 * 1. Объявите три переменные с значениями:
 *  - ваше имя
 *  - ваша фамилия
 *  - ваша профессия
 *
 * 2. Создайте еще одну переменную. Ее значение должно быть, например
 * "Меня зовут <Имя> <Фамилия> и я <Профессия>"
 *
 * 3. Выведите значение последней переменной в консоль
 */



const firstName = "Du"
const surname = "Okoneshnikov"
const profile = "Developer"

const user = `Меня зовут ${firstName} ${surname} и я ${profile}`

console.log(user)
const yearBird = prompt('How old are u?: ', 18)

if(yearBird > 18){
    console.log("Доступ разрешене")
}
else if(yearBird < 18){
    console.log("Доступ не разрешен, слишком маленький")
}
else{
    console.log("Введено не правильное значение")
}

