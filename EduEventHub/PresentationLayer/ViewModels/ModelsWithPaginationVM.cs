namespace PresentationLayer.ViewModels
{
    public class ModelsWithPaginationVM<T> where T : class
    {
        public IEnumerable<T> Items { get; set; } = new List<T>();
        public PaginationVM Pagination { get; set; } = new PaginationVM();
    }
    
}
