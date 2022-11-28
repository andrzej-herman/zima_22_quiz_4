using Quiz;
using QuizLogic;

var price = 34.50m;
Console.WriteLine(StringHelper.ConvertToZl(price));



var game = new Game();
Message.DisplayWelcome();




while (true)
{
    game.GetQuestion();
    var answer = Message.Show(game.CurrentQuestion, game.IsWheelAvailable);
    if (answer == 5)
    {
        game.IsWheelAvailable= false;
        game.GetQuestionWithWheel();
        answer = Message.Show(game.CurrentQuestion, game.IsWheelAvailable);
    }

    if (game.IsCorrectAnswer(answer))
    {
        if (game.CheckIfFinalQuestion())
        {
            Message.DisplayFinalScreen();
            break;
        }
        else
        {
            Message.DisplayGoodAnswer();
        }
    }
    else
    {
        Message.DisplayGameOver();
        break;
    }
}

Console.ReadLine();
