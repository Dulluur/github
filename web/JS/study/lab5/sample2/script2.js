let canvas = document.getElementById("canvas");
let context = canvas.getContext("2d");
let image = new Image();

image.onload = () => {
    let x=0, y=0;
    
    setInterval(() => {
        context.clearRect(x, y, 100, 100);
        if (x + 100 >= context.canvas.clientWidth) x=0;
        context.drawImage(image, x++, y, 100, 100);
    }, 10); 
};

image.src = "img/ball.png";
