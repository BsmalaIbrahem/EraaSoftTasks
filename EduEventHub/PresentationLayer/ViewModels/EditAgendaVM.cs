using PresentationLayer.Validations;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class EditAgendaVM
    {
        public int AgendaId { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        [ListLengthAttribute(1)]
        public List<EditAgendaContentVM> Contents { get; set; } = new List<EditAgendaContentVM>();

    }
}
