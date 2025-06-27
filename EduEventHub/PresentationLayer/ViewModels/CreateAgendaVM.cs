namespace PresentationLayer.ViewModels
{
    public class CreateAgendaVM
    {
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public List<CreateAgendaContentVM> Contents { get; set; } = new List<CreateAgendaContentVM>();
    }
}
