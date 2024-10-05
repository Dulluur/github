// 1. Максимум и минимум числовой последовательности
function findMinMax() {
  const sequence = [12, 5, 8, 130, 44];
  const min = Math.min(...sequence);
  const max = Math.max(...sequence);
  document.getElementById(
    "minMaxResult"
  ).innerText = `Минимум: ${min}, Максимум: ${max}`;
}

// 2. Средняя оценка по 10 предметам
function calculateAverage() {
  const grades = [4, 5, 3, 4, 5, 3, 4, 5, 3, 4];
  const sum = grades.reduce((a, b) => a + b, 0);
  const average = sum / grades.length;
  document.getElementById(
    "averageResult"
  ).innerText = `Средняя оценка: ${average}`;
}

// 3. Факториал натурального числа n
function calculateFactorial() {
  const n = 5;
  let factorial = 1;
  for (let i = 1; i <= n; i++) {
    factorial *= i;
  }
  document.getElementById(
    "factorialResult"
  ).innerText = `Факториал ${n}: ${factorial}`;
}

// 4. Сумма цифр трехзначного числа
function sumDigits() {
  const number = 123;
  const sum = number
    .toString()
    .split("")
    .reduce((a, b) => a + parseInt(b), 0);
  document.getElementById(
    "sumDigitsResult"
  ).innerText = `Сумма цифр числа ${number}: ${sum}`;
}

// 5. Сортировка последовательности вещественных чисел
function sortSequence() {
  const sequence = [5.3, 2.1, 4.7, 1.8, 3.6];
  const sorted = sequence.sort((a, b) => a - b);
  document.getElementById(
    "sortedSequenceResult"
  ).innerText = `Отсортированная последовательность: ${sorted.join(", ")}`;
}

// 6. Подсчет букв "а" (русская) в строке
function countLetterA() {
  const text = "Абракадабра";
  const count = text.toLowerCase().split("а").length - 1;
  document.getElementById(
    "letterACountResult"
  ).innerText = `Количество букв "а": ${count}`;
}

// 7. Подсчет одинаковых слов в предложении
function countSameWords() {
  const sentence = "Синий белый красный синий красный синий";
  const words = sentence.toLowerCase().split(" ");
  const wordCount = words.reduce((acc, word) => {
    acc[word] = (acc[word] || 0) + 1;
    return acc;
  }, {});
  let total = 0;
  for (let word in wordCount) {
    if (wordCount[word] > 1) {
      total += wordCount[word];
    }
  }
  document.getElementById(
    "sameWordsCountResult"
  ).innerText = `Количество одинаковых слов: ${total}`;
}
