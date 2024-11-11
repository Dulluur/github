// Инициализация массивов
// let arr = [10, 25, 30, 47, 50];
// let str = ["apple", "banana", "cherry", "date", ["elm", "fig", "grape"]];

// Задание 1
// let arr_new1 = arr.map((num, index) => num + index * 2);
// console.log("arr_new1:", arr_new1);


const reverseDigits = (arr, k) => {
    let num = arr[k]; // Получаем k-й элемент массива
    let reversedNum = 0; // Переменная для хранения перевернутого числа
    while (num > 0) {
        // Получаем последнюю цифру
        const lastDigit = num % 10;
        // Добавляем её к reversedNum
        reversedNum = reversedNum * 10 + lastDigit;
        // Убираем последнюю цифру из num
        num = Math.floor(num / 10);
    }
    return reversedNum; // Возвращаем перевернутое число
};

// Пример использования:
const arr = [123, 456, 789];
const k = 1;
console.log(reverseDigits(arr, k)); // Вывод: 654
