using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Doctor : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Img { get; set; }
        public int SpecializationId { get; set; }
        public Specialization specialization { get; set; } = null!;
    }
}
