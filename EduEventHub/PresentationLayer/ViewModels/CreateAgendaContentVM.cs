using DataLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PresentationLayer.ViewModels
{
    public class CreateAgendaContentVM
    {
        public int SpeakerId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public TimeOnly StartTime { get; set; }
    }
}
