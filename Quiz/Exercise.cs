using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    // Only Test class
    public  class Exercise
    {
        public void ExOne()
        {
            var numbers = new List<int>() { 65, 23, 12, 87, 173, 34, 4, 9, 18, 345, 100, 61 };
            Console.WriteLine("All:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            var selected = numbers.FirstOrDefault(n => n > 10000);
            Console.WriteLine("Selected:");
            Console.WriteLine(selected);
            //foreach (var item in selected)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
