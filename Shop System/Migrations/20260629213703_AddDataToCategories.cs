using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_System.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into categories (Name, Description, Status) values ('Mobiles', 'Sed sagittis.', 1);insert into categories (Name, Description, Status) values ('Laptops', 'Pellentesque viverra pede ac diam.', 0);insert into categories (Name, Description, Status) values ('Accessoris', 'Nulla mollis molestie lorem.', 1);insert into categories (Name, Description, Status) values ('Cameras', 'Duis aliquam convallis nunc.', 1);insert into categories (Name, Description, Status) values ('Tablets', 'Proin at turpis a pede posuere nonummy.', 1);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM categories");
        }
    }
}
