let canvas = document.getElementById("canvas");
let context = canvas.getContext("2d");
let image = new Image();

image.onload = () => {
    let x = canvas.width - 100; // Начальная позиция по X (справа)
    let y = (canvas.height - 100) / 2; // Центрирование по Y
    let dx = -2; // Скорость и направление по X
    let angle = 0; // Угол поворота в градусах

    function animate() {
        // Очищаем канвас
        context.clearRect(0, 0, canvas.width, canvas.height);

        // Сохраняем состояние контекста
        context.save();

        // Переносим начало координат в центр мяча
        context.translate(x + 50, y + 50); // 50 — половина размера мяча (100 / 2)

        // Поворачиваем контекст на текущий угол
        context.rotate(angle * Math.PI / 180); // Преобразуем градусы в радианы

        // Рисуем мяч со смещением, чтобы центр совпадал с точкой поворота
        context.drawImage(image, -50, -50, 100, 100);

        // Восстанавливаем состояние контекста
        context.restore();

        // Обновляем позицию и угол
        x += dx;
        angle += 2; // Увеличиваем угол для поворота (скорость вращения)

        // Если угол больше 360, обнуляем его
        if (angle >= 360) {
            angle = 0;
        }

        // Проверяем столкновение с границами и меняем направление движения
        if (x <= 0) {
            dx = 2; // Движение вправо
        } else if (x + 100 >= canvas.width) {
            dx = -2; // Движение влево
        }

        // Запрашиваем следующий кадр анимации
        requestAnimationFrame(animate);
    }

    // Запускаем анимацию
    animate();
};

image.src = "img/ball.png";
