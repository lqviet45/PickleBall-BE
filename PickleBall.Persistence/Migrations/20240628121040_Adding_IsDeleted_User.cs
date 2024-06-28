using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PickleBall.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Adding_IsDeleted_User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ApplicationUser",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ApplicationUser");
        }
    }
}
