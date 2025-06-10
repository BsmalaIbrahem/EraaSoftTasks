using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; } = new Teacher();
        public int GradeId { get; set; }
        [ForeignKey("GradeId")]
        public GradeLevel GradeLevel { get; set; } = new GradeLevel();
        public int DurationInMinutes { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public ICollection<Question> Questions { get; set; } = new List<Question>();

        public ICollection<StudentExam> StudentExams { get; set; } = new List<StudentExam>();

    }
}
