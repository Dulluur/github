let arr = [10, 25, 30, 47, 50];
let str = ["apple", "banana", "cherry", "date", ["elm", "fig", "grape"]];

const reverseNumber = (k) => {
  let numStr = arr[k].toString();
  let reversedStr = "";
  for (let i = numStr.length - 1; i >= 0; i--) {
      reversedStr += numStr[i];
  }
  return parseInt(reversedStr, 10);
};
console.log("Обратный порядок цифр k-го элемента:", reverseNumber(1));

