using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class EditAgendaContentVM
    {
        public int ContentId { get; set; } = 0;
        [Required(ErrorMessage = "speaker is required.")]
        public int SpeakerId { get; set; }
        [Required(ErrorMessage = "Subject is required.")]
        public string Subject { get; set; } = string.Empty;
        [Required(ErrorMessage = "StartTime is required.")]
        public TimeOnly StartTime { get; set; }
    }
}
