using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class EventContent : BaseModel
    {
        public int EventAgendaId { get; set; }
        [ForeignKey(nameof(EventAgendaId))]
        public EventAgenda EventAgenda { get; set; } = null!;
        public int SpeakerId { get; set; }
        [ForeignKey(nameof(SpeakerId))]
        public Speaker Speaker { get; set; } = null!;
        public string Subject { get; set; } = string.Empty;
        public TimeOnly StartTime { get; set; }
    }
}
