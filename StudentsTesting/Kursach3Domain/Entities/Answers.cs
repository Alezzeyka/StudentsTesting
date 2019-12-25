using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach3Domain.Entities
{
    public class Answers
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
    }
}
