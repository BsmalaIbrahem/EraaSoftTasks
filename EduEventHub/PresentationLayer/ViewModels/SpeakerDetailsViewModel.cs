using DataLayer.Models;

namespace PresentationLayer.ViewModels
{
    public class SpeakerDetailsViewModel
    {
        public Speaker Speaker { get; set; } = null!;
        public IEnumerable<Event> Events { get; set; } = new List<Event>();
    }
}
