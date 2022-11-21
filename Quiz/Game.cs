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
            GenerateQuestions();
            Random = new Random();
            Categories = AllQuestions
                .Select(q => q.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            CurrentCategory = Categories[CategoryIndex];
            IsWheelAvailable = true;
        }

        public int CurrentCategory { get; set; }
        public List<Question> AllQuestions { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }
        public List<int> Categories { get; set; }
        public int CategoryIndex { get; set; }
        public bool IsWheelAvailable { get; set; }

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

        public bool IsCorrectAnswer(int playerAnswer)
        {
            return CurrentQuestion.Answers.First(a => a.DisplayOrder == playerAnswer).IsCorrect;
        }

        public bool CheckIfFinalQuestion()
        {
            if (CategoryIndex == 6) return true;
            else
            {
                CategoryIndex++;
                CurrentCategory = Categories[CategoryIndex];
                return false;
            }
        }

        public void GetQuestionWithWheel()
        {
            var badAnswers = CurrentQuestion.Answers.Where(a => !a.IsCorrect);
            badAnswers = badAnswers.OrderBy(a => Random.Next());
            var removed = badAnswers.Take(2).ToList();  
            CurrentQuestion.Answers.Remove(removed[0]);
            CurrentQuestion.Answers.Remove(removed[1]);
        }

    }
}
