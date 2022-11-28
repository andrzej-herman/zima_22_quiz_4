using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal static class StringHelper
    {
        public static string ConvertToZl(decimal price)
        {
            return $"{price} zł";
        }
    }
}
