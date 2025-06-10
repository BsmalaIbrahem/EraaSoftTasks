using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Models
{
    [PrimaryKey(nameof(ExamId), nameof(StudentId))]
    public class StudentExam
    {
        public int ExamId { get; set; }
        [ForeignKey("ExamId")]
        public Exam Exam { get; set; } = null!;

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get
            {
                return StartTime.AddMinutes(Exam.DurationInMinutes);
            }
        }

        public double GrandTotal { get; set; } = 0;
    }
}
