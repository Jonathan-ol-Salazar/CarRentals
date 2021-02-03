using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentals.Migrations
{
    public partial class Changed_Customer_Gender_Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Customers",
                newName: "GenderType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenderType",
                table: "Customers",
                newName: "Gender");
        }
    }
}
