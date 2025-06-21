using DataLayer.Models;

namespace PresentationLayer.ViewModels
{
    public class EventsVM
    {
        public IEnumerable<Event> Events { get; set; } = new List<Event>();
        public PaginationVM Pagination { get; set; } = new PaginationVM();
    }
}
