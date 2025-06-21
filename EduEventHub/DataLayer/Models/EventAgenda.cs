using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class EventAgenda : BaseModel
    {
        public int EventId { get; set; }
        [ForeignKey(nameof(EventId))]
        public Event Event { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public ICollection<EventContent> EventAgendaContents { get; set; } = new List<EventContent>();
    }
}
