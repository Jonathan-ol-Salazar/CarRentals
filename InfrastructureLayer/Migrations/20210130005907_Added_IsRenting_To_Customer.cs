using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentals.Migrations
{
    public partial class Added_IsRenting_To_Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRenting",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRenting",
                table: "Customers");
        }
    }
}
