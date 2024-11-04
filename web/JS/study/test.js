let randomNumber = Number(trunc(Math.random() * 5) + 1)

let pickNumber = Number(prompt("Попробуй отгадать число: "))

if(!Number.isInteger(pickNumber) || pickNumber < 1 || pickNumber > 5){
  alert("НЕ ТАК")
}else if(pickNumber === randomNumber){
  alert("Верно")
}else{
  alert(`Нет не ${pickNumber}, я загадол число ${randomNumber}`)
}