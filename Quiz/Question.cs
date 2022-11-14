using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }

        private void DisplayQuestion()
        {
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();
            foreach (var a in Answers)
                Console.WriteLine($"{a.DisplayOrder}. {a.Content}");

            Console.WriteLine();
            Console.Write("Naciśnij numer prawidłowej odpowiedzi 1, 2, 3 lub 4 => ");
        }

        public int Show()
        {
            while (true)
            {
                DisplayQuestion();
                var answer = Console.ReadLine();
                if (IsGoodKey(answer))
                    return int.Parse(answer);
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nacisnąłeś nieprawidłowy klawisz ...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private bool IsGoodKey(string key)
        {
            var result = int.TryParse(key, out int x);
            return result && x > 0 && x < 5;
        }

    }

}
