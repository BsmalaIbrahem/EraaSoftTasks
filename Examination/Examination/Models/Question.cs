using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        [ForeignKey("ExamId")]
        public Exam Exam { get; set; } = new Exam();
        public TypeQuestion Type { get; set; }
        [Column(TypeName = "text")]
        public string Body { get; set; } = string.Empty;
        public int Marks { get; set; } 
        public bool? IsAnsweredTrue { get; set; }

        public ICollection<QuestionOption> QuestionOptions { get; set; } = new List<QuestionOption>();

    }

    public enum TypeQuestion{
        TrueOrFalse,
        ChooseOne,
        MultipleChoose
    }
}
