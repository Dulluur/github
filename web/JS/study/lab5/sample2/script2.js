let canvas = document.getElementById("canvas");
let context = canvas.getContext("2d");
let image = new Image();

image.onload = () => {
    let x = canvas.width - 100; // Начальная позиция по X (справа)
    let y = (canvas.height - 100) / 2; // Центрирование по Y
    let dx = -5; // Скорость и направление по X
    let angle = 0; // Угол поворота в градусах
    let dAngle = 5; // Скорость и направление вращения

    function animate() {
        // Очищаем канвас
        context.clearRect(0, 0, canvas.width, canvas.height);

        // Сохраняем состояние контекста
        context.save();

        // Переносим начало координат в центр мяча
        context.translate(x + 50, y + 50);

        // Поворачиваем контекст на текущий угол
        context.rotate(angle * Math.PI / 180);

        // Рисуем мяч со смещением
        context.drawImage(image, -50, -50, 100, 100);

        // Восстанавливаем состояние контекста
        context.restore();

        // Обновляем позицию и угол
        x += dx;
        angle += dAngle; // Используем dAngle для изменения угла

        // Сбрасываем угол после полного оборота
        if (angle >= 360 || angle <= -360) {
            angle = 0;
        }

        // Проверяем столкновение с границами и меняем направление
        if (x <= 0) {
            dx = 5;       // Меняем направление движения по X вправо
            dAngle = -dAngle; // Меняем направление вращения
        } else if (x + 100 >= canvas.width) {
            dx = -5;      // Меняем направление движения по X влево
            dAngle = -dAngle; // Меняем направление вращения
        }

        // Запрашиваем следующий кадр анимации
        requestAnimationFrame(animate);
    }

    // Запускаем анимацию
    animate();
};

image.src = "img/ball.png";
