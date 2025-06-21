using DataLayer.Models;

namespace PresentationLayer.ViewModels
{
    public class CustomerHomeVM
    {
        public IEnumerable<Event> Events { get; set; } = new List<Event>();
        public IEnumerable<Speaker> Speakers { get; set; } = new List<Speaker>();
    }
}
