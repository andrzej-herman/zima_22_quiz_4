using QuizLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public static class Message
    {
        public static void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Witamy w Quizie");
            Console.WriteLine("Spróbuj odpowiedzieć na 7 pytań");
            Console.WriteLine("POWODZENIA !!!");
            Console.WriteLine();
            Console.WriteLine("Naciśnij ENTER aby rozpcząć grę ...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayGameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Niestety to nie jest prawidłowa odpowiedź");
            Console.WriteLine("GAME OVER !!!");
            Console.ReadLine();
        }

        internal static void DisplayFinalScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Super !!! Udało Ci się ukończyć QUIZ.");
            Console.WriteLine("GRATULACJE !!!");
            Console.WriteLine("GAME OVER");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        internal static void DisplayGoodAnswer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Brawo to prawidłowa odpowiedź");
            Console.WriteLine("Naciśnij ENTER aby zobaczyć następne pytanie ...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();
        }

        public static int Show(Question question, bool isWheelAvailable)
        {
            Console.Clear();
            while (true)
            {
                DisplayQuestion(question, isWheelAvailable);
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

        private static bool IsGoodKey(string key, bool isWheelAvailable)
        {
            if (isWheelAvailable)
            {
                if (key.ToLower() == "P".ToLower())
                    return true;
            }

            var result = int.TryParse(key, out int x);
            return result && x > 0 && x < 5;
        }


        private static void DisplayQuestion(Question question, bool isWheelAvailable)
        {
            Console.WriteLine();
            Console.WriteLine($"Pytanie za {question.Category} pkt.");
            Console.WriteLine();
            Console.WriteLine(question.Content);
            Console.WriteLine();
            foreach (var a in question.Answers)
                Console.WriteLine($"{a.DisplayOrder}. {a.Content}");

            Console.WriteLine();
            var message = isWheelAvailable
                ? "Naciśnij numer prawidłowej odpowiedzi 1, 2, 3, 4 lub P aby użyć opcji pół na pół => "
                : "Naciśnij numer prawidłowej odpowiedzi 1, 2, 3 lub 4 => ";

            Console.Write(message);
        }
    }
}
