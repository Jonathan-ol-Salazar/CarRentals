using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentals.Migrations
{
    public partial class Changed_Vehicle_Seats_Sunroof : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SunRoof",
                table: "Vehicles",
                newName: "Sunroof");

            migrationBuilder.RenameColumn(
                name: "NumSeats",
                table: "Vehicles",
                newName: "Seats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sunroof",
                table: "Vehicles",
                newName: "SunRoof");

            migrationBuilder.RenameColumn(
                name: "Seats",
                table: "Vehicles",
                newName: "NumSeats");
        }
    }
}
