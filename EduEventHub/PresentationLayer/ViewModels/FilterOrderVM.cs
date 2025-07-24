using DataLayer.Models;

namespace PresentationLayer.ViewModels
{
    public class FilterOrderVM
    {
        public PageFiltesVM PageFilter { get; set; } = new PageFiltesVM();
        public OrderStstus? OrderStstus { get; set; } = null;
    }
}
