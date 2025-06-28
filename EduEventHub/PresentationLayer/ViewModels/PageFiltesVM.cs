namespace PresentationLayer.ViewModels
{
    public class PageFiltesVM
    {
        public int? PageNumber { get; set; } = 1;
        public int? PageSize { get; set; } = 5;
        public int? SkipNumber => (PageNumber - 1) * PageSize;
    }
}
