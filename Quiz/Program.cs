using Quiz;

var game = new Game();
var message = new Message();
message.DisplayWelcome();
game.GetQuestion();
var answer = game.CurrentQuestion.Show();
if (game.IsCorrectAnswer(answer))
{
    if (game.CheckIfFinalQuestion())
    {
        message.DisplayFinalScreen();
    }
    else
    {
        message.DisplayGoodAnswer();
        
    }
}
else
{
    message.DisplayGameOver();
}

Console.WriteLine(answer);