// Получаем ссылки на изображения
const imgLeft = document.getElementById('img-left');
const imgCenter = document.getElementById('img-center');
const imgRight = document.getElementById('img-right');

// Обработка события наведения курсора мыши на центральное изображение
imgCenter.addEventListener('mouseenter', function() {
    // Увеличиваем высоту изображения на 10%
    imgCenter.style.scale = '110%';
});

// Обработка события ухода курсора мыши с центрального изображения
imgCenter.addEventListener('mouseleave', function() {
    // Возвращаем высоту изображения к исходной
    imgCenter.style.scale = '100%';
});

// Обработка события клика на центральном изображении
imgCenter.addEventListener('click', function() {
    // Получаем текущие значения атрибутов tr
    let trLeft = parseInt(imgLeft.getAttribute('tr'));
    let trCenter = parseInt(imgCenter.getAttribute('tr'));
    let trRight = parseInt(imgRight.getAttribute('tr'));

    // Обновляем значения tr для сдвига изображений
    trLeft = trCenter;
    trCenter = trRight;
    trRight = trRight + 1;

    // Если индекс превышает количество изображений, возвращаемся к первому
    if (trRight > 5) {
        trRight = 1;
    }

    // Обновляем атрибуты src и tr для каждого изображения
    imgLeft.src = 'images/parr' + trLeft + '.jpg';
    imgLeft.setAttribute('tr', trLeft);

    imgCenter.src = 'images/parr' + trCenter + '.jpg';
    imgCenter.setAttribute('tr', trCenter);

    imgRight.src = 'images/parr' + trRight + '.jpg';
    imgRight.setAttribute('tr', trRight);
});
