using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public class Resource
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Url { get; set; } = string.Empty ;
        public ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        [NotMapped]
        public Course Course { get; set; } = new Course();
    }

    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
}
