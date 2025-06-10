using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Models
{
    public class GradeLevel
    {
        public int Id { get; set; }
        public string level { get; set; } = string.Empty;
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
    }
}
