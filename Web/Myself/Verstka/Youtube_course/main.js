const calculartor = {
  read() {
    this.a = Number(prompt("Введите первое число: ", 0));
    this.b = Number(prompt("Введите второе число: ", 0));
  },
  sum() {
    return this.a + this.b
  },
  mul() {
    return this.a * this.b
  },
};

calculartor.read()
console.log('calculator: ', calculartor)
console.log('Сумма:', calculartor.sum())
console.log('Произведение: ', calculartor.mul())
