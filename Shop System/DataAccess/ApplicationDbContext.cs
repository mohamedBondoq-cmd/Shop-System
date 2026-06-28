using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Shop_System.DataAccess
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> categories {  get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Productscolor> productscolors { get; set; }
        public DbSet<ProductsSubImage> productsimages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source =.;initial catalog = Shop System; Integrated Security = True; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = True;");
        }
    }
}
