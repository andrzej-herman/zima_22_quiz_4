using Quiz;

var game = new Game();
var message = new Message();
message.DisplayWelcome();
game.GetQuestion();
game.CurrentQuestion.Show();