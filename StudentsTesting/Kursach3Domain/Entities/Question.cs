using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach3Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public int NumberOfAnswers { get; set; }
        public string QuestionForm { get; set; }
        public int CorrectAnswerId { get; set; }
        List<string> Answers { get; set; }
    }
}
