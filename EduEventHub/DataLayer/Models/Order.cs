using DataLayer.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Order : BaseModel
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
        public double TotalPrice { get; set; }
        public string? SessionId { get; set; }
        public string? ReferenceId { get; set; }
        public OrderStstus Status { get; set; }
        public ICollection<EventOrder> Events { get; set; } = new List<EventOrder>();
    }

    public enum OrderStstus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Canceled,
        Failed,
        Refunded
    }
}
