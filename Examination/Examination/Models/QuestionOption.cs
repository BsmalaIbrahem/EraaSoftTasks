using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Models
{
    public class QuestionOption
    {
        public int Id { get; set; }
        public string Value { get; set; } = string.Empty;
        public int QuestionId {  get; set; }
        public Question Question { get; set; } = null!;
        public bool IsAnswer { get; set; }
    }
}
