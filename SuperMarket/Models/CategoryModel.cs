namespace SuperMarket.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string? Price { get; set; } = string.Empty;
    }
}
