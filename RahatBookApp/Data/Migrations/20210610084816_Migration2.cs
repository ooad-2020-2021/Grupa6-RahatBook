using Microsoft.EntityFrameworkCore.Migrations;

namespace RahatBookApp.Data.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tip",
                table: "SmjestajnaJedinica",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tip",
                table: "SmjestajnaJedinica");
        }
    }
}
