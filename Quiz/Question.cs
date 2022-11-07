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

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();
            foreach (var a in Answers)
                Console.WriteLine($"{a.DisplayOrder}. {a.Content}");

            Console.WriteLine();
            Console.Write("Naciśnij numer prawidłowej odpowiedzi 1, 2, 3 lub 4 => ");

        }
    }
}
