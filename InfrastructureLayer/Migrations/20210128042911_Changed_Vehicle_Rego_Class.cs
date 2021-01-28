using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentals.Migrations
{
    public partial class Changed_Vehicle_Rego_Class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehicleClass",
                table: "Vehicles",
                newName: "ClassType");

            migrationBuilder.RenameColumn(
                name: "VehicleRego",
                table: "Vehicles",
                newName: "Rego");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClassType",
                table: "Vehicles",
                newName: "VehicleClass");

            migrationBuilder.RenameColumn(
                name: "Rego",
                table: "Vehicles",
                newName: "VehicleRego");
        }
    }
}
