using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Game
    {
        public Game()
        {
            CurrentCategory = 100;
            GenerateQuestions();
            Random = new Random();
        }

        public int CurrentCategory { get; set; }
        public List<Question> AllQuestions { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }

        private void GenerateQuestions()
        {
            var path = Directory.GetCurrentDirectory() + "\\questions.json";
            var json = File.ReadAllText(path);
            AllQuestions = JsonConvert.DeserializeObject<List<Question>>(json);
        }

        public void GetQuestion()
        {
            var currentCategoryQuestions = AllQuestions.Where(q => q.Category == CurrentCategory).ToList();
            var number = Random.Next(0, currentCategoryQuestions.Count());
            var selectedQuestion = currentCategoryQuestions[number];
            selectedQuestion.Answers = selectedQuestion.Answers.OrderBy(a => Random.Next()).ToList();
            var index = 1;
            foreach (var answer in selectedQuestion.Answers)
            {
                answer.DisplayOrder = index;
                index++;
            }
           
            CurrentQuestion = selectedQuestion;
        }

    }
}
