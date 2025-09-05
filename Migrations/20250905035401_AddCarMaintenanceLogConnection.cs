using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoLog.Migrations
{
    /// <inheritdoc />
    public partial class AddCarMaintenanceLogConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceLogs_Cars_CarId",
                table: "MaintenanceLogs");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "MaintenanceLogs");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "MaintenanceLogs",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceLogs_Cars_CarId",
                table: "MaintenanceLogs",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceLogs_Cars_CarId",
                table: "MaintenanceLogs");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "MaintenanceLogs",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "MaintenanceLogs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceLogs_Cars_CarId",
                table: "MaintenanceLogs",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id");
        }
    }
}
