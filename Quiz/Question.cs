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

        private void DisplayQuestion(bool isWheelAvailable)
        {
            Console.WriteLine();
            Console.WriteLine($"Pytanie za {Category} pkt.");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();
            foreach (var a in Answers)
                Console.WriteLine($"{a.DisplayOrder}. {a.Content}");

            Console.WriteLine();
            var message = isWheelAvailable
                ? "Naciśnij numer prawidłowej odpowiedzi 1, 2, 3, 4 lub P aby użyć opcji pół na pół => "
                : "Naciśnij numer prawidłowej odpowiedzi 1, 2, 3 lub 4 => ";

            Console.Write(message);
        }

        public int Show(bool isWheelAvailable)
        {
            Console.Clear();
            while (true)
            {
                DisplayQuestion(isWheelAvailable);
                var answer = Console.ReadLine();
                if (IsGoodKey(answer, isWheelAvailable))
                {
                    if (answer.ToLower() == "p") return 5;
                    return int.Parse(answer);
                }
                    
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nacisnąłeś nieprawidłowy klawisz ...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private bool IsGoodKey(string key, bool isWheelAvailable)
        {
            if (isWheelAvailable)
            {
                if (key.ToLower() == "P".ToLower())
                    return true;
            }

            var result = int.TryParse(key, out int x);
            return result && x > 0 && x < 5;
        }

    }

}
