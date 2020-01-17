using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppReCapModels.Migrations
{
    public partial class Added_Cakes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cakes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 63, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Servings = table.Column<int>(nullable: false),
                    GlutenFree = table.Column<bool>(nullable: false),
                    LactoseFree = table.Column<bool>(nullable: false),
                    NutsFree = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cakes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cakes");
        }
    }
}
