using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DockerComposeDemoApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangedColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Drivers",
                newName: "DriverNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DriverNumber",
                table: "Drivers",
                newName: "Number");
        }
    }
}
