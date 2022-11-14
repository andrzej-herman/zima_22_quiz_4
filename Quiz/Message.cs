using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Message
    {
        public void DisplayWelcome()
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

        public void DisplayGameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Niestety to nie jest prawidłowa odpowiedź");
            Console.WriteLine("GAME OVER !!!");
            Console.ReadLine();
        }

        internal void DisplayFinalScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Super !!! Udało Ci się ukończyć QUIZ.");
            Console.WriteLine("GRATULACJE !!!");
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }

        internal void DisplayGoodAnswer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Brawo to prawidłowa odpowiedź");
            Console.WriteLine("Naciśnij ENTER aby zobaczyć następne pytanie ...");
            Console.ReadLine();
        }
    }
}
