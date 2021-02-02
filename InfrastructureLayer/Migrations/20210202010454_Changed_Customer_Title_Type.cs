using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentals.Migrations
{
    public partial class Changed_Customer_Title_Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "TitleType",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleType",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
