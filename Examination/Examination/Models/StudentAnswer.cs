using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Models
{
    [PrimaryKey(nameof(StudentId), nameof(OptionId))]
    public class StudentAnswer
    { 
        public int StudentId {  get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; } = null!;
        
        public int OptionId { get; set; }
        [ForeignKey("OptionId")]
        public QuestionOption QuestionOption { get; set; } = null!;

        public AnswerStatus Status { get; set; }
    }

    public enum AnswerStatus
    {
        NotAnswered,
        Right,
        Wrong
    }
}
