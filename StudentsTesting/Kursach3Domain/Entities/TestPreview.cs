using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach3Domain.Entities
{
    public class TestPreview
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionShort { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Course { get; set; }
        public int NumberOfQuestions { get; set; }
    }
}
