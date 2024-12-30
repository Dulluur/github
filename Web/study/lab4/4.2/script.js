var arr = []; // массив случайных чисел для генерации картинок
var trabl = 0; // счетчик открытых квадратов
var finish = 0; // подсчет найденных пар
var gameStarted = false; // флаг начала игры
var isProcessing = false; // флаг обработки пар

// кликаем на квадратик
function ClickBox(elem, i) {
    if (!gameStarted || isProcessing) return;

    var box = document.getElementById(elem.id);

    // проверяем, открыт ли квадрат или уже найден
    if (box.classList.contains('matched') || box.style.backgroundImage.indexOf('rub.jpg') === -1) {
        return;
    }

    var c = arr[i - 1] + 1;
    box.style.backgroundImage = 'url("images/img' + c + '.jpg")';
    box.style.backgroundSize = 'cover';

    if (trabl == 0) {
        trabl = elem;
    } else {
        if (trabl.id == elem.id) {
            return; // повторный клик по тому же квадрату
        }

        isProcessing = true; // блокируем дальнейшие клики

        var tr = document.getElementById(trabl.id);
        if (tr.style.backgroundImage == box.style.backgroundImage) {
            setTimeout(DeleteBox, 300, elem);
            // звук при найденной паре
            var audio = new Audio();
            audio.src = "sound/found_pair.mp3";
            audio.autoplay = true;
        } else {
            setTimeout(CloseBox, 300);
            // звук при ошибке
            var audio = new Audio();
            audio.src = "sound/error.mp3";
            audio.autoplay = true;
        }
    }
}

// закрашиваем угаданные квадраты желтым цветом
function DeleteBox(el) {
    var box1 = document.getElementById(el.id);
    var box2 = document.getElementById(trabl.id);
    box1.classList.add('matched');
    box2.classList.add('matched');
    box1.style.backgroundImage = 'none';
    box2.style.backgroundImage = 'none';
    box1.style.backgroundColor = 'yellow';
    box2.style.backgroundColor = 'yellow';
    trabl = 0;
    finish++;
    isProcessing = false;

    if (finish == 8) {
        var span = document.getElementById("span");
        span.innerHTML = "Молодец!!!";
        // звук окончания игры
        var audio = new Audio();
        audio.src = "sound/game_over.mp3";
        audio.autoplay = true;
        // показываем кнопку "Начать игру заново"
        var sbmt = document.getElementById("sbmt");
        sbmt.innerHTML = "Начать игру заново";
        sbmt.style.display = "block";
        gameStarted = false;
    }
}

// закрываем квадраты
function CloseBox() {
    var chDiv = document.getElementsByClassName("div1");
    for (var i = 0; i < chDiv.length; i++) {
        if (!chDiv[i].classList.contains('matched')) {
            chDiv[i].style.backgroundImage = 'url("images/rub.jpg")';
            chDiv[i].style.backgroundSize = 'cover';
        }
    }
    trabl = 0;
    isProcessing = false;
}

// возвращаем случайное число
function getRandomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

// возвращаем количество одинаковых чисел
function ReturnTr(tr) {
    var t = 0;
    for (var i = 0; i < arr.length; i++) {
        if (tr == arr[i]) t++;
    }
    return t;
}

// заполняем массив arr случайными числами
function Start(elem) {
    arr = []; // очищаем массив
    finish = 0;
    gameStarted = true;
    isProcessing = false;
    trabl = 0;

    // сбрасываем квадраты
    var chDiv = document.getElementsByClassName("div1");
    for (var i = 0; i < chDiv.length; i++) {
        chDiv[i].style.backgroundImage = 'url("images/rub.jpg")';
        chDiv[i].style.backgroundColor = '';
        chDiv[i].classList.remove('matched');
        chDiv[i].style.backgroundSize = 'cover';
    }
    var span = document.getElementById("span");
    span.innerHTML = "";

    for (var i = 0; i < 16; i++) {
        var tr = getRandomInt(0, 7); // случайное число от 0 до 7 (8 картинок)
        if (ReturnTr(tr) < 2) arr[i] = tr;
        else i--;
    }
    elem.style.display = "none";
}
