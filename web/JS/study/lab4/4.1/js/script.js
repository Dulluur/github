document.getElementById('quiz-form').addEventListener('submit', function(e) {

    const questions = 6;
    var score = 0;


    for (let i = 1; i <= questions; i++) {
        const questionAnswer = document.querySelector(input[name="q${i}"]:checked);
        if (questionAnswer) {
            score += parseInt(questionAnswer.value);
        }
    }
    alert(Вы правильно ответили на ${score} из ${questions} вопросов.);
});