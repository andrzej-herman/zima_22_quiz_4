using Quiz;

var person = new Person("Juri", "Nowak");






var game = new Game();
var message = new Message();
message.DisplayWelcome();

while (true)
{
    game.GetQuestion();
    var answer = game.CurrentQuestion.Show(game.IsWheelAvailable);
    if (answer == 5)
    {
        game.IsWheelAvailable= false;
        game.GetQuestionWithWheel();
        answer = game.CurrentQuestion.Show(game.IsWheelAvailable);
    }

    if (game.IsCorrectAnswer(answer))
    {
        if (game.CheckIfFinalQuestion())
        {
            message.DisplayFinalScreen();
            break;
        }
        else
        {
            message.DisplayGoodAnswer();
        }
    }
    else
    {
        message.DisplayGameOver();
        break;
    }
}

Console.ReadLine();
