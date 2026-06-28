namespace Shop_System.Models
{
    public class Category
    {
    public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool Status { get; set; }
    }
}
