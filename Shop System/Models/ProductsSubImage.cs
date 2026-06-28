using Microsoft.EntityFrameworkCore;

namespace Shop_System.Models
{
    [PrimaryKey(nameof(ProductsId),nameof(Img))]
    public class ProductsSubImage
    {
        public int ProductsId { get; set; }
        public Product Products { get; set; }
        public string Img { get; set; }
    }
}
