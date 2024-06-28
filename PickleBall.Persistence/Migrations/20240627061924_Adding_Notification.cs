using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PickleBall.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Notification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeviceToken",
                table: "ApplicationUser",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeviceToken",
                table: "ApplicationUser");
        }
    }
}
