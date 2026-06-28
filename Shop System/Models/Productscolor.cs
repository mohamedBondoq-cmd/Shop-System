using Microsoft.EntityFrameworkCore;

namespace Shop_System.Models
{
    [PrimaryKey(nameof(ProductsId), nameof(Color))]
    public class Productscolor
    {
        public int ProductsId { get; set; }
        public Product Products { get; set; }
        public string Color { get; set; }
    }
}
