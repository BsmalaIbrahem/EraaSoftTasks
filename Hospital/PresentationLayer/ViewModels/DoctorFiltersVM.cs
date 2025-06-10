namespace PresentationLayer.ViewModels
{
    public class DoctorFiltersVM
    {
        public int ? SpecializationId { get; set; } = null;
        public string? DoctorName { get; set; } = null;
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 4;
    }
}
