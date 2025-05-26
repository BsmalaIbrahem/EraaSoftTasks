using DataLayer.Models;

namespace PresentationLayer.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Specialization> Specializations { get; set; } = new List<Specialization>();
    }
}
