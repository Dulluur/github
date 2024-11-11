const arr = [11, 23, 34, 45, 56, 100];
const str = ["one", "two", "three", "four", ["five", "six", "seven"]];

//1
const arr_new1 = arr.map((ch, ind) => ch + 2 * ind);
// console.log(arr_new1);

//2
//Подсчитайте количество элементов массива arr, оканчивающихся на цифру 0
const countZero = arr.filter((item) => item % 10 === 0).length;
// console.log(countZero)

//3
// Сформируйте новый массив arr_new2, каждый элемент которого будет равен средним значениям соседних элементов arr, начиная с первого элемента arr.

const arr_new2 = arr.map((element, index) => {
  if (index === 0) {
    return (element + arr[index + 1]) / 2;
  } else if (index === arr.length - 1) {
    return (element + arr[index - 1]) / 2;
  } else {
    return (arr[index - 1] + element + arr[index + 1]) / 3;
  }
});

// console.log(arr_new2)

//4
//Создайте стрелочную функцию для вывода числа, полученного из k-го элемента arr, путем перестановки цифр этого элемента в обратном порядке. Встроенную функцию reverse использовать нельзя.
const k = 1;
const fn4 = (arr, k) => {
  let num = arr[k];
  let reversedNum = 0;
  while (num > 0) {
    const lastDigit = num % 10;
    reversedNum = reversedNum * 10 + lastDigit;
    num = Math.floor(num / 10);
  }
  return reversedNum;
};

// console.log(fn4(arr, k));

//5
//Простыми числами называются те, которые делятся только на единицу и на себя. Удалите из массива arr элементы, являющиеся простыми числами.
const isPrime = (num) => {
  if (num <= 1) return false;
  for (let i = 2; i <= Math.sqrt(num); i++) {
    if (num % i === 0) return false;
  }
  return true;
};

const removePrimes = (arr) => {
  return arr.filter((num) => !isPrime(num));
};

const result = removePrimes(arr);
// console.log(result);

//6
// Создайте функцию для вывода k-го символа из n-го элемента массива str.

let fn6 = (k, n, str) => {
  const newStr = str.map((el, indx) => {
    if (indx == n) {
      const newWord = el.split("").map((letter, iter) => {
        if (iter === k) console.log(letter);
      });
    }
  });
};
// fn6(3, 2, str);

//7
//Создайте массив, состоящий из всех строчных элементов массива str и вставьте его вторым по порядку элементом в массив str.

const lowerCaseElements = str.flat().filter((item) => typeof item === "string");
str.splice(1, 0, lowerCaseElements);

// console.log(str);

//8
//Создайте стрелочную функцию, принимающую аргумент k. Данная функция должна выводить количество символов k-го элемента, взятого из последнего элемента str, представляющего собой массив.
let eight = (k) => {
  k = 1;
  str.map((el, ind) => {
    if (ind == str.length - 1) {
      for (let i = 0; i < el.length; i++) {
        if (i == k) {
          console.log(el[i].length);
        }
      }
    }
  });
};
eight();

//9
// Создайте стрелочную функцию, которая меняет местами k-й и n-й элементы массива str.
let ninth = (n, k) => {
  n = 3;
  k = 2;
  let temp;
  temp = str[n];
  str[n] = str[k];
  str[k] = temp;
  console.log(str);
};
// ninth()

//10
//Подсчитайте общее количество вхождений символа «с» (без учета регистра) в нечетные строки массива str.
let tenth = () => {
  let word = "o";
  let count = 0;
  str.map((el, ind) => {
    if (typeof el == "object") {
      for (let i = 0; i < el.length; i++) {
        for (let j = 0; j < el[i].length; j++) {
          // console.log(el[i][j])
          if (el[i][j].toLowerCase() == word) {
            count++;
          }
        }
      }
    }
    for (let i = 0; i < el.length; i++) {
      if (el[i].toLowerCase() == word) {
        count++;
      }
    }
  });
  console.log(count);
};
// tenth()

//11
//Создайте стрелочную функцию для вывода строки, состоящей изпервых букв каждого элемента str, также в эту строку должны входитьпервые символы элементов из последнего элемента str.
let eleven = () => {
  var ans = "";
  str.map((el, ind) => {
    if (ind == str.length - 1) {
      // console.log(el[0][0])
      ans += el[0][0];
    } else {
      ans += el[0];
    }
  });
  console.log(ans);
};
// eleven()

//12
//Выведите массив, состоящий из элементов str, каждый из которыхзаписан в обратном порядке. Встроенные функции использовать нельзя.
let twelve = () => {
  let reversed = (x) => {
    let y = "";
    for (let i = x.length - 1; i >= 0; i--) {
      y += x[i];
    }
    return y;
  };
  rever_str = str.map((el, ind) => {
    if (ind == str.length - 1) {
      for (let i = 0; i < el.length; i++) {
        el[i] = reversed(el[i]);
      }
      return el;
    } else {
      el = reversed(el);
      return el;
    }
  });
  console.log(rever_str);
};
// twelve()
