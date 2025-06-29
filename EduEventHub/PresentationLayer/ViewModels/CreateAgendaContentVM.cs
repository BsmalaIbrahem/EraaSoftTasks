﻿using DataLayer.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PresentationLayer.ViewModels
{
    public class CreateAgendaContentVM
    {
        [Required(ErrorMessage = "speaker is required.")]
        public int SpeakerId { get; set; }
        [Required(ErrorMessage = "Subject is required.")]
        public string Subject { get; set; } = string.Empty;
        [Required(ErrorMessage = "StartTime is required.")]
        public TimeOnly StartTime { get; set; }
    }
}
