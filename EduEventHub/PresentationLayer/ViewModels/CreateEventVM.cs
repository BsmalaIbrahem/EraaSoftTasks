﻿using DataLayer.Models;
using PresentationLayer.Validations;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.ViewModels
{
    public class CreateEventVM
    {
        [Required]
        [MaxLength(200, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string ImgPath { get; set; } = string.Empty;
        [Required(ErrorMessage = "StartDate is required.")]
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        [Required(ErrorMessage = "EndDate is required.")]
        public DateTime EndDate { get; set; } = DateTime.UtcNow.AddDays(1);
        [Required(ErrorMessage = "Price is required.")]
        public double Price { get; set; } = 0.0;
        [ListLengthAttribute(1)]
        public List<CreateAgendaVM> Agendas { get; set; } = new List<CreateAgendaVM>();

    }
}
