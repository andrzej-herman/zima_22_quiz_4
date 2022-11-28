using QuizLogic;

namespace QuizDesktop
{
    public partial class Form1 : Form
    {
        Game _game;

        public Form1()
        {
            InitializeComponent();
            StartGame();
            DisplayQuestion(_game.CurrentQuestion);
        }


        void StartGame()
        {
            _game = new Game();
            _game.GetQuestion();
        }

        void DisplayQuestion(Question question)
        {
            lblCategory.Text = $"Pytanie za {question.Category} pkt";
            lblContent.Text = question.Content;
            lblA1.Text = question.Answers[0].Content;
            lblA2.Text = question.Answers[1].Content;
            lblA3.Text = question.Answers[2].Content;
            lblA4.Text = question.Answers[3].Content;
        }
    }
}