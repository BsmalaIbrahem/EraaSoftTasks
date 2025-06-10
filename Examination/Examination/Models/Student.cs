using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        [Column(TypeName = "text")]
        public string Passworsd { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public int GradeId { get; set; }
        [ForeignKey("GradeId")]
        public GradeLevel GradeLevel { get; set; } = null!;

        public ICollection<StudentExam> Exams { get; set; } = new List<StudentExam>();
    }

    public enum Gender
    {
        Male,
        Female
    }
}
