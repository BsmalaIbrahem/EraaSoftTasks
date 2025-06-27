using DataLayer.Models;

namespace PresentationLayer.ViewModels
{
    public class CreateEventVM
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string ImgPath { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime EndDate { get; set; } = DateTime.UtcNow.AddDays(1);
        public double Price { get; set; } = 0.0;
        public List<CreateAgendaVM> Agendas { get; set; } = new List<CreateAgendaVM>();

    }
}
