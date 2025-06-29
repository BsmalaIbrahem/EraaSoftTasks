﻿using PresentationLayer.Validations;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class CreateAgendaVM
    {
        [Required(ErrorMessage = "Agenda date is required")]
        public DateTime Date { get; set; } = DateTime.UtcNow;
        [ListLengthAttribute(1)]
        public List<CreateAgendaContentVM> Contents { get; set; } = new List<CreateAgendaContentVM>();
    }
}
