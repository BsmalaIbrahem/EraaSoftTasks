using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        [RegularExpression("0-9")]
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateOnly? Birthday { get; set; }
        public ICollection<Homework> HomeworkSubmissions { get; set; } = new List<Homework>();
    }
}
