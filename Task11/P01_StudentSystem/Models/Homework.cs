using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public class Homework
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        [FileExtensions]
        public string Content { get; set; } = string.Empty;
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        [NotMapped]
        public Student Student { get; set; } = new Student();

        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        [NotMapped]
        public Course Course { get; set; } = new Course();
    }

    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
}
