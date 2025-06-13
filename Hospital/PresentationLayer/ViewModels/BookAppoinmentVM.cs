namespace PresentationLayer.ViewModels
{
    public class BookAppoinmentVM
    {
        public int DoctorId { get; set; }
        public DateOnly Date { get; set; }
        public string Time { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string? Details { get; set; } 
        public int ExaminationDuration { get; set; } = 30;
    }
}
