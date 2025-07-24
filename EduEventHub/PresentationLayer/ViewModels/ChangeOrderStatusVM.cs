using DataLayer.Models;

namespace PresentationLayer.ViewModels
{
    public class ChangeOrderStatusVM
    {
        public int OrderId { get; set; }
        public OrderStstus OrderStatus { get; set; } = OrderStstus.Pending;
    }
}
