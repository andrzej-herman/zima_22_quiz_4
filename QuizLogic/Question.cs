using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLogic
{
    public  class Question
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
