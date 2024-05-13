function stringChanger(str) {
  let result = "";
  let letters = ["а", "е", "ё", "d"];

  for (let i = 0; i < str.length; i++) {
    if (letters.includes(str[i])) {
      result = result + str[i].toUpperCase();
    } else {
      result = result + str[i].toLowerCase();
    }
  }

  return result;
}

console.log(stringChanger("du ахуенный"));
